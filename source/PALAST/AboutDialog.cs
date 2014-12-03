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
    public partial class AboutDialog : Form
    {
        private AboutDialog()
        {
            InitializeComponent();

            lblVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static DialogResult ExecuteDialog()
        {
            using (AboutDialog dlg = new AboutDialog())
            {
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (System.Diagnostics.Process.Start(linkLabel1.Text))
            {
            }
        }
    }
}
