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
        private int _Timeout;

        public ClientHttp(string serverToken, int timeout)
        {
            string[] texts = serverToken.Split(URL_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
            if (texts.Length != 3)
                throw new ArgumentException("Invalid token");

            _Url = "http://" + texts[0];
            _ServerGUID = texts[1];
            _UserGUID = texts[2];
            _ConcatenatedUrl=_Url + "/" + _ServerGUID + "/" + _UserGUID;
            _Timeout = timeout;
        }

        public bool GetServerDetails(out GameServerDetails gameServerDetails)
        {
            try
            {
                string result = HttpPost(_ConcatenatedUrl, "GetServerDetails", _Timeout);
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
                string result = HttpPost(_ConcatenatedUrl, "GetServerState", _Timeout);
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

                string result = HttpPost(_ConcatenatedUrl, command, _Timeout);
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
                string result = HttpPost(_ConcatenatedUrl, "Stop", _Timeout);
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



        public string HttpPost(string URI, string data, int timeout)
        {
            System.Net.WebRequest webRequest = System.Net.WebRequest.Create(URI);
            if (timeout > 0)
                webRequest.Timeout = timeout;
            webRequest.Proxy = null;
            webRequest.ContentType = "application/x-www-form-urlencoded";//Add these, as we're doing a POST
            webRequest.Method = "POST";
            //We need to count how many bytes we're sending. 
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            webRequest.ContentLength = bytes.Length;
            System.IO.Stream requestStream = webRequest.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);
            requestStream.Close();

            System.Net.WebResponse webResponse = webRequest.GetResponse();
            if (webResponse == null)
                return null;

            using (System.IO.StreamReader streamReader = new System.IO.StreamReader(webResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd().Trim();
            }
        }
    }
}
