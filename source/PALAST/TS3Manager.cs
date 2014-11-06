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

        private bool _PluginDirectoryValid;
        private string _PluginDirectory;
        private string _InstallMode;

        public TS3Manager()
        {
            string installMode = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TeamSpeak 3 Client", "InstallMode", null) as string;
            if (!string.IsNullOrWhiteSpace(installMode))
            {
                LOG.Info("InstallMode: " + installMode);
                _InstallMode = installMode;
            }
            else
                LOG.Info("RegistryKey InstallMode not found");

            _PluginDirectoryValid = false;
            string installLocation = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\TeamSpeak 3 Client", "InstallLocation", null) as string;
            if (!string.IsNullOrWhiteSpace(installLocation))
            {
                LOG.Info("InstallLocation: " + installLocation);
                if (System.IO.Directory.Exists(installLocation))
                {
                    _PluginDirectory = System.IO.Path.Combine(installLocation, "Plugins");
                    if (System.IO.Directory.Exists(_PluginDirectory))
                    {
                        if (_InstallMode == "AllUsers")
                            _PluginDirectoryValid = true;
                    }
                    else
                        LOG.Error("PluginDirectory not found");
                }
                else
                    LOG.Error("Directory InstallLocation not found");
            }
            else
                LOG.Info("RegistryKey InstallLocation not found");
        }

        public bool PluginDirectoryValid
        {
            get
            {
                return _PluginDirectoryValid;
            }
        }
        public string PluginDirectory
        {
            get
            {
                return _PluginDirectory;
            }
        }
        public string InstallMode
        {
            get
            {
                return _InstallMode;
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

        public bool IsElevatedRight
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
