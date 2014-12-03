using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PALAST.RSM.Service
{
    public class ServerHttp : IDisposable
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        private const int MAX_LENGTH = 10000;
        private object _SyncObject = new object();
        private readonly char[] URL_SEPERATOR = new char[] { '/' };


        private HttpListener _HttpListener;
        private ConfigurationXml _Configuration;
        private IGameServerManager _IGameServerManager;

        public ServerHttp(ConfigurationXml configuration, IGameServerManager iGameServerManager)
        {
            if (configuration == null)
                throw new ArgumentNullException();
            if (string.IsNullOrWhiteSpace(configuration.ServerIP))
                throw new ArgumentNullException("configuration.ServerIP");
            if (iGameServerManager == null)
                throw new ArgumentNullException();

            _Configuration = configuration;
            _IGameServerManager = iGameServerManager;

            //string prefix = "http://" + configuration.ServerIP + ":" + configuration.ServerPort + "/";
            string prefix = "http://*:" + configuration.ServerPort + "/";
            _HttpListener = new HttpListener();
            _HttpListener.Prefixes.Add(prefix);

            _HttpListener.Start();
            _HttpListener.BeginGetContext(new AsyncCallback(OnBeginGetContext), null);
        }
        #region IDisposable Member
        ~ServerHttp()
        {
            Dispose(false);
        }
        private bool _Disposed = false;
        private bool _Disposing = false;
        public bool Disposed
        {
            get { return _Disposed; }
        }
        public bool Disposing
        {
            get { return _Disposing; }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            _Disposing = true;
            OnDispose(disposing);
            _Disposing = false;
            _Disposed = true;
        }
        #endregion
        protected virtual void OnDispose(bool disposing)
        {
            try
            {
                _HttpListener.Stop();
                _HttpListener.Close();
            }
            catch
            {
            }
        }

        private GameServerXml.UserXml GetUserConfiguration(string serverGuid, string userGuid)
        {
            for (int i = 0; i < _Configuration.GameServers.Length; i++)
                if (_Configuration.GameServers[i].GUID == serverGuid)
                {
                    GameServerXml gameServer = _Configuration.GameServers[i];
                    for (int o = 0; o < gameServer.Users.Length; o++)
                        if (gameServer.Users[o].UserGuid == userGuid)
                            return gameServer.Users[o];
                }

            return null;
        }

        private void OnBeginGetContext(IAsyncResult ar)
        {
            try
            {
                HttpListenerContext httpListenerContext = _HttpListener.EndGetContext(ar);

                _HttpListener.BeginGetContext(new AsyncCallback(OnBeginGetContext), null);

                if (httpListenerContext.Request.ContentLength64 <= _Configuration.MaxAllowedSizeMB * 1024 * 1024)
                {
                    new System.Threading.Tasks.Task(() => OnProcessContext(httpListenerContext)).Start();
                }
                else
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(httpListenerContext.Response.OutputStream))
                    {
                        streamWriter.Write("ErrorMaximumSize");
                    }
                }
            }
            catch (ObjectDisposedException)
            {
            }
            catch (HttpListenerException ex)
            {
                if (ex.ErrorCode != 995) // 995 kommt manchmal vor, wenn der Listener beendet wird.
                    LOG.Error(ex);
            }
        }
        private void OnProcessContext(HttpListenerContext httpListenerContext)
        {
            try
            {
                string[] rawUrlSplits = httpListenerContext.Request.RawUrl.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                if (rawUrlSplits.Length >= 3) 
                {
                    string serverGuid = rawUrlSplits[0];
                    string userGuid = rawUrlSplits[1];
                    string command = rawUrlSplits[2];
                    for (int i = 3; i < rawUrlSplits.Length; i++)
                        rawUrlSplits[i] = Uri.UnescapeDataString(rawUrlSplits[i]);

                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(httpListenerContext.Response.OutputStream))
                    {
                        GameServerXml.UserXml user = GetUserConfiguration(serverGuid, userGuid);
                        if (user != null)
                        {
                            if ((command == "Mission") && (rawUrlSplits.Length == 5))
                            {
                                //"%5BTK%5DPersistentCampaign.Altis.pbo"
                                bool overwrite = (rawUrlSplits[3] == bool.TrueString);
                                string filename = rawUrlSplits[4];
                                LOG.Info("MissionUpload von Benutzer: " + user.UserName + " IP:" + httpListenerContext.Request.RemoteEndPoint.ToString() + " filename: " + filename + " overwrite: " + overwrite.ToString());
                                if (user.AllowMissionUpload)
                                {
                                    MissionResults result = _IGameServerManager.MissionUpload(serverGuid, overwrite, filename, httpListenerContext.Request.InputStream);
                                    streamWriter.Write(result.ToString());
                                }
                                else
                                {
                                    LOG.Warn("NOT ALLOWED: MissionUpload von Benutzer: " + user.UserName + " IP:" + httpListenerContext.Request.RemoteEndPoint.ToString() + " filename: " + filename + " overwrite: " + overwrite.ToString());
                                    streamWriter.Write(MissionResults.ErrorNotAllowed.ToString());
                                }
                            }
                            else if ((command == "GetServerState") && (rawUrlSplits.Length == 3))
                            {
                                LOG.Debug("GetServerState: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                ServerStates status = _IGameServerManager.GetServerState(serverGuid);
                                streamWriter.Write("OK/" + status.ToString());
                            }
                            else if ((command == "GetServerDetails") && (rawUrlSplits.Length == 3))
                            {
                                LOG.Debug("GetServerDetails: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                GameServerDetails gameServerDetails = _IGameServerManager.GetServerDetails(serverGuid);
                                if (gameServerDetails != null)
                                {
                                    streamWriter.Write("OK/" + gameServerDetails.Status.ToString() + "/");
                                    if (gameServerDetails.Addons != null)
                                        foreach (GameServerDetails.AddonInfo addon in gameServerDetails.Addons)
                                            streamWriter.Write(addon.Name + "|" + addon.Enabled + "/");
                                }
                                else
                                    streamWriter.Write("ErrorNoDetails");
                            }
                            else if ((command == "Start") && (rawUrlSplits.Length == 3))
                            {
                                if (user.AllowServerStart)
                                {
                                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(httpListenerContext.Request.InputStream))
                                    {
                                        LOG.Info("Start von Benutzer: " + user.UserName + " IP:" + httpListenerContext.Request.RemoteEndPoint.ToString());
                                        List<string> addons = new List<string>();
                                        string data = streamReader.ReadToEnd();
                                        if ((!string.IsNullOrWhiteSpace(data)) && (data.Contains("@")))
                                        {
                                            string[] addonSplit = data.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                                            for (int i = 0; i < addonSplit.Length; i++)
                                                if (addonSplit[i].StartsWith("@"))
                                                    addons.Add(addonSplit[i]);
                                        }

                                        if (!_IGameServerManager.Start(serverGuid, addons.ToArray()))
                                            streamWriter.Write("ErrorUnable");
                                        else
                                            streamWriter.Write("OK");
                                    }
                                }
                                else
                                {
                                    LOG.Warn("NOT ALLOWED: Start von Benutzer: " + user.UserName + " IP:" + httpListenerContext.Request.RemoteEndPoint.ToString());
                                    streamWriter.Write("ErrorNotAllowed");
                                }
                            }
                            else if ((command == "Stop") && (rawUrlSplits.Length == 3))
                            {
                                if (user.AllowServerStop)
                                {
                                    LOG.Info("Stop von Benutzer: " + user.UserName + " IP: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                    if (!_IGameServerManager.Stop(serverGuid))
                                        streamWriter.Write("ErrorUnable");
                                    else
                                        streamWriter.Write("OK");
                                }
                                else
                                {
                                    LOG.Warn("NOT ALLOWED: Stop von Benutzer: " + user.UserName + " IP: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                    streamWriter.Write("ErrorNotAllowed");
                                }
                            }
                            else
                                streamWriter.Write("ErrorInvalidCommand");
                        }
                        else
                            streamWriter.Write("ErrorInvalidUser");
                    } // using (StreamWriter...
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
        }
    }
}
