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

                if (httpListenerContext.Request.ContentLength64 <= MAX_LENGTH)
                    new System.Threading.Tasks.Task(() => OnProcessContext(httpListenerContext)).Start();
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
                string[] commands = httpListenerContext.Request.RawUrl.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);

                if (commands.Length == 2)
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(httpListenerContext.Response.OutputStream))
                    {
                        GameServerXml.UserXml user = GetUserConfiguration(commands[0], commands[1]);
                        if (user != null)
                        {
                            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(httpListenerContext.Request.InputStream))
                            {
                                string concatenatedData = streamReader.ReadToEnd();
                                string[] subCommands = concatenatedData.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                                if (commands.Length > 0)
                                {
                                    if (subCommands[0] == "GetServerState")
                                    {
                                        LOG.Info("GetServerState: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                        ServerStates status = _IGameServerManager.GetServerState(commands[0]);
                                        streamWriter.Write("OK/" + status.ToString());
                                    }
                                    else if (subCommands[0] == "GetServerDetails")
                                    {
                                        LOG.Info("GetServerDetails: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                        GameServerDetails gameServerDetails = _IGameServerManager.GetServerDetails(commands[0]);
                                        if (gameServerDetails != null)
                                        {
                                            streamWriter.Write("OK/" + gameServerDetails.Status.ToString() + "/");
                                            if (gameServerDetails.Addons != null)
                                                foreach (GameServerDetails.AddonInfo addon in gameServerDetails.Addons)
                                                    streamWriter.Write(addon.Name + "|" + addon.Enabled + "/");
                                        }
                                        else
                                            streamWriter.Write("ERROR");
                                    }
                                    else if (subCommands[0] == "Start")
                                    {
                                        LOG.Info("Start: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                        List<string> addons = new List<string>(subCommands.Length - 1);
                                        for (int i = 1; i < subCommands.Length ; i++)
                                            addons.Add(subCommands[i]);

                                        if (!_IGameServerManager.Start(commands[0], addons.ToArray()))
                                            streamWriter.Write("UNABLE");
                                        else
                                            streamWriter.Write("OK");
                                    }
                                    else if (subCommands[0] == "Stop")
                                    {
                                        LOG.Info("Stop: " + httpListenerContext.Request.RemoteEndPoint.ToString());
                                        if (!_IGameServerManager.Stop(commands[0]))
                                            streamWriter.Write("UNABLE");
                                        else
                                            streamWriter.Write("OK");
                                    }
                                    else
                                        streamWriter.Write("ERROR");
                                }
                                else
                                    streamWriter.Write("INVALID_CMD");
                            }
                        }
                        else
                            streamWriter.Write("INVALID_USR");
                    }
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
        }
    }
}
