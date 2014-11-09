using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class SettingsDialog : Form
    {
        private Configuration _Configuration;

        private SettingsDialog()
        {
            InitializeComponent();
        }

        public static bool ExecuteDialog(Configuration configuration)
        {
            using (SettingsDialog dlg = new SettingsDialog())
            {
                dlg._Configuration = configuration;
                dlg.txtArmaExe.Text = configuration.Arma3Exe;
                dlg.chbCloseAfterLaunch.Checked = configuration.CloseAfterStart;
                dlg.chbCheckForUpdates.Checked = configuration.CheckForUpdates;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    dlg._Configuration.CloseAfterStart = dlg.chbCloseAfterLaunch.Checked;
                    dlg._Configuration.CheckForUpdates= dlg.chbCheckForUpdates.Checked;
                    dlg._Configuration.Arma3Exe = dlg.txtArmaExe.Text;
                    return true;
                }
                else
                    return false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "exe|*.exe";
            dlg.DefaultExt = "*.exe";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                txtArmaExe.Text = dlg.FileName;
        }
    }
}
