using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST.RSM
{
    public partial class TokenDialog : Form
    {
        private TokenDialog()
        {
            InitializeComponent();
        }

        public static string ExecuteDialog(string clientToken)
        {
            using (TokenDialog dlg = new TokenDialog())
            {
                dlg.txtClientToken.Text = clientToken;
                dlg.ValidateToken();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (TokenTools.IsValid(dlg.txtClientToken.Text))
                        return dlg.txtClientToken.Text;
                    else
                        return "";
                }
                else
                    return clientToken;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                if (!ValidateToken())
                    if (MessageBox.Show("Der Token ist ungültig. Soll er gelöscht werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.None)
                        e.Cancel = true;
        }

        private bool ValidateToken()
        {
            if (TokenTools.IsValid(txtClientToken.Text))
            {
                _ErrorProvider.SetError(txtClientToken, "");
                return true;
            }
            else
            {
                _ErrorProvider.SetIconAlignment(txtClientToken, ErrorIconAlignment.MiddleLeft);
                _ErrorProvider.SetError(txtClientToken, "Ungültiger Token");
                return false;
            }
        }

        private void txtClientToken_TextChanged(object sender, EventArgs e)
        {
            ValidateToken();
        }
    }
}
