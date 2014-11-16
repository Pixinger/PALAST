using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PALAST.RepoManager
{
    static class Program
    {
        public static int ExitCode = 0;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region NLog konfigurieren PALASTServer
            {
                NLog.Config.LoggingConfiguration configuration;

                string configFile = System.IO.Path.Combine(Environment.CurrentDirectory, "NLog.PALAST.RepoManager.config");
                if (System.IO.File.Exists(configFile))
                    configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
                else
                {
                    NLog.Targets.ColoredConsoleTarget consoleTarget = new NLog.Targets.ColoredConsoleTarget();
                    consoleTarget.Name = "console";
                    consoleTarget.Layout = "[${level}] ${longdate}: ${callsite} ||| ${message} ${Exception}";
                    configuration = new NLog.Config.LoggingConfiguration();
                    configuration.AddTarget("console", consoleTarget);
                    configuration.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Trace, consoleTarget));
                }

                NLog.LogManager.Configuration = configuration;
            }
            #endregion
		
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FormMain());
            }
            catch (ApplicationException)
            {
            }

            Environment.ExitCode = Program.ExitCode;
        }
    }
}
