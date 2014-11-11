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
    public partial class UpdateNotificationDialog : Form
    {
        private bool _CanClose = true;
        private string _Filename = null;

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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            e.Cancel = !_CanClose;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (System.Diagnostics.Process.Start(linkLabel.Text))
            {
            }
        }
        private void btnUpdateNow_Click(object sender, EventArgs e)
        {
            if (_Filename != null)
                return;

            _CanClose = false;
            btnOK.Enabled = false;
            btnUpdateNow.Visible = false;
            progressBar1.Visible = true;

            _Filename = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PALAST", "setupUpdate.exe");

            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
            webClient.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
            webClient.DownloadFileAsync(new Uri("https://raw.githubusercontent.com/Pixinger/PALAST/master/_releases/latestVersion.xml"), _Filename);
        }

        private void webClient_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            _CanClose = true;
            btnOK.Enabled = true;
            System.Diagnostics.Process.Start(_Filename + " / ", "/SP- /silent /noicons \"/dir=expand:{pf}\\PALAST\"");
            Application.Exit();
        }
    }
}
