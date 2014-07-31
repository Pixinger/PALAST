using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PixYAAL
{
    public partial class AboutDialog : Form
    {
        private AboutDialog()
        {
            InitializeComponent();

            lblVersion.Text = Application.ProductVersion;
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
    }
}
