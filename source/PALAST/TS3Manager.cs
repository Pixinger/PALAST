using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Security.Principal;

namespace PALAST
{
    public class TS3Manager
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        #region public enum ConfigLocations: int
        public enum ConfigLocations : int
        {
            Unknown,
            OwnFiles,
            InstallationFolder,
        }
        #endregion
        #region public enum InstallModes : int
        public enum InstallModes : int
        {
            Unknown,
            AllUsers,
            CurrentUser,
        }
        #endregion

        private bool _Successfull = false;
        private string _PluginDirectory;
        private InstallModes _InstallMode = InstallModes.Unknown;
        private ConfigLocations _ConfigLocation = ConfigLocations.Unknown;
        private string _InstallLocation = null;

        public TS3Manager()
        {
            /* 
             * Variante A:
             * HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client
             * - InstallLocation : C:\Users\SST\AppData\Local\TeamSpeak 3 Client             *
             * HKEY_CURRENT_USER\Software\TeamSpeak 3 Client
             * - (Standard) : path folder
             * - ConfigLocation : 0
             * - InstallMode : CurrentUser
             * 
             * Variante B:
             * HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client
             * - InstallLocation : C:\Users\SST\AppData\Local\TeamSpeak 3 Client
             * HKEY_CURRENT_USER\Software\TeamSpeak 3 Client
             * - ConfigLocation : 1
             * - InstallMode : CurrentUser
             * 
             * Variante C:
             * HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client
             * - InstallLocation : C:\Users\SST\AppData\Local\TeamSpeak 3 Client
             * HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client
             * - ConfigLocation : 0
             * - InstallMode : AllUsers
             * 
             * Variante D:
             * HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client
             * - InstallLocation : C:\Users\SST\AppData\Local\TeamSpeak 3 Client
             * HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client
             * - ConfigLocation : 1
             * - InstallMode : AllUsers
             * 
             */

            try
            {
                // InstallMode bestimmen
                #region HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\InstallMode lesen
                string installModeAllUsers = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client", "InstallMode", null) as string;
                if (!string.IsNullOrWhiteSpace(installModeAllUsers))
                {
                    LOG.Info(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\InstallMode = " + installModeAllUsers);
                }
                else
                {
                    LOG.Info(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\InstallMode not found");
                    installModeAllUsers = null;
                }
                #endregion

                #region HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\InstallMode lesen
                string installModeCurrentUser = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client", "InstallMode", null) as string;
                if (!string.IsNullOrWhiteSpace(installModeCurrentUser))
                {
                    LOG.Info(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\InstallMode = " + installModeCurrentUser);
                }
                else
                {
                    LOG.Info(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\InstallMode not found");
                    installModeCurrentUser = null;
                }
                #endregion

                if ((installModeAllUsers != null) && (installModeAllUsers == "AllUsers") && (installModeCurrentUser == null))
                {
                    _InstallMode = InstallModes.AllUsers;

                    // ConfigLocation bestimmen
                    #region HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\ConfigLocation lesen
                    string configLocation = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client", "ConfigLocation", null) as string;
                    if (string.IsNullOrWhiteSpace(configLocation))
                    {
                        LOG.Info(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\ConfigLocation not found");
                        throw new ApplicationException("Die Teamspeak ConfigLocation konnte nicht bestimmt werden.");
                    }

                    LOG.Info(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client\ConfigLocation (0:EigeneDateien/1:Installationsordner) = " + configLocation);

                    if (configLocation == "0")
                        _ConfigLocation = ConfigLocations.OwnFiles;
                    else if (configLocation == "1")
                        _ConfigLocation = ConfigLocations.InstallationFolder;
                    else
                        throw new ApplicationException("ConfigLocation ist weder 0 noch 1.");
                    #endregion

                    // InstallLocation bestimmen
                    #region HKEY_LOCAL_MACHINE/SOFTWARE/Microsoft/Windows/CurrentVersion/Uninstall/TeamSpeak 3 Client/InstallLocation lesen
                    string installLocation = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client", "InstallLocation", null) as string;
                    if (string.IsNullOrWhiteSpace(installLocation))
                        throw new ApplicationException("Die Teamspeak InstallLocation konnte nicht bestimmt werden.");

                    LOG.Info(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client\InstallLocation = " + installLocation);

                    if (!System.IO.Directory.Exists(installLocation))
                        throw new ApplicationException("Die InstallLocation konnte bestimmt werden, es existiert aber an dieser Stelle kein Verzeichnis.");

                    _InstallLocation = installLocation;
                    #endregion
                }
                else if ((installModeAllUsers == null) && (installModeCurrentUser != null) && (installModeCurrentUser == "CurrentUser"))
                {
                    _InstallMode = InstallModes.CurrentUser;

                    // ConfigLocation bestimmen
                    #region HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\ConfigLocation lesen
                    string result = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client", "ConfigLocation", null) as string;
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        LOG.Info(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\ConfigLocation not found");
                        throw new ApplicationException("Die Teamspeak ConfigLocation konnte nicht bestimmt werden.");
                    }

                    LOG.Info(@"HKEY_CURRENT_USER\SOFTWARE\TeamSpeak 3 Client\ConfigLocation (0:EigeneDateien/1:Installationsordner) = " + result);

                    if (result == "0")
                        _ConfigLocation = ConfigLocations.OwnFiles;
                    else if (result == "1")
                        _ConfigLocation = ConfigLocations.InstallationFolder;
                    else
                        throw new ApplicationException("ConfigLocation ist weder 0 noch 1.");
                    #endregion

                    // InstallLocation bestimmen
                    #region HKEY_CURRENT_USER/SOFTWARE/Microsoft/Windows/CurrentVersion/Uninstall/TeamSpeak 3 Client/InstallLocation lesen
                    string installLocation = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client", "InstallLocation", null) as string;
                    if (string.IsNullOrWhiteSpace(installLocation))
                        throw new ApplicationException("Die Teamspeak InstallLocation konnte nicht bestimmt werden.");

                    LOG.Info(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client\InstallLocation = " + installLocation);

                    if (!System.IO.Directory.Exists(installLocation))
                        throw new ApplicationException("Die InstallLocation konnte bestimmt werden, es existiert aber an dieser Stelle kein Verzeichnis.");

                    _InstallLocation = installLocation;
                    #endregion
                }
                else
                    throw new ApplicationException("Der Teamspeak Installmode konnte nicht, oder nicht eindeutig bestimmt werden.");


                string pluginDirectory = System.IO.Path.Combine(_InstallLocation, "Plugins");
                if (!System.IO.Directory.Exists(pluginDirectory))
                    throw new ApplicationException("Das Plugin Verzeichnis konnte nicht bestimmt werden");

                _PluginDirectory = pluginDirectory;
            }
            catch (ApplicationException ex)
            {
                LOG.Info(ex.Message);
                _Successfull = false;
                _InstallLocation = null;
                _InstallMode = InstallModes.Unknown;
                _ConfigLocation = ConfigLocations.Unknown;
            }

            _Successfull = true;

            LOG.Info("_Successfull: {0}", _Successfull);
            LOG.Info("_InstallMode: {0}", _InstallMode);
            LOG.Info("_ConfigLocation: {0}", _ConfigLocation);
            LOG.Info("_InstallLocation: {0}", _InstallLocation);
            LOG.Info("_PluginDirectory: {0}", _PluginDirectory);
        }

        public bool Successfull
        {
            get
            {
                return _Successfull;
            }
        }
        public string PluginDirectory
        {
            get
            {
                return _PluginDirectory;
            }
        }
        public string InstallLocation
        {
            get
            {
                return _InstallLocation;
            }
        }
        public InstallModes InstallMode
        {
            get
            {
                return _InstallMode;
            }
        }
        public ConfigLocations ConfigLocation
        {
            get
            {
                return _ConfigLocation;
            }
        }
        public bool IsRunning
        {
            get
            {
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName("ts3client_win64");
                if (processes.Length > 0)
                    return true;

                processes = System.Diagnostics.Process.GetProcessesByName("ts3client_win32");
                if (processes.Length > 0)
                    return true;

                processes = System.Diagnostics.Process.GetProcessesByName("ts3client");
                if (processes.Length > 0)
                    return true;

                return false;
            }
        }
        public bool IsPluginDirectoryWriteable
        {
            get
            {
                bool isElevated;
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                return isElevated;
            }
        }
    }
}
