using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PALAST;
using System.IO;

namespace PALAST
{
    public partial class AddonSyncDialog : Form
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        private string _ArmaDirectory;
        private Configuration.Preset _Preset;

        private SyncClientHttpGz _SyncClient;
        private SyncBase.CompareRepositoriesAsyncResult _CompareRepositoriesAsyncResult = null; 


        private AddonSyncDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(string armaDirectory, Configuration.Preset preset)
        {
            if (!Directory.Exists(armaDirectory))
            {
                MessageBox.Show("Das angegebene Arma Verzeichnis konnte nicht gefunden werden1");
                return DialogResult.Cancel;
            }

            if (!File.Exists(Path.Combine(armaDirectory, "arma3.exe")))
                if (MessageBox.Show("In dem angegebenen Verzeichnis konnte keine Arma3.exe gefunden werden.\nSind sie sicher, dass es sich um das korrekte Verzeichnis handelt?\nEs könnten wichtige Daten gelöscht werden!\n\n" + armaDirectory, "Achtung!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    return DialogResult.Cancel;

            using (AddonSyncDialog dlg = new AddonSyncDialog())
            {
                dlg._ArmaDirectory = armaDirectory;
                dlg._Preset = preset;
                dlg.txtUrl.Text = preset.AddonSyncUrl;
            
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }
        
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (string.IsNullOrWhiteSpace(txtUrl.Text))
            {
                txtUrl.BackColor = Color.Orange;
                txtUrl.Focus();
            }
        }

        private void LockGui()
        {
            txtUrl.Enabled = false;
            clstCompareResults.Enabled = false;
            btnExit.Enabled = false;
            btnCompareRepositories.Enabled = false;
        }
        private void UnlockGui()
        {
            txtUrl.Enabled = true;
            clstCompareResults.Enabled = true;
            btnExit.Enabled = true;
            btnCompareRepositories.Enabled = true;
        }
        private void UpdateUserConfigs()
        {
            // Zusammenstellen welche Ergebnisse zum Synchronisieren ausgewählt wurden.
            List<SyncBase.CompareResult> compareResults = new List<SyncBase.CompareResult>();
            for (int i = 0; i < clstCompareResults.CheckedItems.Count; i++)
            {
                SyncBase.CompareResult compareResult = clstCompareResults.CheckedItems[i] as SyncBase.CompareResult;
                if ((compareResult != null) && (compareResult.Count > 0))
                    compareResults.Add(compareResult);
            }

            // Jetzt durchsuchen nach UserConfig Verzeichnissen.
            foreach (SyncBase.CompareResult compareResult in compareResults)
            {
                try
                {
                    string addonUserconfigDirectory = System.IO.Path.Combine(_ArmaDirectory, compareResult.Name);
                    addonUserconfigDirectory = System.IO.Path.Combine(addonUserconfigDirectory, "userconfig");
                    if (System.IO.Directory.Exists(addonUserconfigDirectory))
                    {
                        if (MessageBox.Show("Im Addon '" + compareResult.Name + "' wurde eine 'userconfig' gefunden.\n\nMöchten Sie diese nun in das Arma Verzeichnis kopieren?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            string armaUserconfigDirectory = Path.Combine(_ArmaDirectory, "userconfig");
                            if (!Directory.Exists(armaUserconfigDirectory))
                                Directory.CreateDirectory(armaUserconfigDirectory);
                            DirectoryInfo armaUserconfigDirectoryInfo = new DirectoryInfo(armaUserconfigDirectory);

                            DirectoryInfo addonUserconfigDirectoryInfo = new DirectoryInfo(addonUserconfigDirectory);
                            DirectoryInfo[] directoryInfos = addonUserconfigDirectoryInfo.GetDirectories();
                            foreach (DirectoryInfo directoryInfo in directoryInfos)
                            {
                                // Vorhandenes löschen
                                DirectoryInfo[] obsoleteDirecties = armaUserconfigDirectoryInfo.GetDirectories(directoryInfo.Name);
                                foreach (DirectoryInfo obsoleteDirecty in obsoleteDirecties)
                                    obsoleteDirecty.Delete(true);
                            }

                            // Alles aus dem Addon hineinkopieren
                            FileTools.CopyDirectoryRecursively(addonUserconfigDirectoryInfo, armaUserconfigDirectoryInfo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    LOG.Error(ex);
                    lstActions.Items.Add("Fehler beim verarbeiten der 'userconfig' im Addon " + compareResult.Name);
                    lstActions.Items.Add(ex.Message);
                }
            }
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            btnCompareRepositories.Enabled = !string.IsNullOrWhiteSpace(txtUrl.Text);
            btnSynchronize.Enabled = false;
            _Preset.AddonSyncUrl = txtUrl.Text;

            if (!btnCompareRepositories.Enabled)
                txtUrl.BackColor = Color.Orange;
            else
                txtUrl.BackColor = SystemColors.Window;
        }
        private void clstCompareResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstActions.Items.Clear();

            SyncBase.CompareResult compareResult = clstCompareResults.SelectedItem as SyncBase.CompareResult;
            if (compareResult != null)
            {
                string[] details = compareResult.GetDetailStrings();
                foreach (string detail in details)
                    lstActions.Items.Add(detail);
            }
        }
        
        private void btnCompareRepositories_Click(object sender, EventArgs e)
        {
            LockGui();

            try
            {
                lstActions.Items.Clear();
                lstActions.ForeColor = Color.Black;
                lstActions.Items.Add("Analyse läuft... Bitte warten.");

                _SyncClient = new SyncClientHttpGz(_Preset.AddonSyncUrl, _ArmaDirectory, lvwLog);
                _SyncClient.CompareRepositories(new SyncBase.CompareRepositoriesAsyncResultEventHandler(OnCompareRepositoriesCompleted));
                btnCancel.Enabled = true;
            }
            catch (Exception ex)
            {
#if(DEBUG)
                MessageBox.Show(ex.Message + "\n\n---------------------------------\n" + ex.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void OnCompareRepositoriesCompleted(object sender, SyncBase.CompareRepositoriesAsyncResult e)
        {
            if (InvokeRequired)
                BeginInvoke(new SyncBase.CompareRepositoriesAsyncResultEventHandler(OnCompareRepositoriesCompleted), new object[] { sender, e });
            else
            {
                if (!e.IsFailed)
                {
                    clstCompareResults.Items.Clear();

                    int modifications = 0;
                    for (int i = 0; i < e.CompareResults.Length; i++)
                    {
                        clstCompareResults.Items.Add(e.CompareResults[i]);
                        clstCompareResults.SetItemChecked(i, e.CompareResults[i].Count > 0);
                        modifications += e.CompareResults[i].Count;
                        lstActions.Items.Add(e.CompareResults[i].Count + " Änderung(en): " + e.CompareResults[i]);
                    }

                    if (modifications == 0)
                    {
                        _CompareRepositoriesAsyncResult = null;
                        lstActions.Items.Add("------------------------------------------------------------------------");
                        lstActions.Items.Add("== Alle gewählten Addons sind aktuell ==");
                        btnCompareRepositories.BackColor = Color.Lime;
                        lstActions.ForeColor = Color.Green;
                        btnSynchronize.Enabled = false;
                    }
                    else
                    {
                        _CompareRepositoriesAsyncResult = e;
                        lstActions.Items.Add("------------------------------------------------------------------------");
                        lstActions.Items.Add("Klicke auf das Addon um genauere Informationen zu erhalten.");
                        lstActions.Items.Add("== Anzahl der Änderungen: " + modifications + " ==");
                        btnCompareRepositories.BackColor = Color.Red;
                        lstActions.ForeColor = Color.Red;
                        btnSynchronize.Enabled = true;
                    }
                }
                else
                {
                    _CompareRepositoriesAsyncResult = null;
                    lstActions.Items.Add("------------------------------------------------------------------------");
                    lstActions.Items.Add("== Der Vorgang wurde mit einem Fehler beendet ==");
                    lstActions.Items.Add("== Nachricht: " + e.Error);
                    lstActions.Items.Add("------------------------------------------------------------------------");

                    btnCompareRepositories.BackColor = SystemColors.Control;
                    lstActions.ForeColor = Color.Black;
                    btnSynchronize.Enabled = false;
                }

                btnCancel.Enabled = false;
                UnlockGui();
            }
        }

        private void btnSynchronize_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Assert(_CompareRepositoriesAsyncResult != null);

            LockGui();

            try
            {
                lstActions.Items.Clear();
                lstActions.ForeColor = Color.Black;
                lstActions.Items.Add("Datenaustausch läuft... Bitte warten.");

                btnSynchronize.Enabled = false;
                btnCompareRepositories.BackColor = SystemColors.Control;
                lstActions.ForeColor = SystemColors.WindowText;

                // Zusammenstellen welche Ergebnisse zum Synchronisieren ausgewählt wurden.
                List<SyncBase.CompareResult> compareResults = new List<SyncBase.CompareResult>();
                for (int i = 0; i < clstCompareResults.CheckedItems.Count; i++)
                {
                    SyncBase.CompareResult compareResult = clstCompareResults.CheckedItems[i] as SyncBase.CompareResult;
                    if ((compareResult != null) && (compareResult.Count > 0))
                        compareResults.Add(compareResult);
                }

                // Die übergebene Liste synchronisieren
                _SyncClient.Synchronize(_CompareRepositoriesAsyncResult, new SyncBase.SynchronizeAsyncResultEventHandler(OnSynchronizeCompletedEventHandler), compareResults.ToArray());
                btnCancel.Enabled = true;
            }
            catch (Exception ex)
            {
#if(DEBUG)
                MessageBox.Show(ex.Message + "\n\n---------------------------------\n" + ex.StackTrace.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }
        private void OnSynchronizeCompletedEventHandler(object sender, SyncBase.SynchronizeAsyncResult e)
        {
            if (InvokeRequired)
                BeginInvoke(new SyncBase.SynchronizeAsyncResultEventHandler(OnSynchronizeCompletedEventHandler), new object[] { sender, e });
            else
            {
                if (!e.IsFailed)
                {
                    lstActions.Items.Add("------------------------------------------------------------------------");
                    lstActions.Items.Add("== Der Vorgang wurde erfolgreich beendet ==");
                }
                else
                {
                    lstActions.Items.Add("------------------------------------------------------------------------");
                    lstActions.Items.Add("== Der Vorgang wurde mit einem Fehler beendet ==");
                    lstActions.Items.Add(e.Error);
                    lstActions.Items.Add("------------------------------------------------------------------------");
                }

                btnCompareRepositories.BackColor = SystemColors.Control;
                lstActions.ForeColor = Color.Black;
                btnSynchronize.Enabled = false;
                btnCancel.Enabled = false;

                UnlockGui();

                UpdateUserConfigs();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_SyncClient != null)
                _SyncClient.RequestCancel();
        }
    }
}
