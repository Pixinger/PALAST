using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PALAST
{
    public partial class FormMain : Form
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion

        private bool _BlockEventHandler = true;
        private Configuration _Configuration = Configuration.Load();

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
                    }
                    catch (Exception ex)
                    {
                        LOG.Error(ex);
                    }
                    throw new ApplicationException("'/saveversion:' found. App is now closing.");
                }
                #endregion

                #region /updated
                if (args[1].StartsWith("/updated"))
                {
                    try
                    {
                        string filename = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PALAST", "setupPALAST.exe");
                        if (File.Exists(filename))
                            File.Delete(filename);
                    }
                    catch (Exception ex)
                    {
                        LOG.Error(ex);
                    }

                    MessageBox.Show("Update erfolgreich");
                }
                #endregion
            }

            Text = Text + " - " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!IsArmaFolderValid)
            {
                ArmaManager armaManager = new ArmaManager();
                if (armaManager.Arma3Exe != null)
                    _Configuration.Arma3Exe = armaManager.Arma3Exe;

                MessageBox.Show("Bitte überprüfen Sie die korrekte Angabe des Arma-Verzeichnisses (arma3.exe).\nEine falsche Angabe kann sonst später zu Datenverlust führen.");

                if (!SettingsDialog.ExecuteDialog(_Configuration))
                    Close();
            }

            RefreshMenu();
            RefreshNames();

            if ((_Configuration != null) && (_Configuration.CheckForUpdates))
                HttpManager.Download_Version("https://raw.githubusercontent.com/Pixinger/PALAST/master/_releases/latestVersion.xml", new HttpManager.VersionEventHandler(ehPalastVersionDownloaded));
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _Configuration.Save();
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

        private Configuration.Preset SelectedPreset
        {
            get
            {
                return lstPreset.SelectedItem as Configuration.Preset;
            }
        }
        private void RefreshNames()
        {
            cmbName.Items.Clear();

            string armaOtherProfilesFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Arma 3 - Other Profiles");
            string[] profileFolders = System.IO.Directory.GetDirectories(armaOtherProfilesFolder);
            foreach (string profileFolder in profileFolders)
                cmbName.Items.Add(profileFolder.Remove(0, armaOtherProfilesFolder.Length + 1));
        }
        private void RefreshMenu()
        {
            lstPreset.Items.Clear();
            if (_Configuration.Presets != null)
                foreach (Configuration.Preset cfgPreset in _Configuration.Presets)
                {
                    lstPreset.Items.Add(cfgPreset);
                    if (cfgPreset.Name == _Configuration.SelectedPreset)
                        lstPreset.SelectedIndex = lstPreset.Items.Count - 1;
                }

            RefreshPreset();
        }
        private void RefreshPreset()
        {
            Configuration.Preset preset = SelectedPreset;

            // Wenn nichts gewählt wurde, versuchen das erste zu wählen.
            if ((preset == null) && (_Configuration.Presets != null) && (_Configuration.Presets.Length > 0))
            {
                preset = _Configuration.Presets[0];
                _Configuration.SelectedPreset = preset.ToString();
                lstPreset.SelectedIndex = 0;
            }

            if (preset != null)
            {
                _BlockEventHandler = true;

                chbNoSpalsh.Checked = preset.ParamNoSplash;
                chbWorldEmpty.Checked = preset.ParamWorldEmpty;
                chbSkipIntro.Checked = preset.ParamSkipIntro;

                numMaxMem.Enabled = (preset.ParamMaxMem != -1);
                numMaxMem.Value = numMaxMem.Enabled ? preset.ParamMaxMem : numMaxMem.Minimum;
                chbMaxMem.Checked = numMaxMem.Enabled;
                numMaxVRAM.Enabled = (preset.ParamMaxVRam != -1);
                numMaxVRAM.Value = numMaxVRAM.Enabled ? preset.ParamMaxVRam : numMaxVRAM.Minimum;
                chbMaxVRAM.Checked = numMaxVRAM.Enabled;
                chbWinXP.Checked = preset.ParamWinXP;
                chbNoCB.Checked = preset.ParamNoCB;
                cmbCpuCount.Enabled = preset.ParamCpuCount != -1;
                cmbCpuCount.Text = cmbCpuCount.Enabled ? preset.ParamCpuCount.ToString() : "";
                chbCpuCount.Checked = cmbCpuCount.Enabled;
                cmbExThreads.Enabled = preset.ParamExThreads != -1;
                cmbExThreads.Text = cmbExThreads.Enabled ? preset.ParamExThreads.ToString() : "";
                chbExThreads.Checked = preset.ParamExThreads != -1;
                chbNoLogs.Checked = preset.ParamNoLogs;

                cmbName.Enabled = preset.ParamName != "";
                cmbName.Text = cmbName.Enabled ? preset.ParamName : "";
                chbName.Checked = cmbName.Enabled;

                chbNoPause.Checked = preset.ParamNoPause;
                chbShowScriptErrors.Checked = preset.ParamShowScriptErrors;
                chbNoFilePatching.Checked = preset.ParamNoFilePatching;
                chbCheckSignatures.Checked = preset.ParamCheckSignatures;

                txtPort.Text = preset.ParamPort;
                txtServer.Text = preset.ParamServer;
                txtPasswort.Text = preset.ParamPassword;
                chbAutoConnectEnabled.Checked = preset.AutoConnectEnabled;
                if (chbAutoConnectEnabled.Checked)
                {
                    txtServer.Enabled = true;
                    txtPort.Enabled = true;
                    txtPasswort.Enabled = true;
                }

                txtAdditionalParameter.Text = preset.ParamAdditionalParameters;

                // grpAddons.Enabled = true;
                //grpParameter.Enabled = true;

                _BlockEventHandler = false;
            }
            else
            {
                // grpAddons.Enabled = false;
                //grpParameter.Enabled = false;
            }

            RefreshAddons();
        }
        private void RefreshAddons()
        {
            _BlockEventHandler = true;

            clstAddons.Clear();

            Configuration.Preset preset = SelectedPreset;
            if ((preset != null) && (System.IO.File.Exists(_Configuration.Arma3Exe)))
            {
                string armaFolder = System.IO.Path.GetDirectoryName(_Configuration.Arma3Exe);
                string[] addons = System.IO.Directory.GetDirectories(armaFolder, "@*");
                foreach (string addon in addons)
                {
                    string shortName = addon.Remove(0, armaFolder.Length + 1);
                    bool chk = ((SelectedPreset != null) && (SelectedPreset.SelectedAddons != null) && (SelectedPreset.SelectedAddons.Contains(shortName)));
                    clstAddons.Add(shortName, chk);
                }
            }

            _BlockEventHandler = false;
        }
        private bool IsArmaFolderValid
        {
            get
            {
                if (_Configuration == null)
                    return false;

                if (string.IsNullOrWhiteSpace(_Configuration.Arma3Exe))
                    return false;

                return File.Exists(_Configuration.Arma3Exe);
            }
        }

        private void chbNoSpalsh_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamNoSplash = chbNoSpalsh.Checked;
        }
        private void chbWorldEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamWorldEmpty = chbWorldEmpty.Checked;
        }
        private void chbSkipIntro_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamSkipIntro = chbSkipIntro.Checked;
        }

        private void chbMaxMem_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbMaxMem.Checked)
            {
                numMaxMem.Enabled = true;
                numMaxMem.Value = 3072;
                SelectedPreset.ParamMaxMem = 3072;
            }
            else
            {
                numMaxMem.Enabled = false;
                numMaxMem.Value = 256;
                SelectedPreset.ParamMaxMem = -1;
            }
        }
        private void numMaxMem_ValueChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamMaxMem = (int)numMaxMem.Value;
        }
        private void chbMaxVRAM_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbMaxVRAM.Checked)
            {
                numMaxVRAM.Enabled = true;
                numMaxVRAM.Value = 2047;
                SelectedPreset.ParamMaxVRam = 2047;
            }
            else
            {
                numMaxVRAM.Enabled = false;
                numMaxVRAM.Value = 128;
                SelectedPreset.ParamMaxVRam = -1;
            }
        }
        private void numMaxVRAM_ValueChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamMaxVRam = (int)numMaxVRAM.Value;
        }
        private void chbWinXP_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamWinXP = chbWinXP.Checked;
        }
        private void chbNoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamNoCB = chbNoCB.Checked;
        }
        private void chbCpuCount_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbCpuCount.Checked)
            {
                cmbCpuCount.Enabled = true;
                cmbCpuCount.SelectedIndex = 1;
                SelectedPreset.ParamCpuCount = 2;
            }
            else
            {
                cmbCpuCount.Enabled = false;
                cmbCpuCount.SelectedIndex = -1;
                cmbCpuCount.Text = "";
                SelectedPreset.ParamCpuCount = -1;
            }
        }
        private void cmbCpuCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (cmbCpuCount.SelectedIndex != -1)
                SelectedPreset.ParamCpuCount = Convert.ToInt32(cmbCpuCount.Items[cmbCpuCount.SelectedIndex]);
            else
                SelectedPreset.ParamCpuCount = -1;
        }
        private void chbExThreads_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbExThreads.Checked)
            {
                cmbExThreads.Enabled = true;
                cmbExThreads.SelectedIndex = 4;
                SelectedPreset.ParamExThreads = 7;
            }
            else
            {
                cmbExThreads.Enabled = false;
                cmbExThreads.SelectedIndex = -1;
                cmbExThreads.Text = "";
                SelectedPreset.ParamExThreads = -1;
            }
        }
        private void cmbExThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (cmbExThreads.SelectedIndex != -1)
                SelectedPreset.ParamExThreads = Convert.ToInt32(cmbExThreads.Items[cmbExThreads.SelectedIndex]);
            else
                SelectedPreset.ParamExThreads = -1;
        }
        private void chbNoLogs_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamNoLogs = chbNoLogs.Checked;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbName.Checked)
            {
                cmbName.Enabled = true;
                cmbName.SelectedIndex = 0;
                SelectedPreset.ParamName = cmbName.Items[0].ToString();
            }
            else
            {
                cmbName.Enabled = false;
                cmbName.SelectedIndex = -1;
                cmbName.Text = "";
                SelectedPreset.ParamName = "";
            }
        }
        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (cmbName.SelectedIndex != -1)
                SelectedPreset.ParamName = cmbName.Items[cmbName.SelectedIndex].ToString();
            else
                SelectedPreset.ParamName = "";
        }

        private void chbNoPause_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamNoPause = chbNoPause.Checked;
        }
        private void chbShowScriptErrors_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamShowScriptErrors = chbShowScriptErrors.Checked;
        }
        private void chbNoFilePatching_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamNoFilePatching = chbNoFilePatching.Checked;
        }
        private void chbCheckSignatures_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamCheckSignatures = chbCheckSignatures.Checked;
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamServer = txtServer.Text;
        }
        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamPort = txtPort.Text;
        }
        private void txtPasswort_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamPassword = txtPasswort.Text;
        }
        private void txtAdditionalParameter_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            SelectedPreset.ParamAdditionalParameters = txtAdditionalParameter.Text;
        }
        private void chbAutoConnectEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            if (chbAutoConnectEnabled.Checked)
            {
                MessageBox.Show("Es kann sein, daß diese Parameter in Arma3 nicht funktionieren!");
                SelectedPreset.AutoConnectEnabled = true;
                txtServer.Enabled = true;
                txtPort.Enabled = true;
                txtPasswort.Enabled = true;
            }
            else
            {
                SelectedPreset.AutoConnectEnabled = false;
                txtServer.Enabled = false;
                txtPort.Enabled = false;
                txtPasswort.Enabled = false;
            }
        }

        private void lstPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPreset.SelectedIndex != -1)
            {
                tbtnClonePreset.Enabled = true;
                tbtnDeletePreset.Enabled = true;
                tbtnEditPreset.Enabled = true;
                tbtnLaunch.Enabled = true;
                tbtnUpdateAddons.Enabled = true;

                _Configuration.SelectedPreset = lstPreset.SelectedItem.ToString();

                RefreshPreset();
            }
            else
            {
                tbtnClonePreset.Enabled = false;
                tbtnDeletePreset.Enabled = false;
                tbtnEditPreset.Enabled = false;
                tbtnLaunch.Enabled = false;
                tbtnUpdateAddons.Enabled = false;
            }
        }

        private void clstAddons_CheckedChanged(object sender, EventArgs e)
        {
            if (_BlockEventHandler)
                return;

            List<string> selectedAddons = new List<string>();
            for (int i = 0; i < clstAddons.Count; i++)
            {
                if (clstAddons.GetItemCheckState(i))
                    selectedAddons.Add(clstAddons[i] as string);
            }

            SelectedPreset.SelectedAddons = selectedAddons.ToArray();
        }
        private void clstAddons_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbtnTFAR.Enabled = false;

            string addon = clstAddons.SelectedItem;
            if (addon != null)
            {
                tbtnDeleteAddon.Enabled = true;
                string pluginsSource = Path.Combine(Path.Combine(Path.GetDirectoryName(_Configuration.Arma3Exe), addon), "TeamSpeak 3 Client\\plugins");
                if (Directory.Exists(pluginsSource))
                    tbtnTFAR.Enabled = true;
            }
            else
            {
                tbtnDeleteAddon.Enabled = false;
            }
        }
        private void btnInfoOptions_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
                OptionInfoDialog.ExecuteDialog(button.Tag as string);
        }

        private bool IsNameValid(string name)
        {
            foreach (Configuration.Preset preset in _Configuration.Presets)
                if (preset.Name == name)
                    return false;

            return true;
        }
        private void tbtnAddPreset_Click(object sender, EventArgs e)
        {
            string name = RenamePresetDialog.ExecuteDialog("new");
            if (name != null)
            {
                if (!IsNameValid(name))
                    MessageBox.Show("Invalid name");
                else
                {
                    Configuration.Preset preset = new Configuration.Preset();
                    preset.Name = name;
                    List<Configuration.Preset> list = (_Configuration.Presets != null) ? new List<Configuration.Preset>(_Configuration.Presets) : new List<Configuration.Preset>();
                    list.Add(preset);
                    _Configuration.Presets = list.ToArray();
                    RefreshMenu();
                    lstPreset.SelectedIndex = lstPreset.Items.Count - 1;
                }
            }

        }
        private void tbtnEditPreset_Click(object sender, EventArgs e)
        {
            Configuration.Preset preset = lstPreset.SelectedItem as Configuration.Preset;
            string name = RenamePresetDialog.ExecuteDialog(preset.Name);
            if (name != null)
            {
                preset.Name = name;
                int index = lstPreset.SelectedIndex;
                RefreshMenu();
                lstPreset.SelectedIndex = index;

            }
        }
        private void tbtnClonePreset_Click(object sender, EventArgs e)
        {
            Configuration.Preset preset = (lstPreset.SelectedItem as Configuration.Preset).Clone();
            string newName = preset.Name + " (clone)";
            while (!IsNameValid(newName)) { newName += " (clone)"; }
            preset.Name = newName;

            List<Configuration.Preset> list = new List<Configuration.Preset>(_Configuration.Presets);
            list.Add(preset);
            _Configuration.Presets = list.ToArray();
            RefreshMenu();
            lstPreset.SelectedIndex = lstPreset.Items.Count - 1;
        }
        private void tbtnDeletePreset_Click(object sender, EventArgs e)
        {
            List<Configuration.Preset> list = new List<Configuration.Preset>(_Configuration.Presets);
            foreach (Configuration.Preset preset in lstPreset.SelectedItems)
                list.Remove(preset);
            _Configuration.Presets = list.ToArray();
            RefreshMenu();
            lstPreset.SelectedIndex = lstPreset.Items.Count - 1;
        }
        private void tbtnSettings_Click(object sender, EventArgs e)
        {
            SettingsDialog.ExecuteDialog(_Configuration);

            RefreshMenu();
        }
        private void tbtnInfo_Click(object sender, EventArgs e)
        {
            AboutDialog.ExecuteDialog();
        }

        private void tbtnLaunch_Click(object sender, EventArgs e)
        {
            Configuration.Preset preset = SelectedPreset;
            if (preset == null)
                return;

            string args = "";

            if (preset.ParamNoSplash)
                args += " -noSplash";
            if (preset.ParamWorldEmpty)
                args += " -world=empty";
            if (preset.ParamSkipIntro)
                args += " -skipIntro";
            if (preset.ParamMaxMem != -1)
                args += string.Format(" -maxMem={0}", preset.ParamMaxMem);
            if (preset.ParamMaxVRam != -1)
                args += string.Format(" -maxVRAM={0}", preset.ParamMaxVRam);
            if (preset.ParamWinXP)
                args += " -winXP";
            if (preset.ParamNoCB)
                args += " -noCB";
            if (preset.ParamCpuCount != -1)
                args += string.Format(" -cpuCount={0}", preset.ParamCpuCount);
            if (preset.ParamExThreads != -1)
                args += string.Format(" -exThreads={0}", preset.ParamExThreads);
            if (preset.ParamNoLogs)
                args += " -noLogs";
            if ((preset.ParamName != null) && (preset.ParamName != ""))
                args += string.Format(" -name={0}", preset.ParamName);
            if (preset.ParamNoPause)
                args += " -noPause";
            if (preset.ParamShowScriptErrors)
                args += " -showScriptErrors";
            if (preset.ParamNoFilePatching)
                args += " -noFilePatching";
            if (preset.ParamCheckSignatures)
                args += " -checkSignatures";

            if (preset.AutoConnectEnabled)
            {
                if ((preset.ParamServer != null) && (preset.ParamServer != "") && (preset.ParamPort != null) && (preset.ParamPort != ""))
                {
                    args += string.Format(" -connect={0}", preset.ParamServer);
                    args += string.Format(" -port={0}", preset.ParamPort);
                    if ((preset.ParamPassword != null) && (preset.ParamPassword != ""))
                        args += string.Format(" -password={0}", preset.ParamPassword);
                }
            }


            if ((preset != null) && (preset.SelectedAddons != null) && (preset.SelectedAddons.Length > 0))
            {
                string mods = " -mod=";
                foreach (string addon in preset.SelectedAddons)
                    mods += addon + ";";

                mods = mods.Remove(mods.Length - 1, 1);
                args += mods;
            }


            LOG.Info("Starting Arma with args: {0}", args);
            LOG.Info("Using Arma3.exe: {0}", _Configuration.Arma3Exe);

            if (System.IO.File.Exists(_Configuration.Arma3Exe))
            {
#if(DEBUG)
                MessageBox.Show(args);
#else
                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    process.StartInfo.FileName = System.IO.Path.GetFileName(_Configuration.Arma3Exe);
                    process.StartInfo.WorkingDirectory = System.IO.Path.GetDirectoryName(_Configuration.Arma3Exe);
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    process.StartInfo.Arguments = args;
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.CreateNoWindow = false;
                    process.Start();
                }
#endif
            }
            else
            {
                MessageBox.Show("Arma3.exe not found. Please configure the correct path in the settings.\n\nCommandline arguments:\n" + args);
            }

            if (_Configuration.CloseAfterStart)
                Close();
        }
        private void tbtnUpdateAddons_Click(object sender, EventArgs e)
        {
            if (!IsArmaFolderValid)
                return;

            AddonSyncDialog.ExecuteDialog(System.IO.Path.GetDirectoryName(_Configuration.Arma3Exe), SelectedPreset);

            RefreshMenu();
        }
        private void tbtnDeleteAddon_Click(object sender, EventArgs e)
        {
            if (!IsArmaFolderValid)
                return;

            if (clstAddons.SelectedItem != null)
            {
                string addon = clstAddons.SelectedItem as string;
                if (MessageBox.Show("Wollen Sie das gewählte Addon '" + addon + "' wirklich aus dem ArmA-Verzeichnis löschen.", "Achtung!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    string folder = Path.Combine(Path.GetDirectoryName(_Configuration.Arma3Exe), addon);
                    if (MessageBox.Show("Ich werde nun folgendes Verzeichnis löschen:\n\n" + folder + "!", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        Directory.Delete(folder, true);
                        RefreshAddons();
                    }
                }
            }
        }
        private void tbtnTFAR_Click(object sender, EventArgs e)
        {
            if (!IsArmaFolderValid)
                return;

            string addon = clstAddons.SelectedItem as string;
            if (addon != null)
            {
                try
                {
                    string pluginsSource = Path.Combine(Path.Combine(Path.GetDirectoryName(_Configuration.Arma3Exe), addon), "TeamSpeak 3 Client\\plugins");
                    if (Directory.Exists(pluginsSource))
                    {
                        TS3Manager ts3Manager = new TS3Manager();
                        if (ts3Manager.Successfull)
                        {
                            if (ts3Manager.IsPluginDirectoryWriteable)
                            {
                                if (!ts3Manager.IsRunning)
                                {
                                    // Es kann sein, dass das Plugin Verzeichnis noch nicht existiert
                                    if (!Directory.Exists(ts3Manager.PluginDirectory))
                                        Directory.CreateDirectory(ts3Manager.PluginDirectory);

                                    // Kopieren
                                    DirectoryInfo source = new DirectoryInfo(pluginsSource);
                                    DirectoryInfo target = new DirectoryInfo(ts3Manager.PluginDirectory);
                                    FileTools.CopyDirectoryRecursively(source, target);

                                    //Fertig
                                    MessageBox.Show("Die Installation war erfolgreich.");
                                }
                                else
                                    MessageBox.Show("Teamspeak scheint momentan zu laufen.\nBitte beenden Sie das Programm um die TFAR Plugins installieren zu können.");
                            }
                            else
                                MessageBox.Show("Um TFAR installieren zu können, muss PALAST mit Administratorrechten gestartet werden.");
                        }
                        else
                            MessageBox.Show("TS3 konnte nicht zuverlässig erkannt werden. Das Setup kann deshalb nicht ausgeführt werden.");
                    }
                }
                catch (Exception ex)
                {
                    LOG.Error(ex);
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}