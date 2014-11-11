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

        private bool _Successfull = false;
        private string _PluginDirectory;
        private string _InstallLocation = null;

        public TS3Manager()
        {
            #region Infos
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
            #endregion

            try
            {
                // InstallLocation suchen
                string allUsers = GetKey(RegistryHive.LocalMachine, @"SOFTWARE\TeamSpeak 3 Client", "");
                string currentUser = GetKey(RegistryHive.LocalMachine, @"SOFTWARE\TeamSpeak 3 Client", "");

                if ((allUsers == null) && (currentUser != null))
                {
                    if (!System.IO.Directory.Exists(currentUser))
                        throw new ApplicationException("Die InstallLocation konnte bestimmt werden, es existiert aber an dieser Stelle kein Verzeichnis.");

                    _InstallLocation = currentUser;
                }
                else if ((allUsers != null) && (currentUser == null))
                {
                    if (!System.IO.Directory.Exists(currentUser))
                        throw new ApplicationException("Die InstallLocation konnte bestimmt werden, es existiert aber an dieser Stelle kein Verzeichnis.");

                    _InstallLocation = currentUser;
                }
                else if ((allUsers != null) && (currentUser != null))
                    throw new ApplicationException("Der Teamspeak Installmode konnte nicht eindeutig bestimmt werden.");
                else
                    throw new ApplicationException("Der Teamspeak Installmode konnte nicht bestimmt werden.");


                string pluginDirectory = System.IO.Path.Combine(_InstallLocation, "Plugins");
                if (!System.IO.Directory.Exists(pluginDirectory))
                    throw new ApplicationException("Das Plugin Verzeichnis existiert nicht.");

                _PluginDirectory = pluginDirectory;
                _Successfull = true;
            }
            catch (ApplicationException ex)
            {
                LOG.Info(ex.Message);
                _Successfull = false;
                _InstallLocation = null;
            }

            LOG.Info("_Successfull: {0}", _Successfull);
            LOG.Info("_InstallLocation: {0}", _InstallLocation);
            LOG.Info("_PluginDirectory: {0}", _PluginDirectory);
        }

        private string GetKey(RegistryHive registryHive, RegistryView registryView, string subKeyName, string value)
        {
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(registryHive, registryView))
            {
                if (baseKey == null)
                {
                    LOG.Info("{0}\\{1}\\{2} ({3}): baseKey is null", registryHive, subKeyName, value, registryView);
                    return null;
                }

                using (RegistryKey subKey = baseKey.OpenSubKey(subKeyName))
                {
                    if (subKey == null)
                    {
                        LOG.Info("{0}\\{1}\\{2} ({3}): subKey is null", registryHive, subKeyName, value, registryView);
                        return null;
                    }

                    string result = subKey.GetValue(value) as string;
                    if (result != null)
                        LOG.Info("{0}\\{1}\\{2} ({3}): {4}", registryHive, subKeyName, value, registryView, result);
                    else
                        LOG.Info("{0}\\{1}\\{2} ({3}): null", registryHive, subKeyName, value, registryView);

                    return result;
                }
            }
        }
        private string GetKey(RegistryHive registryHive, string subKeyName, string value)
        {
            string result = GetKey(registryHive, RegistryView.Registry32, subKeyName, value);
            if (result != null)
                return result;

            return GetKey(registryHive, RegistryView.Registry64, subKeyName, value);
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
