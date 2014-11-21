using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PALAST.Query
{
    public partial class QueryDialog : Form
    {
        private SteamQuery _SteamQuery = null;

        private QueryDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(System.Net.IPEndPoint ipEndPoint)
        {
            using (QueryDialog dlg = new QueryDialog())
            {
                dlg._SteamQuery = new SteamQuery(ipEndPoint);
                dlg._SteamQuery.Timeout = 2000;
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            UpdateServerInfos();
        }

        private void UpdateServerInfos()
        {
            //QuerySocket socket = new QuerySocket("37.187.165.126", 2303);
            //QuerySocket socket = new QuerySocket("217.23.12.167", 2703);

            lblNameData.Text = "Bitte warten...";
            lblMissionData.Text = "";
            lstDetails.Items.Clear();
            lvwPlayers.Items.Clear();

            Application.DoEvents();

            SteamQuery.InfoResult infoResult = _SteamQuery.GetInfo();
            if (infoResult != null)
            {
                lblNameData.Text = infoResult.Name;
                lblMissionData.Text = infoResult.Mission;

                lstDetails.Items.Add("Spiel: " + infoResult.Game);
                lstDetails.Items.Add("Version: " + infoResult.Version);
                lstDetails.Items.Add("Spieler: " + infoResult.Players + "/" + infoResult.PlayersMax);
                lstDetails.Items.Add("Insel/Karte: " + infoResult.Map);
                lstDetails.Items.Add("Öffentlich: " + infoResult.IsPublic);
                lstDetails.Items.Add("Betriebssystem: " + infoResult.Environment);
                lstDetails.Items.Add("Servertyp: " + infoResult.ServerType);
                lstDetails.Items.Add("VAC: " + infoResult.UsesVAC);

                SteamQuery.PlayerResult playerResult = _SteamQuery.GetPlayers();
                if ((playerResult != null) && (playerResult.Players != null))
                {
                    for (int i = 0; i < playerResult.Players.Length; i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = (i + 1).ToString();
                        item.SubItems.Add(playerResult.Players[i].Name);
                        item.SubItems.Add(playerResult.Players[i].Score.ToString());
                        item.SubItems.Add(playerResult.Players[i].Duration.ToString());
                        lvwPlayers.Items.Add(item);
                    }
                }
            }
            else
                lblNameData.Text = "Keine Rückmeldung vom Server";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateServerInfos();
        }
    }
}
