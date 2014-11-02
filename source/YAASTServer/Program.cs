using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace YAAST
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region NLog konfigurieren (.NET4) Version3.0
            {
                NLog.Config.LoggingConfiguration configuration;
                string applicationName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
                string configFile = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), System.IO.Path.ChangeExtension(applicationName, ".nlog.config"));

                // Suchen: (CurrentDir + applicationName + '.nlog.config')
                if (System.IO.File.Exists(configFile))
                    configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
                else
                {
                    // Suchen: (CurrentDir + '\logs\' + applicationName + '.nlog.config')
                    configFile = System.IO.Path.Combine(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "logs"), System.IO.Path.ChangeExtension(applicationName, ".nlog.config"));
                    if (System.IO.File.Exists(configFile))
                    {
                        configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
                    }
                    else
                    {
                        // Suchen: (CurrentDir + '\logs\NLog.config')
                        configFile = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "logs\\NLog.config");
                        if (System.IO.File.Exists(configFile))
                        {
                            configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
                        }
                        else
                        {
                            // Configuration durch Code:

                            configuration = new NLog.Config.LoggingConfiguration();

                            NLog.Targets.FileTarget fileTarget = new NLog.Targets.FileTarget();
                            configuration.AddTarget("file", fileTarget);
                            fileTarget.Name = "file";
                            fileTarget.FileName = ".\\_log_${processname}.txt";
                            fileTarget.Layout = "[${processname}] [${level}] ${longdate}: ${callsite} ||| ${message} ${Exception}";
                            configuration.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Warn, fileTarget));

#if(DEBUG)
                            NLog.Targets.ColoredConsoleTarget consoleTarget = new NLog.Targets.ColoredConsoleTarget();
                            consoleTarget.Name = "console";
                            consoleTarget.Layout = "[${level}] ${longdate}: ${callsite} ||| ${message} ${Exception}";
                            configuration.AddTarget("console", consoleTarget);
                            configuration.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Trace, consoleTarget));
#endif
                        }
                    }
                }

                NLog.LogManager.Configuration = configuration;
                NLog.LogManager.GetCurrentClassLogger().Info("Process started: {0} LogLevel({1}) LogConfig({2}) CommandLine({3})", applicationName, NLog.LogManager.GlobalThreshold, configFile, Environment.CommandLine);
            }
            #endregion
		

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormServer());
        }
    }
}
