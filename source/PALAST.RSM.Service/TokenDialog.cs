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
    public partial class TokenDialog : Form
    {
        private TokenDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(string username, string token)
        {
            using (TokenDialog dlg = new TokenDialog())
            {
                Clipboard.SetText(token);
                dlg.lblName.Text = username;
                dlg.txtToken.Text = token;
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }

    }
}
