using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class FormServer : Form, LogList.ILogWriter
    {
        //string LocalDirectory = @"C:\Program Files (x86)\Steam\SteamApps\common\Arma 3";

        private ProjectXml _ProjectXml;
        private bool _BlockEvents = false;
        private bool _Modified = false;
 
        public FormServer()
        {
            InitializeComponent();

            LogList.SetLogTarget(this);

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
                LoadProject(args[1]);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            string[] args = Environment.GetCommandLineArgs();
            if ((args.Length > 2) && (args[2] == "upload"))
            {
                menRepoUpload.PerformClick();
                Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (Modified)
            {
                DialogResult result = MessageBox.Show("Wollen Sie die Änderungen am Projekt speichern?", "?", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!SaveProject())
                        e.Cancel = true;
                }
                else if (result == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void LoadProject(string filename)
        {
            if (File.Exists(filename))
                LoadProject(ProjectXml.Load(filename));
        }
        private void LoadProject(ProjectXml projectXml)
        {
            _ProjectXml = projectXml;
            
            pnlTop.SuspendLayout();
            _BlockEvents = true;
            
            txtAddonDirectory.Text = "";
            txtFtpAddress.Text = "";
            txtFtpUsername.Text = "";
            txtFtpPassword.Text = "";
            txtLocalRepositoryDirectory.Text = "";
            
            if (_ProjectXml != null)
            {
                _ProjectXml.Validate();

                Text = "YAAST Server - " + Path.GetFileName(_ProjectXml.Filename);
                pnlTop.Enabled = true;
                lstLog.Enabled = true;
                menSave.Enabled = _Modified;
                menSaveAs.Enabled = true;

                txtAddonDirectory.Text = _ProjectXml.AddonDirectory;

                if (_ProjectXml.FtpRepository != null)
                {
                    tabControlMode.SelectedIndex = 0;
                    if (_ProjectXml.FtpRepository.Address.EndsWith("/"))
                        _ProjectXml.FtpRepository.Address = _ProjectXml.FtpRepository.Address.Remove(_ProjectXml.FtpRepository.Address.Length - 1, 1);
                    txtFtpAddress.Text = _ProjectXml.FtpRepository.Address;
                    txtFtpUsername.Text = _ProjectXml.FtpRepository.Username;
                    txtFtpPassword.Text = _ProjectXml.FtpRepository.Password;
                }

                if (_ProjectXml.LocalRepository != null)
                {
                    tabControlMode.SelectedIndex = 1;
                    txtLocalRepositoryDirectory.Text = _ProjectXml.LocalRepository.Directory;
                }
            }
            else
            {
                Text = "YAAST Server";
                pnlTop.Enabled = false;
                lstLog.Enabled = false;
                menSave.Enabled = false;
                menSaveAs.Enabled = false;
            }

            RefreshAddonList();

            _BlockEvents = false;
            pnlTop.ResumeLayout();
        }
        private bool SaveProject()
        {
            if (_ProjectXml == null)
                return true;

            if (_ProjectXml.SaveAsRequired)
                return SaveProjectAs();
            else
            {
                _ProjectXml.Save();
                Modified = false;
                return true;
            }
        }
        private bool SaveProjectAs()
        {
            if (_ProjectXml == null)
                return true;

            string filename = Path.GetFileName(_ProjectXml.Filename);
            if (filename.EndsWith(".yaast.proj"))
                filename = filename.Remove(filename.Length - 11, 11);
            saveDlg.FileName = filename;

            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _ProjectXml.SaveAs(saveDlg.FileName);
                Modified = false;
                Text = "YAAST Server - " + Path.GetFileName(_ProjectXml.Filename);
                return true;
            }
            else
                return false;
        }
        private void SynchronizeRepository(bool uploadData)
        {
            if (_ProjectXml == null)
                return;

            LockGui();

            try
            {
                LogList.Clear();

                // SyncExecutor erstellen
                LogList.Info("Initialize updater");
                SyncServer syncServer = null;
                if (_ProjectXml.FtpRepository != null)
                    syncServer = new SyncServerFtpGz(_ProjectXml.AddonDirectory, _ProjectXml.FtpRepository.Address, _ProjectXml.FtpRepository.Username, _ProjectXml.FtpRepository.Password, _ProjectXml.FtpRepository.Passive, _ProjectXml.FtpRepository.ConnectionLimit, _ProjectXml.SelectedAddons);
                else
                    syncServer = new SyncServerLocalGz(_ProjectXml.AddonDirectory, _ProjectXml.LocalRepository.Directory, _ProjectXml.SelectedAddons);

                LogList.Info("Load repositories");
                syncServer.LoadRepositories();

                LogList.Info("Compare addons");
                SyncBase.CompareResult[] compareResults = syncServer.CompareRepositories(true);
                System.Diagnostics.Debug.Assert(compareResults != null);

                LogList.Info("------------------------------------------------------------------------");
                int modifications = 0;
                for (int i = 0; i < compareResults.Length; i++)
                {
                    modifications += compareResults[i].Count;
                    LogList.Info(compareResults[i] + " - (" + compareResults[i].Count + " modifications)");
                }
                LogList.Info("------------------------------------------------------------------------");
                LogList.Info("== Total modifications: " + modifications + " ==");

                if (uploadData && (modifications > 0))
                {
                    LogList.Info("Synchronize addons");
                    if (!syncServer.Synchronize(compareResults))
                        throw new Exception("Synchronize() failed.");

                    LogList.Info("Update target repository xml");
                    if (!syncServer.UpdateTargetRepositoryXml())
                        throw new Exception("UpdateTargetRepositoryXml() failed.");

                    LogList.Info("------------------------------------------------------------------------");
                    LogList.Info("Operation finished successfully !!!");
                }
            }
            catch (Exception ex)
            {
#if(DEBUG)
                MessageBox.Show(ex.Message + "\n\n---------------------------------\n" + ex.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
            finally
            {
                UnlockGui();
            }
        }
        private void RefreshAddonList()
        {
            clstAddons.Items.Clear();

            if (_ProjectXml == null)
                return;

            if (!Directory.Exists(_ProjectXml.AddonDirectory))
                return;

            DirectoryInfo directoryInfo = new DirectoryInfo(_ProjectXml.AddonDirectory);
            DirectoryInfo[] addons = directoryInfo.GetDirectories("@*");
            if ((addons == null) || (addons.Length == 1))
                return;

            if (_ProjectXml.SelectedAddons == null)
                _ProjectXml.SelectedAddons = new string[0];

            foreach (DirectoryInfo addon in addons)
            {
                clstAddons.Items.Add(addon.Name);
                if (_ProjectXml.SelectedAddons.Contains(addon.Name))
                    clstAddons.SetItemChecked(clstAddons.Items.Count - 1, true);
            }
        }
        private void CopyKey(string addonName)
        {
            string keysDirectory = Path.Combine(_ProjectXml.AddonDirectory, "Keys");
            if (Directory.Exists(keysDirectory))
            {
                string addonDirectory = Path.Combine(_ProjectXml.AddonDirectory, addonName);

                DirectoryInfo directoryInfo = null;
                if (Directory.Exists(Path.Combine(addonDirectory, "keys")))
                    directoryInfo = new DirectoryInfo(Path.Combine(addonDirectory, "keys"));
                else if (Directory.Exists(Path.Combine(addonDirectory, "key")))
                    directoryInfo = new DirectoryInfo(Path.Combine(addonDirectory, "key"));

                if (directoryInfo != null)
                {
                    FileInfo[] files = directoryInfo.GetFiles("*.bikey");
                    foreach (FileInfo file in files)
                    {
                        string filename = Path.Combine(keysDirectory, file.Name);

                        if (File.Exists(filename))
                            if (MessageBox.Show("Soll die Datei: " + filename + " wirklich überschrieben werden?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                                continue;

                        lstLog.Items.Add("copy key: " + filename);
                        file.CopyTo(filename, true);
                    }
                }
                else
                    MessageBox.Show("Es konnten keine bikey-Dateien gefunden werden.");
            }
            else
                MessageBox.Show("Es wurde kein 'Keys' Verzeichnis im Addon-Verzeichnis gefunden. Diese Funktion kann nicht ausgeführt werden.");
        }
        private void ReSignKey(string addonName)
        {
            MessageBox.Show("Diese Funktion ist noch nicht verfügbar");
        }
        private void LockGui()
        {
        }
        private void UnlockGui()
        {
        }
        protected bool Modified
        {
            get
            {
                return _Modified;
            }
            set
            {
                _Modified = value;
                menSave.Enabled = _Modified;
            }
        }

        private void txtAddonDirectory_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtAddonDirectory.Text))
                txtAddonDirectory.BackColor = Color.Orange;
            else
                txtAddonDirectory.BackColor = SystemColors.Window;

            if (_BlockEvents)
                return;
            
            _ProjectXml.AddonDirectory = txtAddonDirectory.Text;
            
            RefreshAddonList();

            Modified = true;
        }
        private void txtFtpAddress_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            if (_ProjectXml.FtpRepository != null)
                _ProjectXml.FtpRepository.Address = txtFtpAddress.Text;
            Modified = true;
        }
        private void txtFtpUsername_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            if (_ProjectXml.FtpRepository != null)
                _ProjectXml.FtpRepository.Username = txtFtpUsername.Text;
        }
        private void txtFtpPassword_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            if (_ProjectXml.FtpRepository != null)
                _ProjectXml.FtpRepository.Password = txtFtpPassword.Text;
            Modified = true;
        }
        private void txtLocalRepositoryDirectory_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtLocalRepositoryDirectory.Text))
                txtLocalRepositoryDirectory.BackColor = Color.Orange;
            else
                txtLocalRepositoryDirectory.BackColor = SystemColors.Window;

            if (_BlockEvents)
                return;

            if (_ProjectXml.LocalRepository != null)
                _ProjectXml.LocalRepository.Directory = txtLocalRepositoryDirectory.Text;
            Modified = true;
        }
        private void btnBrowseAddonDirectory_Click(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;
            if (folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtAddonDirectory.Text = folderDlg.SelectedPath;
            Modified = true;
        }
        private void btnBrowseLocalRepositoryDirectory_Click(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;
            if (folderDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtLocalRepositoryDirectory.Text = folderDlg.SelectedPath;
            Modified = true;
        }

        private void tabControlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;
            if (_ProjectXml != null)
            {
                if (tabControlMode.SelectedIndex == 0)
                {
                    _ProjectXml.FtpRepository = new ProjectXml.FtpRepositoryXml();
                    _ProjectXml.LocalRepository = null;
                }
                else
                {
                    _ProjectXml.FtpRepository = null;
                    _ProjectXml.LocalRepository = new ProjectXml.LocalRepositoryXml();
                }
                LoadProject(_ProjectXml);
            }
            Modified = true;
        }
        private void clstAddons_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_BlockEvents)
                return;
            if (_ProjectXml == null)
                return;

            if (_ProjectXml.SelectedAddons == null)
                _ProjectXml.SelectedAddons = new string[0];

            if (e.NewValue == CheckState.Checked)
            {
                string[] items = new string[_ProjectXml.SelectedAddons.Length + 1];
                for (int i = 0; i < clstAddons.CheckedItems.Count; i++)
                    items[i] = clstAddons.CheckedItems[i] as string;
                items[items.Length - 1] = clstAddons.Items[e.Index] as string;
                _ProjectXml.SelectedAddons = items;
            }
            else
            {
                int o = 0;
                string[] items = new string[_ProjectXml.SelectedAddons.Length - 1];
                for (int i = 0; i < clstAddons.CheckedItems.Count; i++)
                {
                    if (clstAddons.CheckedItems[i] != clstAddons.Items[e.Index])
                    {
                        items[o] = clstAddons.CheckedItems[i] as string;
                        o++;
                    }
                }
                _ProjectXml.SelectedAddons = items;
            }

            Modified = true;
        }

        private void menNew_Click(object sender, EventArgs e)
        {
            LoadProject(new ProjectXml());
        }
        private void menOpen_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                LoadProject(openDlg.FileName);
        }
        private void menSave_Click(object sender, EventArgs e)
        {
            SaveProject();
        }
        private void menSaveAs_Click(object sender, EventArgs e)
        {
            SaveProjectAs();
        }
        private void menReloadAddons_Click(object sender, EventArgs e)
        {
            RefreshAddonList();
        }
        private void menExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menRepoVerify_Click(object sender, EventArgs e)
        {
            SynchronizeRepository(false);
        }
        private void menRepoUpload_Click(object sender, EventArgs e)
        {
            SynchronizeRepository(true);
        }
        private void menInfo_Click(object sender, EventArgs e)
        {
            AboutDialog.ExecuteDialog();
        }

        public void WriteLog(string text)
        {
            lstLog.Items.Add(text);
            lstLog.SelectedIndex = lstLog.Items.Count - 1;
            Application.DoEvents();
        }
        public void ClearLog()
        {
            lstLog.Items.Clear();
            Application.DoEvents();
        }

        private void cmenReSign_Click(object sender, EventArgs e)
        {
            if (clstAddons.SelectedItem != null)
                ReSignKey(clstAddons.SelectedItem as string);
        }
        private void cmenCopyKey_Click(object sender, EventArgs e)
        {
            if (clstAddons.SelectedItem != null)
                CopyKey(clstAddons.SelectedItem as string);
        }

        private void cmenMain_Opening(object sender, CancelEventArgs e)
        {
            cmenCopyKey.Enabled = clstAddons.SelectedItem != null;
            cmenReSign.Enabled = clstAddons.SelectedItem != null;
        }

     
    }
}
