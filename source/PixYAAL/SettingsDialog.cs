using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAAL
{
    public partial class SettingsDialog : Form
    {
        private Configuration _Configuration;

        private SettingsDialog()
        {
            InitializeComponent();
        }

        public static void ExecuteDialog(Configuration configuration)
        {
            using (SettingsDialog dlg = new SettingsDialog())
            {
                dlg._Configuration = configuration;
                dlg.RefreshListbox();
                dlg.txtArmaExe.Text = configuration.Arma3Exe;
                dlg.ShowDialog();
            }
        }

        private void RefreshListbox()
        {
            lstPreset.Items.Clear();
            if (_Configuration.Presets != null)
                foreach (Configuration.Preset preset in _Configuration.Presets)
                    lstPreset.Items.Add(preset);
        }
        private bool IsNameValid(string name)
        {
            foreach (Configuration.Preset preset in _Configuration.Presets)
                if (preset.Name == name)
                    return false;

            return true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = true;
            dlg.Filter = "exe|*.exe";
            dlg.DefaultExt = "*.exe";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtArmaExe.Text = dlg.FileName;
                _Configuration.Arma3Exe = txtArmaExe.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                    List<Configuration.Preset> list = _Configuration.Presets != null ? new List<Configuration.Preset>(_Configuration.Presets) : new List<Configuration.Preset>();
                    list.Add(preset);
                    _Configuration.Presets = list.ToArray();
                    RefreshListbox();
                }
            }
        }
        private void btnClone_Click(object sender, EventArgs e)
        {
            Configuration.Preset preset = (lstPreset.SelectedItem as Configuration.Preset).Clone();
            string newName = preset.Name + " (clone)";
            while (!IsNameValid(newName)) { newName += " (clone)"; }
            preset.Name = newName;
            
            List<Configuration.Preset> list = new List<Configuration.Preset>(_Configuration.Presets);
            list.Add(preset);
            _Configuration.Presets = list.ToArray();
            RefreshListbox();
        }
        private void btnRename_Click(object sender, EventArgs e)
        {
            Configuration.Preset preset =lstPreset.SelectedItem as Configuration.Preset;
            string name = RenamePresetDialog.ExecuteDialog(preset.Name);
            if (name != null)
            {
                preset.Name = name;
                RefreshListbox();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Configuration.Preset> list = new List<Configuration.Preset>(_Configuration.Presets);
            foreach (Configuration.Preset preset in lstPreset.SelectedItems)
                list.Remove(preset);
            _Configuration.Presets = list.ToArray();
            RefreshListbox();            
        }

        private void lstPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPreset.SelectedIndex != -1)
            {
                btnRemove.Enabled = true;
                btnClone.Enabled = (lstPreset.SelectedItems.Count == 1);
                btnRename.Enabled = (lstPreset.SelectedItems.Count == 1);
            }
            else
            {
                btnRemove.Enabled = false;
                btnRename.Enabled = false;
                btnClone.Enabled = false;
            }
        }
    }
}
