using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST.RSM.Service
{
    public partial class ProcessXmlControl : UserControl
    {
        public event EventHandler ConfigurationChanged;
        protected virtual void OnConfigurationChanged()
        {
            if (ConfigurationChanged != null)
                ConfigurationChanged(this, null);
        }

        private bool _BlockEvents = false;
        private GameServerXml.ProcessXml _ProcessXml = new GameServerXml.ProcessXml();

        public ProcessXmlControl()
        {
            InitializeComponent();

          //  RefreshFromProcessXml();
        }

        public string Description
        {
            get
            {
                return lblDescription.Text;
            }
            set
            {
                lblDescription.Text = value;
            }
        }
        public GameServerXml.ProcessXml GetProcessXml()
        {
            if ((_ProcessXml.FileName == "") && (_ProcessXml.WorkingDirectory == "") && (_ProcessXml.Arguments == ""))
                return null;
            else
                return _ProcessXml;
        }
        public void SetProcessXml(GameServerXml.ProcessXml value)
        {
            if (value == null)
                _ProcessXml = new GameServerXml.ProcessXml();
            else
                _ProcessXml = value;

            RefreshFromProcessXml();
        }

        private void RefreshFromProcessXml()
        {
            _BlockEvents = true;

            if (_ProcessXml != null)
            {
                Enabled = true;
                txtFilename.Text = _ProcessXml.FileName;
                txtWorkingDirectory.Text = _ProcessXml.WorkingDirectory;
                txtArguments.Text = _ProcessXml.Arguments;
            }
            else
            {
                Enabled = false;
                txtFilename.Text = "";
                txtWorkingDirectory.Text = "";
                txtArguments.Text = "";
            }

            ValidateInputs();

            _BlockEvents = false;
        }
        private void ValidateInputs()
        {

            if ((txtFilename.Text == "") && (txtWorkingDirectory.Text == ""))
            {
                txtFilename.BackColor = SystemColors.Window;
                txtWorkingDirectory.BackColor = SystemColors.Window;
            }
            else
            {
                if (File.Exists(txtFilename.Text))
                    txtFilename.BackColor = SystemColors.Window;
                else
                    txtFilename.BackColor = Color.LavenderBlush;

                if (Directory.Exists(txtWorkingDirectory.Text))
                    txtWorkingDirectory.BackColor = SystemColors.Window;
                else
                    txtWorkingDirectory.BackColor = Color.LavenderBlush;
            }
        }

        private void btnBrowseFilename_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.DefaultExt = "*.exe";
                dlg.Filter = "Anwendung|*.exe";
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFilename.Text = dlg.FileName;
                    txtWorkingDirectory.Text = System.IO.Path.GetDirectoryName(dlg.FileName);
                }
            }
        }
        private void btnBrowseWorkingDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (Directory.Exists(txtWorkingDirectory.Text))
                    dlg.SelectedPath = txtWorkingDirectory.Text;

                if (dlg.ShowDialog() == DialogResult.OK)
                    txtWorkingDirectory.Text = dlg.SelectedPath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            _ProcessXml = new GameServerXml.ProcessXml();
            _ProcessXml.FileName = txtFilename.Text;
            _ProcessXml.WorkingDirectory = txtWorkingDirectory.Text;
            _ProcessXml.Arguments = txtArguments.Text;
            OnConfigurationChanged();
        }

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            ValidateInputs();
            btnSave.Enabled = true;
        }

        private void txtWorkingDirectory_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            ValidateInputs();
            btnSave.Enabled = true;
        }

        private void txtArguments_TextChanged(object sender, EventArgs e)
        {
            if (_BlockEvents)
                return;

            ValidateInputs();
            btnSave.Enabled = true;
        }
    }
}
