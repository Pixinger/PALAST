using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PALAST.RSM.Service
{
    public partial class FormMain : Form
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        private ServerHttp _ServerHttp = null;
        private ConfigurationXml _Configuration = null;
        private GameServerManager _GameServerManager = null;

        public FormMain()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();
            if ((args != null) && (args.Length == 2))
            {
                #region /saveversion
                if (args[1].StartsWith("/saveversion:"))
                {
                    try
                    {
                        string filename = args[1].Remove(0, 13);
                        SerializationTools.Save<VersionSerializeable>(filename, VersionSerializeable.FromVersion(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version));
                        _NotifyIcon.Dispose();
                    }
                    catch (Exception ex)
                    {
                        LOG.Error(ex);
                    }
                    throw new ApplicationException("'/saveversion:' found. App is now closing.");
                }
                #endregion
            }
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            Visible = false;
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }
        protected override void OnLoad(EventArgs e)
        {
 	         base.OnLoad(e);
            
            HttpManager.Download_Version("https://raw.githubusercontent.com/Pixinger/PALAST/master/_releases/latestVersion_PALAST_RSM.xml", new HttpManager.VersionEventHandler(ehPalastVersionDownloaded));
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            try
            {
                _Configuration = ConfigurationXml.Load();
                if (_Configuration == null)
                {
                    LOG.Error("Unable to load " + ConfigurationXml.FILENAME + ". Using empty configuration instread");
                    if (MessageBox.Show("Es wurde keine gültige Konfiguation gefunden. Soll stattdessen eine leere verwendet werden?", "Frage", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                    {
                        _Configuration = new ConfigurationXml();
                        _Configuration.Save();
                    }
                }

                if (_Configuration != null)
                {
                    if (_Configuration.Validate())
                    {
                        // GameServerManager erstellen
                        _GameServerManager = new GameServerManager(_Configuration);

                        // Den ServerHttp online stellen
                        Online();
                    }
                    else
                        MessageBox.Show("Die überprüfung der Konfiguration hat Fehler entdeckt. Die Konfiguration kann nicht verwendet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
                MessageBox.Show("Unbekannter Fehler beim laden des Service.\n\n" + ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _ServerHttp = null;
                _Configuration = null;
                _GameServerManager = null;
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Offline();

            if (_ServerHttp != null)
            {
                _ServerHttp.Dispose();
                _ServerHttp = null;
            }

            if (_GameServerManager != null)
            {
                _GameServerManager.Dispose();
                _GameServerManager = null;
            }
        }

        private void ehPalastVersionDownloaded(Version version)
        {
            if (version == null)
                return;

            if (InvokeRequired)
                BeginInvoke(new HttpManager.VersionEventHandler(ehPalastVersionDownloaded), new object[] { version });
            else
            {
                if (version > System.Reflection.Assembly.GetExecutingAssembly().GetName().Version)
                    UpdateNotificationDialog.ExecuteDialog(version, "https://github.com/Pixinger/PALAST/wiki");
            }
        }

        private void Online()
        {
            if (_GameServerManager == null)
                return; // GameServerManager nicht verfügbar.
            if (_Configuration == null)
                return; // Konfiguration kann eigentlich nur null sein, wenn der GameServerManager auch null ist.
            if (_ServerHttp != null)
                return; // ServerHttp ist schon online.

            try
            {
                _ServerHttp = new ServerHttp(_Configuration, _GameServerManager);
                cmenOnline.Checked = true;
            }
            catch(Exception ex)
            {
                LOG.Error(ex);
                _ServerHttp = null;
                cmenOnline.Checked = false;
                MessageBox.Show("Der Http-Server konnte nicht gestartet werden.");
            }
        }
        private void Offline()
        {
            if (_GameServerManager == null)
                return; // GameServerManager nicht verfügbar.
            if (_Configuration == null)
                return; // Konfiguration kann eigentlich nur null sein, wenn der GameServerManager auch null ist.
            if (_ServerHttp == null)
                return; // ServerHttp ist schon offline.

            try
            {
                _ServerHttp.Dispose();
            }
            catch (Exception ex)
            {
                LOG.Error(ex);
            }
            finally
            {
                _ServerHttp = null;
                cmenOnline.Checked = false;
            }
        }  

        private void cmenOnline_Click(object sender, EventArgs e)
        {
            if (cmenOnline.Checked)
                Offline();
            else
                Online();
        }
        private void cmenCloseGameServers_Click(object sender, EventArgs e)
        {

        }
        private void cmenSetup_Click(object sender, EventArgs e)
        {
            if (_Configuration != null)
            {
                SetupDialog.ExecuteDialog(_Configuration);

                if (_Configuration != null)
                    _Configuration.Save();

                if(_GameServerManager != null)
                    _GameServerManager.ReloadGameServerProcesses();
            }
        }
        private void cmenPrefixSetup_Click(object sender, EventArgs e)
        {
            if (_Configuration != null)
            {
                bool online = cmenOnline.Checked;

                Offline();

                IpDialog.ExecuteDialog(_Configuration);

                if (_Configuration != null)
                    _Configuration.Save();

                if (_GameServerManager != null)
                    _GameServerManager.ReloadGameServerProcesses();

                if (online)
                    Online();
            }

        }
        private void cmenClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
