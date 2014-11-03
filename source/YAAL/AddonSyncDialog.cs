using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YAAST;

namespace YAAL
{
    public partial class AddonSyncDialog : Form, LogList.ILogWriter
    {
        private string _ArmaDirectory;
        private Configuration.Preset _Preset;

        private SyncClientHttpGz _SyncClient;

        private AddonSyncDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(string armaDirectory, Configuration.Preset preset)
        {
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

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            btnValidate.Enabled = !string.IsNullOrWhiteSpace(txtUrl.Text);
            btnUpdate.Enabled = false;
            _Preset.AddonSyncUrl = txtUrl.Text;

            if (!btnValidate.Enabled)
                txtUrl.BackColor = Color.Orange;
            else
                txtUrl.BackColor = SystemColors.Window;
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            LockGui();

            try
            {
                btnUpdate.Enabled = false;
                clstCompareResults.Items.Clear();

                LogList.SetLogTarget(this);

                LogList.Clear();
                LogList.Info("Initializing updater");
                _SyncClient = new SyncClientHttpGz(_Preset.AddonSyncUrl, _ArmaDirectory);

                LogList.Info("Load repositories");
                _SyncClient.LoadRepositories();

                LogList.Info("Compare addons");
                SyncBase.CompareResult[] compareResults = _SyncClient.CompareRepositories();
                System.Diagnostics.Debug.Assert(compareResults != null);

                LogList.Info("------------------------------------------------------------------------");
                int modifications = 0;
                for (int i = 0; i < compareResults.Length; i++)
                {
                    clstCompareResults.Items.Add(compareResults[i]);
                    clstCompareResults.SetItemChecked(i, compareResults[i].Count > 0);
                    modifications += compareResults[i].Count;
                    lstActions.Items.Add(compareResults[i] + " - (" + compareResults[i].Count + " modifications)");
                }
                LogList.Info("------------------------------------------------------------------------");
                LogList.Info("== Total modifications: " + modifications + " ==");
                LogList.SetLogTarget(null);

                btnUpdate.Enabled = (modifications > 0);
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LockGui();

            try
            {
                btnUpdate.Enabled = false;

                LogList.SetLogTarget(this);
                LogList.Clear();
                // Zusammenstellen welche Ergebnisse zum Synchronisieren ausgewählt wurden.
                List<SyncBase.CompareResult> compareResults = new List<SyncBase.CompareResult>();
                for (int i = 0; i < clstCompareResults.CheckedItems.Count; i++)
                {
                    SyncBase.CompareResult compareResult = clstCompareResults.CheckedItems[i] as SyncBase.CompareResult;
                    if ((compareResult != null) && (compareResult.Count > 0))
                        compareResults.Add(compareResult);
                }

                // Die übergebene Liste synchronisieren
                lstActions.Items.Add("Synchronize selected addons");
                if (!_SyncClient.Synchronize(compareResults.ToArray()))
                    throw new Exception("Synchronize() failed");

                LogList.Info("------------------------------------------------------------------------");
                LogList.Info("Operation finished successfully !!!");
                LogList.SetLogTarget(null);
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

        public void WriteLog(string text)
        {
            lstActions.Items.Add(text);
            lstActions.SelectedIndex = lstActions.Items.Count - 1;
            Application.DoEvents();
        }
        public void ClearLog()
        {
            lstActions.Items.Clear();
            Application.DoEvents();
        }

        private void LockGui()
        {
            txtUrl.Enabled = false;
            clstCompareResults.Enabled = false;
            btnExit.Enabled = false;
            btnValidate.Enabled = false;
        }
        private void UnlockGui()
        {
            txtUrl.Enabled = true;
            clstCompareResults.Enabled = true;
            btnExit.Enabled = true;
            btnValidate.Enabled = true;
        }
        private void clstCompareResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstActions.Items.Clear();
            
            SyncBase.CompareResult compareResult = clstCompareResults.SelectedItem as SyncBase.CompareResult;
            if (compareResult != null)
            {
                string[] details = compareResult.GetDetailStrings();
                foreach(string detail in details)
                    lstActions.Items.Add(detail);
            }
        }
    }
}
