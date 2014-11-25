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
    public partial class SetupDialog : Form
    {
        private ConfigurationXml _ConfigurationXml;

        private SetupDialog()
        {
            InitializeComponent();
        }
        public static DialogResult ExecuteDialog(ConfigurationXml configurationXml)
        {
            using (SetupDialog dlg = new SetupDialog())
            {
                dlg._ConfigurationXml = configurationXml;
                dlg.RefreshGameServerPanel();
                DialogResult result = dlg.ShowDialog();
                return result;
            }
        }

        private void RefreshGameServerPanel()
        {
            lstGameServers.Items.Clear();

            if (_ConfigurationXml.GameServers != null)
                foreach (GameServerXml gameServer in _ConfigurationXml.GameServers)
                    lstGameServers.Items.Add(gameServer);

            RefreshUsersPanel();
            RefreshProcessPanel();
        }
        private void RefreshUsersPanel()
        {
            lstUsers.Items.Clear();

            if (SelectedGameServer != null)
            {
                if (SelectedGameServer.Users != null)
                    foreach (GameServerXml.UserXml user in SelectedGameServer.Users)
                        lstUsers.Items.Add(user);
            }
        }
        private void RefreshProcessPanel()
        {
            GameServerXml gameServer = SelectedGameServer;
            if (gameServer == null)
            {
                pnlRight.Enabled = false;
                _PreProcessControl.SetProcessXml(null);
                _GameserverProcessControl.SetProcessXml(null);
                _PostProcessControl.SetProcessXml(null);
            }
            else
            {
                pnlRight.Enabled = true;
                _PreProcessControl.SetProcessXml(gameServer.PreProcess);
                _GameserverProcessControl.SetProcessXml(gameServer.GameServerProcess);
                _PostProcessControl.SetProcessXml(gameServer.PostProcess);
            }
        }

        private void _PreProcessControl_ConfigurationChanged(object sender, EventArgs e)
        {
            GameServerXml selectedGameServer = SelectedGameServer;

            if (selectedGameServer != null)
                selectedGameServer.PreProcess = _PreProcessControl.GetProcessXml();
        }
        private void _GameserverProcessControl_ConfigurationChanged(object sender, EventArgs e)
        {
            GameServerXml selectedGameServer = SelectedGameServer;

            if (selectedGameServer != null)
                selectedGameServer.GameServerProcess = _GameserverProcessControl.GetProcessXml();
        }
        private void _PostProcessControl_ConfigurationChanged(object sender, EventArgs e)
        {
            GameServerXml selectedGameServer = SelectedGameServer;

            if (selectedGameServer != null)
                selectedGameServer.PostProcess = _PostProcessControl.GetProcessXml();
        }

        private GameServerXml SelectedGameServer
        {
            get
            {
                return lstGameServers.SelectedItem as GameServerXml;
            }
        }
        private GameServerXml.UserXml SelectedUser
        {
            get
            {
                return lstUsers.SelectedItem as GameServerXml.UserXml;
            }
        }

        private void tbtnAddGameserver_Click(object sender, EventArgs e)
        {
            string name = StringDialog.ExecuteDialog("");
            if (!string.IsNullOrWhiteSpace(name))
            {
                GameServerXml gameServer = new GameServerXml();
                gameServer.Description = name;
                gameServer.GUID = _ConfigurationXml.GetNewGameServerGUID();

                GameServerXml[] gameServers = new GameServerXml[_ConfigurationXml.GameServers.Length + 1];
                _ConfigurationXml.GameServers.CopyTo(gameServers, 0);
                _ConfigurationXml.GameServers = gameServers;
                _ConfigurationXml.GameServers[gameServers.Length - 1] = gameServer;

                RefreshGameServerPanel();
            }
        }
        private void tbtnDeleteGameserver_Click(object sender, EventArgs e)
        {
            GameServerXml gameServer = SelectedGameServer;
            if (gameServer != null)
            {
                if (MessageBox.Show("Wollen Sie den Gameserver '" + gameServer.Description + "' wirklich löschen?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    List<GameServerXml> list = new List<GameServerXml>(_ConfigurationXml.GameServers);
                    list.Remove(gameServer);
                    _ConfigurationXml.GameServers = list.ToArray();

                    RefreshGameServerPanel();
                }
            }
        }
        private void lstGameServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbtnDeleteGameServer.Enabled = lstGameServers.SelectedIndex != -1;
            RefreshUsersPanel();
            RefreshProcessPanel();
        }

        private void tbtnAddUser_Click(object sender, EventArgs e)
        {
            GameServerXml gameServer = SelectedGameServer;
            if (gameServer != null)
            {
                string name = StringDialog.ExecuteDialog("username");
                if (!string.IsNullOrWhiteSpace(name))
                {
                    if (gameServer.Users == null)
                        gameServer.Users = new GameServerXml.UserXml[0];

                    GameServerXml.UserXml user = new GameServerXml.UserXml();
                    user.UserGuid = _ConfigurationXml.GetNewUserGUID(gameServer.GUID);
                    user.UserName = name;

                    GameServerXml.UserXml[] users = new GameServerXml.UserXml[gameServer.Users.Length + 1];
                    gameServer.Users.CopyTo(users, 0);
                    gameServer.Users = users;
                    gameServer.Users[users.Length - 1] = user;

                    RefreshUsersPanel();
                }
            }
        }
        private void tbtnDeleteUser_Click(object sender, EventArgs e)
        {
            GameServerXml.UserXml user = SelectedUser;
            if (user != null)
            {
                if (MessageBox.Show("Wollen Sie den User '" + user.UserName + "' wirklich löschen?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    List<GameServerXml.UserXml> list = new List<GameServerXml.UserXml>(SelectedGameServer.Users);
                    list.Remove(user);
                    SelectedGameServer.Users = list.ToArray();

                    RefreshUsersPanel();
                }
            }

        }
        private void tbtnToken_Click(object sender, EventArgs e)
        {
            if (SelectedGameServer == null)
                return;
            if (SelectedUser == null)
                return;

            TokenDialog.ExecuteDialog(SelectedUser.UserName, _ConfigurationXml.GetToken(SelectedGameServer.GUID, SelectedUser.UserGuid));
        }
        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameServerXml.UserXml user = SelectedUser;
            if (user != null)
            {
                tbtnToken.Enabled = true;
                tbtnDeleteUser.Enabled = true;
                tddRechte.Enabled = true;

                menAllowServerStop.Checked = user.AllowServerStop;
                menAllowServerStart.Checked = user.AllowServerStart;
                menAllowMissionUpload.Checked = user.AllowMissionUpload;
            }
            else
            {
                tbtnToken.Enabled = false;
                tbtnDeleteUser.Enabled = false;
                tddRechte.Enabled = false;
            }
        }

        private void menAllowServerStart_Click(object sender, EventArgs e)
        {
            GameServerXml.UserXml user = SelectedUser;
            if (user != null)
            {
                menAllowServerStart.Checked = !menAllowServerStart.Checked;
                user.AllowServerStart = menAllowServerStart.Checked;
            }
        }

        private void menAllowServerStop_Click(object sender, EventArgs e)
        {
            GameServerXml.UserXml user = SelectedUser;
            if (user != null)
            {
                menAllowServerStop.Checked = !menAllowServerStop.Checked;
                user.AllowServerStop = menAllowServerStop.Checked;
            }
        }

        private void menAllowMissionUpload_Click(object sender, EventArgs e)
        {
            GameServerXml.UserXml user = SelectedUser;
            if (user != null)
            {
                menAllowMissionUpload.Checked = !menAllowMissionUpload.Checked;
                user.AllowMissionUpload = menAllowMissionUpload.Checked;
            }
        }
    }
}