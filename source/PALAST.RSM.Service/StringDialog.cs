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
    public partial class StringDialog : Form
    {
        private StringDialog()
        {
            InitializeComponent();
        }

        public static string ExecuteDialog(string name)
        {
            using (StringDialog dlg = new StringDialog())
            {
                dlg.txtName.Text = name;
                if (dlg.ShowDialog() == DialogResult.OK)
                    return dlg.txtName.Text;
                else
                    return null;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (txtName.Text.Length > 1);
        }
    }
}
