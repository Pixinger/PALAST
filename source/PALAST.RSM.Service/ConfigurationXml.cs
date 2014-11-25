using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM.Service
{
    [Serializable]
	public class ConfigurationXml
    {
        #region Load/Save
        public const string FILENAME = "PALAST.RSM.Service.xml";
        public static ConfigurationXml Sample()
        {
            ConfigurationXml instance = new ConfigurationXml();
            instance.GameServers = new GameServerXml[1];
            instance.GameServers[0] = new GameServerXml();
            instance.GameServers[0].Description = "Automatic created sample";// Guid.NewGuid().ToString();
            instance.GameServers[0].GUID = "9a8a1f01-eec8-463a-be5c-e7f4ca2bd713";// Guid.NewGuid().ToString();

            instance.GameServers[0].Users = new GameServerXml.UserXml[1];
            instance.GameServers[0].Users[0] = new GameServerXml.UserXml();
            instance.GameServers[0].Users[0].UserGuid = "d6010d0b-a22a-4af0-92c5-58cbf840d220";// Guid.NewGuid().ToString();
            instance.GameServers[0].Users[0].UserName = "TestUser";
            instance.GameServers[0].Users[0].ServerPrivateKey = "";
            instance.GameServers[0].Users[0].ServerPublicKey = "";
            instance.GameServers[0].Users[0].UserPrivateKey = "";
            instance.GameServers[0].Users[0].UserPublicKey = "";

            instance.GameServers[0].PreProcess = new GameServerXml.ProcessXml();
            instance.GameServers[0].PreProcess.WorkingDirectory = @"D:\";
            instance.GameServers[0].PreProcess.FileName = @"D:\DummyApp.exe";
            instance.GameServers[0].PreProcess.Arguments = "";
            instance.GameServers[0].PreProcess = null;

            instance.GameServers[0].GameServerProcess = new GameServerXml.ProcessXml();
            instance.GameServers[0].GameServerProcess.WorkingDirectory = @"C:\Program Files (x86)\Steam\SteamApps\common\Arma 3";
            instance.GameServers[0].GameServerProcess.FileName = @"C:\Program Files (x86)\Steam\SteamApps\common\Arma 3\arma3server.exe";
            instance.GameServers[0].GameServerProcess.Arguments = "";

            instance.GameServers[0].PostProcess = new GameServerXml.ProcessXml();
            instance.GameServers[0].PostProcess.WorkingDirectory = @"D:\";
            instance.GameServers[0].PostProcess.FileName = @"D:\DummyApp.exe";
            instance.GameServers[0].PostProcess.Arguments = "";
            instance.GameServers[0].PostProcess = null;

            return instance;
        }

        public static ConfigurationXml Load()
        {
            try
            {
                return SerializationTools.FromFilename<ConfigurationXml>(FILENAME);
            }
            catch
            {
                return null;
            }
        }
        public void Save()
        {
            SerializationTools.Save<ConfigurationXml>(FILENAME, this);
        }
        #endregion

        public string GetNewGameServerGUID()
        {        
            while (true)
            {
                string guid = CreatePassword(32);
                guid = guid .Replace('/', 'd');

                if (GameServers == null)
                    return guid;
                else
                {
                    bool valid = true;
                    foreach (GameServerXml gameServer in GameServers)
                        if (gameServer.GUID == guid)
                        {
                            valid = false;
                            break;
                        }

                    if (valid)
                        return guid;
                }                
            }
        }
        public string GetNewUserGUID(string gameServerGuid)
        {
            string guid = CreatePassword(32);
            guid = guid.Replace('/', 'd');

            if (GameServers == null)
                return guid;

            foreach (GameServerXml gameServer in GameServers)
            {
                if (gameServer.GUID == gameServerGuid)
                {
                    while (true)
                    {
                        if (gameServer.Users == null)
                            return guid;
                        else
                        {
                            bool valid = true;
                            foreach (GameServerXml.UserXml user in gameServer.Users)
                            {
                                if (user.UserGuid == guid)
                                {
                                    valid = false;
                                    break;
                                }
                            }

                            if (valid)
                                return guid;
                        }

                        guid = CreatePassword(32);
                        guid = guid.Replace('/', 'd');
                    }
                }
            }

            return guid;
        }

        public string GetToken(string gameServerGuid, string userGuid)
        {
            if (GameServers == null)
                return null;

            for (int i = 0; i < GameServers.Length; i++)
            {
                if (GameServers[i].GUID == gameServerGuid)
                {
                    GameServerXml gameServer = GameServers[i];
                    if (gameServer.Users != null)
                    {
                        for (int o = 0; o < gameServer.Users.Length; o++)
                        {
                            if (gameServer.Users[o].UserGuid == userGuid)
                            {
                                return ServerIP + ":" + ServerPort + "/" + gameServerGuid + "/" + userGuid;
                            }
                        }
                    }
                }
            }

            return null;
        }
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public bool Validate()
        {
            if (GameServers == null)
                GameServers = new GameServerXml[0];

            return true;
        }

        public ConfigurationXml()
        {
        }

        [XmlElement]
        public string ServerIP = "127.0.0.1";
        [XmlElement]
        public int ServerPort = 12000;
        [XmlElement]
        public int MaxAllowedSizeMB = 10;

        [XmlElement("GameServer")]
        public GameServerXml[] GameServers;
	}
}
