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
    public partial class AddonSyncDialog : Form
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
            btnSynchronize.Enabled = false;
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
                btnSynchronize.Enabled = false;
                clstCompareResults.Items.Clear();

                lstActions.Items.Clear();
                lstActions.Items.Add("Initializing updater");
                _SyncClient = new SyncClientHttpGz(_Preset.AddonSyncUrl, _ArmaDirectory, lvwLog);

                lstActions.Items.Add("Load repositories");
                _SyncClient.LoadRepositories();

                lstActions.Items.Add("Compare addons");
                SyncBase.CompareResult[] compareResults = _SyncClient.CompareRepositories();
                System.Diagnostics.Debug.Assert(compareResults != null);

                lstActions.Items.Add("------------------------------------------------------------------------");
                int modifications = 0;
                for (int i = 0; i < compareResults.Length; i++)
                {
                    clstCompareResults.Items.Add(compareResults[i]);
                    clstCompareResults.SetItemChecked(i, compareResults[i].Count > 0);
                    modifications += compareResults[i].Count;
                    lstActions.Items.Add(compareResults[i] + " - (" + compareResults[i].Count + " modifications)");
                }
                lstActions.Items.Add("------------------------------------------------------------------------");
                lstActions.Items.Add("== Total modifications: " + modifications + " ==");

                btnValidate.BackColor = modifications > 0 ? Color.Red : Color.Lime;
                lstActions.ForeColor = modifications > 0 ? Color.Red : Color.Green;
                btnSynchronize.Enabled = (modifications > 0);
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
        private void btnSynchronize_Click(object sender, EventArgs e)
        {
            LockGui();

            try
            {
                btnSynchronize.Enabled = false;
                btnValidate.BackColor = SystemColors.Control;
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
                _SyncClient.SynchronizeAsync(compareResults.ToArray(), new SyncBase.SynchronizeCompletedEventHandler(OnSynchronizeCompletedEventHandler));

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
        private void OnSynchronizeCompletedEventHandler(object sender, SyncBase.SynchronizeResultObject e)
        {
            if (InvokeRequired)
                Invoke(new SyncBase.SynchronizeCompletedEventHandler(OnSynchronizeCompletedEventHandler), new object[] { sender, e });
            else
            {
                UnlockGui();
                
                lstActions.Items.Clear();
                if (e.IsFailed)
                {
                    lstActions.Items.Add("Synchronisieren fehlgeschlagen!");
                    lstActions.Items.Add(e.Error);
                }
                else
                {
                    lstActions.Items.Add("Synchronisieren erfolgreich");
                }
            }
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
