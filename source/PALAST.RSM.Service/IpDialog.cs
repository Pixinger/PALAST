using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST.RSM.Service
{
    public partial class IpDialog : Form
    {
        private IpDialog()
        {
            InitializeComponent();
        }

        public static void ExecuteDialog(ConfigurationXml configuration)
        {
            using (IpDialog dlg = new IpDialog())
            {
                if (configuration.ServerIP == null)
                    configuration.ServerIP = "";

                if (configuration.ServerPort < 1)
                    configuration.ServerPort = 12000;

                dlg.txtIP.Text = configuration.ServerIP;
                dlg.numPort.Value = configuration.ServerPort;

                DialogResult result = dlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    configuration.ServerIP = dlg.txtIP.Text;
                    configuration.ServerPort = (int)dlg.numPort.Value;
                }
            }
        }
    }
}
