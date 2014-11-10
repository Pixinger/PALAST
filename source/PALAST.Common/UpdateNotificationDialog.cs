﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST
{
    public partial class UpdateNotificationDialog : Form
    {
        private UpdateNotificationDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(Version version, string url)
        {
            using (UpdateNotificationDialog dlg = new UpdateNotificationDialog())
            {
                dlg.linkLabel.Text = url;
                dlg.lblVersion2.Text = version.ToString();
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (System.Diagnostics.Process.Start(linkLabel.Text))
            {
            }
        }
    }
}
