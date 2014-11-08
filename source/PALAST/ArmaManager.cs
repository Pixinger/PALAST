using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;


namespace PALAST
{
    public class ArmaManager
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        private string _Arma3Exe = null;

        public ArmaManager()
        {
            try
            {
                string installLocation = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 107410", "InstallLocation", null) as string;
                if (!string.IsNullOrWhiteSpace(installLocation))
                {
                    LOG.Info("InstallLocation: " + installLocation);
                    string exe = System.IO.Path.Combine(installLocation, "arma3.exe");
                    if (System.IO.File.Exists(exe))
                        _Arma3Exe = exe;
                    else
                        LOG.Error("Arma3 InstallLocation not found on the harddisc");
                }
                else
                    LOG.Error("Arma3 InstallLocation not in the registry");
            }
            catch
            {
                _Arma3Exe = null;
            }
        }

        public string Arma3Exe
        {
            get
            {
                return _Arma3Exe;
            }
        }
    }
}
