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
    public partial class ManagerDialog : Form
    {
        #region nLog instance (LOG)
        protected static readonly NLog.Logger LOG = NLog.LogManager.GetCurrentClassLogger();
        #endregion
		
        private delegate void ServerStateDelegate(ServerStates state);
        private Configuration.Preset _Preset;

        private ClientHttp _ClientHttp = null;
        private bool _ExitThreads = false;

        private ManagerDialog()
        {
            InitializeComponent();
        }

        public static DialogResult ExecuteDialog(Configuration.Preset preset)
        {
            using (ManagerDialog dlg = new ManagerDialog())
            {
                if (!TokenTools.IsValid(preset.RsmServerToken))
                    preset.RsmServerToken = TokenDialog.ExecuteDialog("");

                if (TokenTools.IsValid(preset.RsmServerToken))
                {
                    dlg._Preset = preset;
                    DialogResult result = dlg.ShowDialog();
                    dlg._ExitThreads = true;
                    return result;
                }
                else
                    return DialogResult.Cancel;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _ClientHttp = new ClientHttp(_Preset.RsmServerToken);

            tbtnRefresh.PerformClick();
        }

        private void RefreshServerStatus(ServerStates state)
        {
            slblStatus.Text = state.ToString();

            switch (state)
            {
                case ServerStates.Unknown:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.Starting:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.StartingPreLaunch:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.StartingGamerServer:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.StartingPostLaunch:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.Started:
                    tbtnStop.Enabled = true;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.StartedWithErrors:
                    tbtnStop.Enabled = true;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.Stopping:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = false;
                    break;
                case ServerStates.Stopped:
                    tbtnStop.Enabled = false;
                    tbtnStart.Enabled = true;
                    break;
            }
        }

        private void tbtnRefresh_Click(object sender, EventArgs e)
        {
            _AddonList.Clear();

            GameServerDetails serverInfo;
            if ((_ClientHttp.GetServerDetails(out serverInfo)) && (serverInfo != null))
            {
                slblStatus.Text = serverInfo.Status.ToString();
                foreach (GameServerDetails.AddonInfo addonInfo in serverInfo.Addons)
                    _AddonList.Add(addonInfo.Name, addonInfo.Enabled);

                RefreshServerStatus(serverInfo.Status);
            }
            else
            {
                tbtnStop.Enabled = false;
                tbtnStart.Enabled = false;
                slblStatus.Text = "keine Rückmeldung vom RSM-Service";
            }
        }
        private void tbtnSetup_Click(object sender, EventArgs e)
        {
            _Preset.RsmServerToken = TokenDialog.ExecuteDialog(_Preset.RsmServerToken);
            if (!TokenTools.IsValid(_Preset.RsmServerToken))
                Close();
        }

        private void tbtnStart_Click(object sender, EventArgs e)
        {
            List<string> addonsEnabled = new List<string>(_AddonList.Count);
            for (int i = 0; i < _AddonList.Count; i++)
                if (_AddonList.GetItemCheckState(i))
                    addonsEnabled.Add(_AddonList[i]);

            if (!_ClientHttp.Start(addonsEnabled.ToArray()))
                MessageBox.Show("Der Befehl konnte nicht ausgeführt werden. Entweder ist der Server offline, oder der Token ungültig.");
            {
                tbtnSetup.Enabled = false;
                tbtnRefresh.Enabled = false;
                new System.Threading.Tasks.Task(() => WatchStartThread()).Start();
            }
        }
        private void WatchStartThread()
        {
            DateTime timeout = DateTime.Now + TimeSpan.FromMinutes(5);
            ServerStates state = ServerStates.Unknown;
            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);

                    if (_ExitThreads)
                        throw new ApplicationException("ExitThread requested");

                    if (timeout < DateTime.Now)
                        throw new ApplicationException("Timeout");

                    if (!_ClientHttp.GetServerState(out state))
                        throw new ApplicationException("GetServerState() failed");
                 
                    if ((state != ServerStates.Starting) &&
                        (state != ServerStates.StartingPreLaunch) &&
                        (state != ServerStates.StartingGamerServer) &&
                        (state != ServerStates.StartingPostLaunch))
                        throw new ApplicationException("Start completed");

                    OnStartInProgress(state);
                }
            }
            catch(Exception ex)
            {
                LOG.Debug(ex);
            }

            OnStartFinished(state);
        }
        private void OnStartInProgress(ServerStates state)
        {
            if (InvokeRequired)
                Invoke(new ServerStateDelegate(OnStartInProgress), new object[] { state });
            else
            {
                if (spgbStatus.Value < 10)
                    spgbStatus.Value++;
                else
                    spgbStatus.Value = 1;

                RefreshServerStatus(state);
            }
        }
        private void OnStartFinished(ServerStates state)
        {
            if (InvokeRequired)
                Invoke(new ServerStateDelegate(OnStartFinished), new object[] { state });
            else
            {
                tbtnSetup.Enabled = true;
                tbtnRefresh.Enabled = true;
                spgbStatus.Value = 0;
                RefreshServerStatus(state);
            }
        }

        private void tbtnStop_Click(object sender, EventArgs e)
        {
            tbtnSetup.Enabled = false;
            tbtnRefresh.Enabled = false;
            if (!_ClientHttp.Stop())
                MessageBox.Show("Der Befehl konnte nicht ausgeführt werden. Entweder ist der Server offline, oder der Token ungültig.");
            else
                new System.Threading.Tasks.Task(() => WatchStopThread()).Start();
        }
        private void WatchStopThread()
        {
            DateTime timeout = DateTime.Now + TimeSpan.FromSeconds(30);
            ServerStates state = ServerStates.Unknown;
            try
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);

                    if (_ExitThreads)
                        throw new ApplicationException("ExitThread requested");

                    if (timeout < DateTime.Now)
                        throw new ApplicationException("Timeout");

                    if (!_ClientHttp.GetServerState(out state))
                        throw new ApplicationException("GetServerState() failed");

                    if (state == ServerStates.Stopped) 
                        throw new ApplicationException("Stop completed");

                    OnStopInProgress(state);
                }
            }
            catch (Exception ex)
            {
                LOG.Debug(ex);
            }

            OnStopFinished(state);
        }
        private void OnStopInProgress(ServerStates state)
        {
            if (InvokeRequired)
                Invoke(new ServerStateDelegate(OnStopInProgress), new object[] { state });
            else
            {
                if (spgbStatus.Value < 10)
                    spgbStatus.Value++;
                else
                    spgbStatus.Value = 1;

                RefreshServerStatus(state);
            }
        }
        private void OnStopFinished(ServerStates state)
        {
            if (InvokeRequired)
                Invoke(new ServerStateDelegate(OnStopFinished), new object[] { state });
            else
            {
                tbtnSetup.Enabled = true;
                tbtnRefresh.Enabled = true;
                spgbStatus.Value = 0;
                RefreshServerStatus(state);
            }
        }
    }
}
