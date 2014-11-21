using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.Query
{
    public  class SteamQuery
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        #region private class QueryUdp: IDisposable
        private class QueryUdp : IDisposable
        {
            public byte[] _Buffer;
            public UdpClient _UdpClient;
            public IPEndPoint _IPEndPoint;
            public System.Threading.ManualResetEvent _ManualResetEvent;

            public QueryUdp()
            {
                _UdpClient = new UdpClient();
            }
            #region IDisposable Member
            ~QueryUdp()
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
                _UdpClient.Close();
            }

            public byte[] Execute(byte[] command, IPEndPoint address, int timeout)
            {
                try
                {
                    _ManualResetEvent = new System.Threading.ManualResetEvent(false);
                    _UdpClient.Send(command, command.Length, address);
                    _UdpClient.BeginReceive(new AsyncCallback(OnBeginReceive), null);

                    if (_ManualResetEvent.WaitOne(timeout))
                        return _Buffer;
                    else
                        return null;
                }
                catch
                {
                    return null;
                }
            }
            private void OnBeginReceive(IAsyncResult ar)
            {
                try
                {
                    _Buffer = _UdpClient.EndReceive(ar, ref _IPEndPoint);
                    _ManualResetEvent.Set();
                }
                catch
                {
                }
            }
        }
        #endregion

        #region public class InfoResult
        public class InfoResult
        {
            #region public enum Environments
            public enum Environments
            {
                Unkown,
                Linux,
                Windows,
                Mac
            }
            #endregion
            #region public enum ServerTypes
            public enum ServerTypes
            {
                Unknown,
                Dedicated,
                NonDedicated,
                Proxy
            }
            #endregion

            public string Name;
            public string Map;
            public string Game;
            public string Mission;
            public string Version;
            public short ID;
            public byte Players;
            public byte PlayersMax;
            public byte Bots;
            public Environments Environment;
            public ServerTypes ServerType;
            public bool IsPublic;
            public bool UsesVAC;

            private InfoResult()
            {
            }

            public static InfoResult Parse(byte[] buffer)
            {
                if ((buffer == null) || (buffer.Length < 5))
                    return null;

                if ((buffer[0] != 255) || (buffer[1] != 255) || (buffer[2] != 255) || (buffer[3] != 255) || (buffer[4] != 0x49))
                    return null;

                byte protocolVersion = buffer[5];

                InfoResult instance = new InfoResult();

                string t = System.Text.ASCIIEncoding.ASCII.GetString(buffer);

                int index = 0;
                int position = 6;

                // Name
                index = t.IndexOf((char)0, position);
                if (index == -1)
                    return null;
                instance.Name = t.Substring(position, index - position);

                // Map
                position = index + 1;
                index = t.IndexOf((char)0, position);
                if (index == -1)
                    return null;
                instance.Map = t.Substring(position, index - position);

                // Game
                position = index + 1;
                index = t.IndexOf((char)0, position);
                if (index == -1)
                    return null;
                instance.Game = t.Substring(position, index - position);

                // Mission
                position = index + 1;
                index = t.IndexOf((char)0, position);
                if (index == -1)
                    return null;
                instance.Mission = t.Substring(position, index - position);

                // ID
                instance.ID = BitConverter.ToInt16(buffer, index + 1);

                // Players
                instance.Players = buffer[index + 3];

                // PlayersMax
                instance.PlayersMax = buffer[index + 4];

                // Bots
                instance.Bots= buffer[index + 5];

                // ServerType
                byte serverType = buffer[index + 6];
                if (serverType == 'd')
                    instance.ServerType = ServerTypes.Dedicated;
                else if (serverType == 'l')
                    instance.ServerType = ServerTypes.NonDedicated;
                else if (serverType == 'p')
                    instance.ServerType = ServerTypes.Proxy;
                else
                    instance.ServerType = ServerTypes.Unknown;
                
                // Environment
                byte environment = buffer[index + 7];
                if (environment == 'l')
                    instance.Environment = Environments.Linux;
                else if (environment == 'w')
                    instance.Environment = Environments.Windows;
                else if (environment == 'm')
                    instance.Environment = Environments.Mac;
                else if (environment == 'o')
                    instance.Environment = Environments.Mac;
                else
                    instance.Environment = Environments.Unkown;

                // Visibility
                instance.IsPublic = (buffer[index + 8] == 0);
                
                //VAC
                instance.UsesVAC = (buffer[index + 9] == 1);

                position = index + 10;
                index = t.IndexOf('\0', position);
                if (index == -1)
                    return null;
                instance.Version = t.Substring(position, index - position);

                return instance;
            }
        }
        #endregion
        #region public class PlayerResult
        public class PlayerResult
        {
            public Player[] Players = null;

            public class Player
            {
                public string Name;
                public long Score;
                public float Duration;

                public override string ToString()
                {
                    return Name;// +" - " + Score.ToString() + " (" + Duration.ToString(".00") + "min.)";
                }
            }

            private PlayerResult()
            {
            }

            public static PlayerResult Parse(byte[] buffer)
            {
                if ((buffer == null) || (buffer.Length < 5))
                    return null;

                if ((buffer[0] != 255) || (buffer[1] != 255) || (buffer[2] != 255) || (buffer[3] != 255) || (buffer[4] != 0x44))
                    return null;

                byte pc = buffer[5];

                string t = System.Text.ASCIIEncoding.ASCII.GetString(buffer);

                List<Player> players = new List<Player>();
                int index = 6;
                while ((index < buffer.Length) && (buffer[index] == 0))
                {
                    // Namensende suchen
                    int index2 = t.IndexOf('\0', index + 1);
                    if (index2 == -1)
                        return null;
                    string name = t.Substring(index + 1, index2 - index - 1);
                    //score long
                    int score = BitConverter.ToInt32(buffer, index2+1);
                    //duration float
                    float duration = BitConverter.ToSingle(buffer, index2 + 5) / 60.0f;

                    Player p = new Player();
                    p.Name = name;
                    p.Score = score;
                    p.Duration = duration;
                    players.Add(p);
                    Console.WriteLine(p.ToString());

                    index = index2 + 9;
                }

                if (pc != players.Count)
                    return null;

                // Liste sortieren
                players.Sort(delegate(Player c1, Player c2) { return c2.Score.CompareTo(c1.Score); });

                PlayerResult instance = new PlayerResult();
                instance.Players = players.ToArray();
                return instance;
            }

        }
        #endregion

        private int _Timeout = 2000;
        private IPEndPoint _Address;

        public SteamQuery(IPEndPoint address)
        {
            _Address = address;
        }

        public int Timeout
        {
            get
            {
                return _Timeout;
            }
            set
            {
                _Timeout = value;
            }
        }
        public InfoResult GetInfo()
        {
            try
            {
                using (QueryUdp queryUdp = new QueryUdp())
                {
                    byte[] cmdInfo = { 0xff, 0xff, 0xff, 0xff, 0x54, 0x53, 0x6f, 0x75, 0x72, 0x63, 0x65, 0x20, 0x45, 0x6e, 0x67, 0x69, 0x6e, 0x65, 0x20, 0x51, 0x75, 0x65, 0x72, 0x79, 0x00 };
                    byte[] buffer = queryUdp.Execute(cmdInfo, _Address, _Timeout);
                    return InfoResult.Parse(buffer);
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return null;
            }
        }
        public PlayerResult GetPlayers()
        {
            try
            {
                using (QueryUdp queryUdp = new QueryUdp())
                {
                    // Challenge abrufen
                    byte[] cmdPlayerInitial = { 0xff, 0xff, 0xff, 0xff, 0x55, 0xff, 0xff, 0xff, 0xff };
                    byte[] buffer = queryUdp.Execute(cmdPlayerInitial, _Address, _Timeout);

                    // Player mit Challenge abfragen
                    byte[] cmdPlayerChallenge = new byte[9];
                    cmdPlayerChallenge[0] = 0xff;
                    cmdPlayerChallenge[1] = 0xff;
                    cmdPlayerChallenge[2] = 0xff;
                    cmdPlayerChallenge[3] = 0xff;
                    cmdPlayerChallenge[4] = 0x55;
                    cmdPlayerChallenge[5] = buffer[5];
                    cmdPlayerChallenge[6] = buffer[6];
                    cmdPlayerChallenge[7] = buffer[7];
                    cmdPlayerChallenge[8] = buffer[8];
                    buffer = queryUdp.Execute(cmdPlayerChallenge, _Address, _Timeout);
                    return PlayerResult.Parse(buffer);
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return null;
            }
        }
    }
}
