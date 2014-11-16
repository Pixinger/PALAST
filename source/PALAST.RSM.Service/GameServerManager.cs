using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM.Service
{
    public interface IGameServerManager
    {
        ServerStates GetServerState(string serverGuid);
        GameServerDetails GetServerDetails(string serverGuid);
        bool Start(string serverGuid);
        bool Stop(string serverGuid);
    }

    public class GameServerManager : IGameServerManager, IDisposable
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        private ConfigurationXml _Configuration;

        private List<GameServerProcess> _GameServerProcesses = new List<GameServerProcess>();

        public GameServerManager(ConfigurationXml configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException();

            _Configuration = configuration;
            ReloadGameServerProcesses();
        }
        #region IDisposable Member
        ~GameServerManager()
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
            foreach (GameServerProcess gameServerProcess in _GameServerProcesses)
                gameServerProcess.Dispose();
            _GameServerProcesses.Clear();
        }

        private GameServerProcess GetProcess(string gameServerGuid)
        {
            foreach (GameServerProcess gameServerProcess in _GameServerProcesses)
                if (gameServerProcess.GUID == gameServerGuid)
                    return gameServerProcess;
        
            return null;
        }
        private bool ExistsInConfiguration(string gameServerGuid)
        {
            if (_Configuration.GameServers == null)
                return false;

            foreach (GameServerXml g in _Configuration.GameServers)
                if (g.GUID == gameServerGuid)
                    return true;

            return false;
        }
        private bool ExistsInGameServerProcesses(string gameServerGuid)
        {
            if (_GameServerProcesses == null)
                return false;

            for (int i = 0; i < _GameServerProcesses.Count; i++)
                if (_GameServerProcesses[i].GUID == gameServerGuid)
                    return true;

            return false;
        }

        public ServerStates GetServerState(string gameServerGuid)
        {
            if (_Disposed)
                return ServerStates.Unknown;

            GameServerProcess gameServerProcess = GetProcess(gameServerGuid);
            if (gameServerProcess != null)
                return gameServerProcess.Status;
            else
                return ServerStates.Unknown;
        }
        public GameServerDetails GetServerDetails(string gameServerGuid)
        {
            if (_Disposed)
                return null;
            
            GameServerProcess gameServerProcess = GetProcess(gameServerGuid);
            if (gameServerProcess != null)
                return gameServerProcess.Details;
            else
                return null;
        }
        public bool Start(string gameServerGuid)
        {
            if (_Disposed)
                return false;

            GameServerProcess gameServerProcess = GetProcess(gameServerGuid);
            if (gameServerProcess != null)
                return gameServerProcess.Start(null);
            else
                return false;
        }
        public bool Stop(string gameServerGuid)
        {
            if (_Disposed)
                return false;

            GameServerProcess gameServerProcess = GetProcess(gameServerGuid);
            if (gameServerProcess != null)
                return gameServerProcess.Stop();
            else
                return false;
        }

        public void ReloadGameServerProcesses()
        {
            System.Diagnostics.Debug.Assert(_Configuration != null);
            System.Diagnostics.Debug.Assert(_GameServerProcesses != null);
            
            // Erst alle obsoleten entfernen
            int i = 0;
            while (i < _GameServerProcesses.Count)
            {
                if (!ExistsInConfiguration(_GameServerProcesses[i].GUID))
                {
                    LOG.Debug("Removing: " + _GameServerProcesses[i].ToString());
                    _GameServerProcesses[i].Dispose();
                    _GameServerProcesses.RemoveAt(i);
                }
                else
                    i++;
            }

            // Dann alle neuen hinzufügen
            foreach (GameServerXml gameServerXml in _Configuration.GameServers)
                if (!ExistsInGameServerProcesses(gameServerXml.GUID))
                {
                    _GameServerProcesses.Add(new GameServerProcess(gameServerXml));
                    LOG.Debug("Add: " + gameServerXml.Description);
                }
        }
    }
}
