using System;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM.Service
{
    
    public class GameServerProcess: IDisposable
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        private object _SyncObject = new object();

        private ServerStates _Status = ServerStates.Stopped;
        private Process _GameServerProcess;
        private GameServerXml _Configuration;
        private string[] _AddonsAvailable;
        private string[] _AddonsEnabled;

        public GameServerProcess(GameServerXml configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException();

            _Configuration = configuration;
            UpdateAddonsAvailable();
        }
        #region IDisposable Member
        ~GameServerProcess()
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
            Stop();
        }

        private void UpdateAddonsAvailable()
        {
            lock (_SyncObject)
            {
                if (_Configuration.GameServerProcess == null)
                    _AddonsAvailable = new string[0];
                else
                {
                    // Verzeichnisliste holen
                    DirectoryInfo[] addOnDirectories = new DirectoryInfo(_Configuration.GameServerProcess.WorkingDirectory).GetDirectories("@*");

                    // Addons überschreiben
                    _AddonsAvailable = new string[addOnDirectories.Length];
                    for (int i = 0; i < addOnDirectories.Length; i++)
                        _AddonsAvailable[i] = addOnDirectories[i].Name;

                    _AddonsEnabled = new string[0];
                }
            }
        }
        private void UpdateAddonsEnabled(string[] addons)
        {
            lock (_SyncObject)
            {
                if ((addons == null) || (addons.Length == 0))
                    _AddonsEnabled = new string[0];
                else
                {
                    List<string> addonsEnabled = new List<string>(addons.Length);
                    foreach (string addon in addons)
                        if (_AddonsAvailable.Contains(addon))
                            addonsEnabled.Add(addon);

                    _AddonsEnabled = addonsEnabled.ToArray();
                }
            }
        }
        private string GetAddonArguments()
        {
            string addonArguments = "";
            foreach (string addon in _AddonsEnabled)
                addonArguments += addon + ";";

            if (addonArguments != "")
                return " -mod=" + addonArguments;
            else
                return "";
        }
        private void OnStartThread(object data)
        {
            bool preProcessSuccessfull = true;
            bool postProcessSuccessfull = true;

            UpdateAddonsEnabled(data as string[]);
            
            #region PreProcess ausführen
            if (_Configuration.PreProcess != null)
            {
                Status = ServerStates.Starting_Prelaunch;

                try
                {
                    // Process erstellen
                    using (Process preProcess = new Process())
                    {
                        preProcess.StartInfo.FileName = Path.Combine(_Configuration.PreProcess.WorkingDirectory, _Configuration.PreProcess.FileName);
                        preProcess.StartInfo.WorkingDirectory = _Configuration.PreProcess.WorkingDirectory;
                        preProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        preProcess.StartInfo.Arguments = _Configuration.PreProcess.Arguments;
                        preProcess.StartInfo.UseShellExecute = false;
                        preProcess.StartInfo.CreateNoWindow = false;

                        // PreProcess starten
                        LOG.Info("Start preprocess: " + preProcess.StartInfo.FileName + " " + preProcess.StartInfo.Arguments);
                        preProcess.Start();

                        // Warten bis der PreProcess beendet wurde
                        while (!preProcess.WaitForExit(500)) { }

                        if (preProcess.ExitCode != 0)
                            throw new ApplicationException("PreProcess return with ExitCode " + preProcess.ExitCode.ToString());

                        LOG.Info("PreProcess finished successfull");
                    }
                }
                catch (Exception ex)
                {
                    preProcessSuccessfull = false;
                    LOG.Warn(ex);
                }
            }
            #endregion

            // GamerServer starten 
            if ((_Configuration.GameServerProcess != null) && ((preProcessSuccessfull) || (!preProcessSuccessfull && _Configuration.ForceGameServerStart)))
            {

                try
                {
                    lock (_SyncObject)
                    {
                        _Status = ServerStates.Starting_Gameserver;

                        // GamerServerProcess erstellen
                        _GameServerProcess = new Process();
                        _GameServerProcess.StartInfo.FileName = Path.Combine(_Configuration.GameServerProcess.WorkingDirectory, _Configuration.GameServerProcess.FileName);
                        _GameServerProcess.StartInfo.WorkingDirectory = _Configuration.GameServerProcess.WorkingDirectory;
                        _GameServerProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                        _GameServerProcess.StartInfo.Arguments = _Configuration.GameServerProcess.Arguments + GetAddonArguments();
                        _GameServerProcess.StartInfo.UseShellExecute = false;
                        _GameServerProcess.StartInfo.CreateNoWindow = false;
                    }

                    // GamerServerProcess starten
                    LOG.Info("Start gameserver: " + _GameServerProcess.StartInfo.FileName + " " + _GameServerProcess.StartInfo.Arguments);
                    _GameServerProcess.Start();

                    #region Den initialen Titel der Serverkonsole auslesen.
                    string initialTitle = "";
                    while (initialTitle == "")
                    {
                        _GameServerProcess.Refresh();
                        initialTitle = _GameServerProcess.MainWindowTitle;
                        Thread.Sleep(500);
                    }
                    #endregion

                    #region Warten bis sich der Titel der Serverkonsole geändert hat.
                    while (_GameServerProcess.MainWindowTitle == initialTitle)
                    {
                        Thread.Sleep(500);
                        _GameServerProcess.Refresh();
                    }
                    LOG.Info("Started gameserver");
                    #endregion

                    #region PostProcess ausführen
                    // PostProcess ausführen
                    try
                    {
                        if (_Configuration.PostProcess != null)
                        {
                            Status = ServerStates.Starting_Postlaunch;

                            using (Process postProcess = new Process())
                            {
                                postProcess.StartInfo.FileName = Path.Combine(_Configuration.PostProcess.WorkingDirectory, _Configuration.PostProcess.FileName);
                                postProcess.StartInfo.WorkingDirectory = _Configuration.PostProcess.WorkingDirectory;
                                postProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                                postProcess.StartInfo.Arguments = _Configuration.PostProcess.Arguments;
                                postProcess.StartInfo.UseShellExecute = false;
                                postProcess.StartInfo.CreateNoWindow = false;

                                // PreProcess starten
                                LOG.Info("Start postprocess: " + postProcess.StartInfo.FileName + " " + postProcess.StartInfo.Arguments);
                                postProcess.Start();

                                // Warten bis der PreProcess beendet wurde
                                while (!postProcess.WaitForExit(500)) { }

                                if (postProcess.ExitCode != 0)
                                    throw new ApplicationException("PostProcess return with ExitCode " + postProcess.ExitCode.ToString());

                                LOG.Info("PreProcess finished successfull");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        postProcessSuccessfull = false;
                        LOG.Warn(ex);
                    }
                    #endregion

                    // Status aktualisieren
                    if (!postProcessSuccessfull || !postProcessSuccessfull)
                        Status = ServerStates.Started_WithErrors;
                    else
                        Status = ServerStates.Started;

                    // GamerServerProcess überwachen
                    while (!_GameServerProcess.WaitForExit(500)) { }
                }
                catch (InvalidOperationException)
                {
                    LOG.Warn("Unable to start process");
                }
                finally
                {
                    lock (_SyncObject)
                    {
                        _Status = ServerStates.Stopped;
                        if (_GameServerProcess != null)
                        {
                            _GameServerProcess.Dispose();
                            _GameServerProcess = null;
                        }
                    }
                }
            }
        }

        public string GUID
        {
            get
            {
                return _Configuration.GUID;
            }
        }
        public ServerStates Status
        {
            get
            {
                lock (_SyncObject)
                {
                    return _Status;
                }
            }
            set
            {
                lock (_SyncObject)
                {
                    _Status = value;
                }
            }
        }
        public GameServerDetails Details
        {
            get
            {
                lock (_SyncObject)
                {
                    GameServerDetails gameServerDetails = new GameServerDetails();
                    gameServerDetails.Status = _Status;
                    gameServerDetails.Addons = new GameServerDetails.AddonInfo[_AddonsAvailable.Length];
                    for (int i = 0; i < _AddonsAvailable.Length; i++)
                    {
                        gameServerDetails.Addons[i] = new GameServerDetails.AddonInfo();
                        gameServerDetails.Addons[i].Name = _AddonsAvailable[i];
                        gameServerDetails.Addons[i].Enabled = _AddonsEnabled.Contains(_AddonsAvailable[i]);
                    }
                    return gameServerDetails;
                }
            }
        }
        public MissionResults MissionUpload(bool overwrite, string pboName, System.IO.Stream requestStream)
        {
            try
            {
                if (!pboName.EndsWith(".pbo"))
                    throw new ApplicationException("pboname without pbo extension");
                if (pboName.Contains("\\") || pboName.Contains(".."))
                    throw new ApplicationException("pboname contains invalid characters");

                if (_Configuration.GameServerProcess == null)
                    return MissionResults.ErrorNoMissionFolder;

                if (string.IsNullOrWhiteSpace(_Configuration.GameServerProcess.WorkingDirectory))
                    return MissionResults.ErrorNoMissionFolder;

                if (!Directory.Exists(_Configuration.GameServerProcess.WorkingDirectory))
                    return MissionResults.ErrorNoMissionFolder;

                string mpmissionsDirectory = Path.Combine(_Configuration.GameServerProcess.WorkingDirectory, "mpmissions");
                if (!Directory.Exists(mpmissionsDirectory))
                    return MissionResults.ErrorNoMissionFolder;

                string filename = Path.Combine(mpmissionsDirectory, pboName);
                if ((!overwrite) && (File.Exists(filename)))
                    return MissionResults.ErrorFileExists;

                if ((overwrite) && (File.Exists(filename)) && (Status != ServerStates.Stopped))
                    return MissionResults.ErrorFileExistsServerOnline;

                // Datei runterladen
                using (System.IO.Compression.GZipStream decompressedStream = new System.IO.Compression.GZipStream(requestStream, System.IO.Compression.CompressionMode.Decompress))
                {
                    using (System.IO.FileStream fileStream = System.IO.File.Create(filename))
                    {
                        decompressedStream.CopyTo(fileStream);
                    }
                }

                return MissionResults.OK;
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                return MissionResults.ErrorUnknown;
            }
        }
      
        public bool Start(string[] addons)
        {
            if (_Disposed)
                return false;

            lock (_SyncObject)
            {
                if (_Status != ServerStates.Stopped)
                    return false;

                // Configuration überprüfen
                if (_Configuration.PreProcess != null)
                {
                    if (!File.Exists(_Configuration.PreProcess.FileName))
                    {
                        LOG.Warn("PreProcess.FileName existiert nicht.");
                        return false;
                    }
                    if (!Directory.Exists(_Configuration.PreProcess.WorkingDirectory))
                    {
                        LOG.Warn("PreProcess.WorkingDirectory existiert nicht.");
                        return false;
                    }
                }
                if (_Configuration.GameServerProcess != null)
                {
                    if (!File.Exists(_Configuration.GameServerProcess.FileName))
                    {
                        LOG.Warn("GamerServerProcess.FileName existiert nicht.");
                        return false;
                    }
                    if (!Directory.Exists(_Configuration.GameServerProcess.WorkingDirectory))
                    {
                        LOG.Warn("GamerServerProcess.WorkingDirectory existiert nicht.");
                        return false;
                    }
                }
                if (_Configuration.PostProcess != null)
                {
                    if (!File.Exists(_Configuration.PostProcess.FileName))
                    {
                        LOG.Warn("PostProcess.FileName existiert nicht.");
                        return false;
                    }
                    if (!Directory.Exists(_Configuration.PostProcess.WorkingDirectory))
                    {
                        LOG.Warn("PostProcess.WorkingDirectory existiert nicht.");
                        return false;
                    }
                }
                
                _Status = ServerStates.Starting;
                Thread thread = new Thread(new ParameterizedThreadStart(OnStartThread));
                thread.Name = "OnStartThread: " + _Configuration.GUID;
                thread.Start(addons);

                return true;
            }
        }
        public bool Stop()
        {
            if (_Disposed)
                return false;

            lock (_SyncObject)
            {
                if ((_Status == ServerStates.Started) || (_Status == ServerStates.Started_WithErrors))
                {
                    _Status = ServerStates.Stopping;
                    _GameServerProcess.CloseMainWindow();
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            if (_Configuration != null)
                return _Configuration.Description;
            else
                return base.ToString();
        }
    }
}