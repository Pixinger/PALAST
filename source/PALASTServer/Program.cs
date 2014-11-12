using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PALAST
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region NLog konfigurieren PALASTServer
            {
                NLog.Config.LoggingConfiguration configuration;
#if(DEBUG)
                NLog.Targets.ColoredConsoleTarget consoleTarget = new NLog.Targets.ColoredConsoleTarget();
                consoleTarget.Name = "console";
                consoleTarget.Layout = "[${level}] ${longdate}: ${callsite} ||| ${message} ${Exception}";
                configuration = new NLog.Config.LoggingConfiguration();
                configuration.AddTarget("console", consoleTarget);
                configuration.LoggingRules.Add(new NLog.Config.LoggingRule("*", NLog.LogLevel.Trace, consoleTarget));
#else
                string configFile = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PALAST", "NLog.PALASTServer.config");
                configuration = new NLog.Config.XmlLoggingConfiguration(configFile);
#endif

                NLog.LogManager.Configuration = configuration;
            }
            #endregion
		
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FormServer());
            }
            catch (ApplicationException)
            {
            }
        }
    }
}
