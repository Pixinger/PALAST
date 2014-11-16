using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM
{
    public class ClientHttp
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        private readonly char[] URL_SEPERATOR = new char[] { '/' };
        private readonly char[] ADDONINFO_SEPERATOR = new char[] { '|' };

        private string _Url;
        private string _UserGUID;
        private string _ServerGUID;
        private string _ConcatenatedUrl;

        public ClientHttp(string serverToken)
        {
            string[] texts = serverToken.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
            if (texts.Length != 3)
                throw new ArgumentException("Invalid token");

            _Url = "http://" + texts[0];
            _ServerGUID = texts[1];
            _UserGUID = texts[2];
            _ConcatenatedUrl=_Url + "/" + _ServerGUID + "/" + _UserGUID;
        }

        public bool GetServerDetails(out GameServerDetails gameServerDetails)
        {
            try
            {
                string result = HttpPost(_ConcatenatedUrl, "GetServerDetails");
                string[] commands = result.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                if ((commands.Length >= 2) && (commands[0] == "OK"))
                {
                    gameServerDetails = new GameServerDetails();
            
                    if (!Enum.TryParse<ServerStates>(commands[1], out gameServerDetails.Status))
                        return false;

                    List<GameServerDetails.AddonInfo> addons = new List<GameServerDetails.AddonInfo>();
                    for (int i = 2; i < commands.Length; i++)
                    {
                        string[] addonInfos = commands[i].Split(ADDONINFO_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                        if (addonInfos.Length == 2)
                        {
                            GameServerDetails.AddonInfo addon = new GameServerDetails.AddonInfo();
                            addon.Name = addonInfos[0];
                            addon.Enabled = (addonInfos[1].ToLower() == "true");
                            addons.Add(addon);
                        }
                    }

                    gameServerDetails.Addons = addons.ToArray();
                    return true;
                }
                else
                    LOG.Error("Received invalid response: " + result);
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }

            gameServerDetails = null;
            return false;
        }
        public bool GetServerState(out ServerStates serverState)
        {
            try
            {
                string result = HttpPost(_ConcatenatedUrl, "GetServerState");
                string[] commands = result.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                if ((commands.Length == 2) && (commands[0] == "OK"))
                {
                    if (Enum.TryParse<ServerStates>(commands[1], out serverState))
                        return true;
                }
                else
                    LOG.Error("Received invalid response: " + result);
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }

            serverState = ServerStates.Unknown;
            return false;
        }
        public bool Start(string[] addonsEnabled)
        {
            try
            {
                if (addonsEnabled == null)
                    addonsEnabled = new string[0];

                string command = "Start/";
                foreach(string addon in addonsEnabled)
                    command += addon + "/";

                string result = HttpPost(_ConcatenatedUrl, command);
                string[] commands = result.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                if ((commands.Length == 1) && (commands[0] == "OK"))
                    return true;
                else
                    LOG.Error("Received invalid response: " + result);
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }

            return false;
        }
        public bool Stop()
        {
            try
            {
                string result = HttpPost(_ConcatenatedUrl, "Stop");
                string[] commands = result.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
                if ((commands.Length == 1) && (commands[0] == "OK"))
                    return true;
                else
                    LOG.Error("Received invalid response: " + result);
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }

            return false;
        }

      

        public static string HttpPost(string URI, string Parameters)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(URI);
            req.Proxy = null;// new System.Net.WebProxy(ProxyString, true);
            //Add these, as we're doing a POST
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            //We need to count how many bytes we're sending. Post'ed Faked Forms should be name=value&
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(Parameters);
            req.ContentLength = bytes.Length;
            System.IO.Stream os = req.GetRequestStream();
            os.Write(bytes, 0, bytes.Length); //Push it out there
            os.Close();
            System.Net.WebResponse resp = req.GetResponse();
            if (resp == null) return null;
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string s = sr.ReadToEnd().Trim();

            LOG.Debug("Received: " + s);
            return s;
        }

      
    }
}
