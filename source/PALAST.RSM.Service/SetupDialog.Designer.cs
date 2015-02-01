namespace PALAST.RSM.Service
{
    partial class SetupDialog
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialog));
            this.pnlGameServers = new System.Windows.Forms.Panel();
            this.lstGameServers = new System.Windows.Forms.ListBox();
            this._ToolStripGameServers = new System.Windows.Forms.ToolStrip();
            this.tlblGameservers = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAddGameserver = new System.Windows.Forms.ToolStripButton();
            this.tbtnDeleteGameServer = new System.Windows.Forms.ToolStripButton();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this._ToolStripUsers = new System.Windows.Forms.ToolStrip();
            this.tlblUsers = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAddUser = new System.Windows.Forms.ToolStripButton();
            this.tbtnDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tddRechte = new System.Windows.Forms.ToolStripDropDownButton();
            this.menAllowServerStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menAllowServerStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menAllowMissionUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnToken = new System.Windows.Forms.ToolStripButton();
            this.pnlProcesses = new System.Windows.Forms.Panel();
            this._PostProcessControl = new PALAST.RSM.Service.ProcessXmlControl();
            this._GameserverProcessControl = new PALAST.RSM.Service.ProcessXmlControl();
            this._PreProcessControl = new PALAST.RSM.Service.ProcessXmlControl();
            this.pnlRight = new System.Windows.Forms.Panel();
            this._ToolStripProcesses = new System.Windows.Forms.ToolStrip();
            this.tlblProcess = new System.Windows.Forms.ToolStripLabel();
            this.pnlGameServers.SuspendLayout();
            this._ToolStripGameServers.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this._ToolStripUsers.SuspendLayout();
            this.pnlProcesses.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this._ToolStripProcesses.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameServers
            // 
            this.pnlGameServers.Controls.Add(this.lstGameServers);
            this.pnlGameServers.Controls.Add(this._ToolStripGameServers);
            this.pnlGameServers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGameServers.Location = new System.Drawing.Point(0, 0);
            this.pnlGameServers.Name = "pnlGameServers";
            this.pnlGameServers.Size = new System.Drawing.Size(200, 474);
            this.pnlGameServers.TabIndex = 1;
            // 
            // lstGameServers
            // 
            this.lstGameServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGameServers.FormattingEnabled = true;
            this.lstGameServers.Location = new System.Drawing.Point(0, 25);
            this.lstGameServers.Name = "lstGameServers";
            this.lstGameServers.Size = new System.Drawing.Size(200, 449);
            this.lstGameServers.TabIndex = 2;
            this.lstGameServers.SelectedIndexChanged += new System.EventHandler(this.lstGameServers_SelectedIndexChanged);
            // 
            // _ToolStripGameServers
            // 
            this._ToolStripGameServers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblGameservers,
            this.toolStripSeparator1,
            this.tbtnAddGameserver,
            this.tbtnDeleteGameServer});
            this._ToolStripGameServers.Location = new System.Drawing.Point(0, 0);
            this._ToolStripGameServers.Name = "_ToolStripGameServers";
            this._ToolStripGameServers.Size = new System.Drawing.Size(200, 25);
            this._ToolStripGameServers.TabIndex = 1;
            this._ToolStripGameServers.Text = "toolStrip1";
            // 
            // tlblGameservers
            // 
            this.tlblGameservers.Name = "tlblGameservers";
            this.tlblGameservers.Size = new System.Drawing.Size(69, 22);
            this.tlblGameservers.Text = "Gameserver";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnAddGameserver
            // 
            this.tbtnAddGameserver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddGameserver.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAddGameserver.Image")));
            this.tbtnAddGameserver.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddGameserver.Name = "tbtnAddGameserver";
            this.tbtnAddGameserver.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddGameserver.Text = "Gameserver hinzufügen";
            this.tbtnAddGameserver.Click += new System.EventHandler(this.tbtnAddGameserver_Click);
            // 
            // tbtnDeleteGameServer
            // 
            this.tbtnDeleteGameServer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDeleteGameServer.Enabled = false;
            this.tbtnDeleteGameServer.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeleteGameServer.Image")));
            this.tbtnDeleteGameServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteGameServer.Name = "tbtnDeleteGameServer";
            this.tbtnDeleteGameServer.Size = new System.Drawing.Size(23, 22);
            this.tbtnDeleteGameServer.Text = "Gameserver entfernen";
            this.tbtnDeleteGameServer.Click += new System.EventHandler(this.tbtnDeleteGameserver_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.lstUsers);
            this.pnlCenter.Controls.Add(this._ToolStripUsers);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(200, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(241, 474);
            this.pnlCenter.TabIndex = 2;
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(0, 25);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(241, 449);
            this.lstUsers.TabIndex = 0;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // _ToolStripUsers
            // 
            this._ToolStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblUsers,
            this.toolStripSeparator2,
            this.tbtnAddUser,
            this.tbtnDeleteUser,
            this.toolStripSeparator4,
            this.tddRechte,
            this.toolStripSeparator3,
            this.tbtnToken});
            this._ToolStripUsers.Location = new System.Drawing.Point(0, 0);
            this._ToolStripUsers.Name = "_ToolStripUsers";
            this._ToolStripUsers.Size = new System.Drawing.Size(241, 25);
            this._ToolStripUsers.TabIndex = 2;
            // 
            // tlblUsers
            // 
            this.tlblUsers.Name = "tlblUsers";
            this.tlblUsers.Size = new System.Drawing.Size(53, 22);
            this.tlblUsers.Text = "Benutzer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnAddUser
            // 
            this.tbtnAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAddUser.Image")));
            this.tbtnAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddUser.Name = "tbtnAddUser";
            this.tbtnAddUser.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddUser.Text = "Benutzer hinzufügen";
            this.tbtnAddUser.Click += new System.EventHandler(this.tbtnAddUser_Click);
            // 
            // tbtnDeleteUser
            // 
            this.tbtnDeleteUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDeleteUser.Enabled = false;
            this.tbtnDeleteUser.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeleteUser.Image")));
            this.tbtnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteUser.Name = "tbtnDeleteUser";
            this.tbtnDeleteUser.Size = new System.Drawing.Size(23, 22);
            this.tbtnDeleteUser.Text = "Benutzer entfernen";
            this.tbtnDeleteUser.Click += new System.EventHandler(this.tbtnDeleteUser_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tddRechte
            // 
            this.tddRechte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menAllowServerStart,
            this.menAllowServerStop,
            this.menAllowMissionUpload});
            this.tddRechte.Image = ((System.Drawing.Image)(resources.GetObject("tddRechte.Image")));
            this.tddRechte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tddRechte.Name = "tddRechte";
            this.tddRechte.Size = new System.Drawing.Size(72, 22);
            this.tddRechte.Text = "Rechte";
            // 
            // menAllowServerStart
            // 
            this.menAllowServerStart.Checked = true;
            this.menAllowServerStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menAllowServerStart.Name = "menAllowServerStart";
            this.menAllowServerStart.Size = new System.Drawing.Size(187, 22);
            this.menAllowServerStart.Text = "Server starten";
            this.menAllowServerStart.Click += new System.EventHandler(this.menAllowServerStart_Click);
            // 
            // menAllowServerStop
            // 
            this.menAllowServerStop.Checked = true;
            this.menAllowServerStop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menAllowServerStop.Name = "menAllowServerStop";
            this.menAllowServerStop.Size = new System.Drawing.Size(187, 22);
            this.menAllowServerStop.Text = "Server beenden";
            this.menAllowServerStop.Click += new System.EventHandler(this.menAllowServerStop_Click);
            // 
            // menAllowMissionUpload
            // 
            this.menAllowMissionUpload.Checked = true;
            this.menAllowMissionUpload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menAllowMissionUpload.Name = "menAllowMissionUpload";
            this.menAllowMissionUpload.Size = new System.Drawing.Size(187, 22);
            this.menAllowMissionUpload.Text = "Missionen hochladen";
            this.menAllowMissionUpload.Click += new System.EventHandler(this.menAllowMissionUpload_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnToken
            // 
            this.tbtnToken.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnToken.Enabled = false;
            this.tbtnToken.Image = ((System.Drawing.Image)(resources.GetObject("tbtnToken.Image")));
            this.tbtnToken.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnToken.Name = "tbtnToken";
            this.tbtnToken.Size = new System.Drawing.Size(23, 22);
            this.tbtnToken.Text = "Token";
            this.tbtnToken.Click += new System.EventHandler(this.tbtnToken_Click);
            // 
            // pnlProcesses
            // 
            this.pnlProcesses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProcesses.Controls.Add(this._PostProcessControl);
            this.pnlProcesses.Controls.Add(this._GameserverProcessControl);
            this.pnlProcesses.Controls.Add(this._PreProcessControl);
            this.pnlProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProcesses.Location = new System.Drawing.Point(0, 25);
            this.pnlProcesses.Name = "pnlProcesses";
            this.pnlProcesses.Size = new System.Drawing.Size(500, 449);
            this.pnlProcesses.TabIndex = 1;
            // 
            // _PostProcessControl
            // 
            this._PostProcessControl.Description = "Post-Prozess";
            this._PostProcessControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._PostProcessControl.Location = new System.Drawing.Point(0, 298);
            this._PostProcessControl.Name = "_PostProcessControl";
            this._PostProcessControl.Padding = new System.Windows.Forms.Padding(5);
            this._PostProcessControl.Size = new System.Drawing.Size(498, 149);
            this._PostProcessControl.TabIndex = 2;
            this._PostProcessControl.ConfigurationChanged += new System.EventHandler(this._PostProcessControl_ConfigurationChanged);
            // 
            // _GameserverProcessControl
            // 
            this._GameserverProcessControl.Description = "Server-Prozess";
            this._GameserverProcessControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._GameserverProcessControl.Location = new System.Drawing.Point(0, 149);
            this._GameserverProcessControl.Name = "_GameserverProcessControl";
            this._GameserverProcessControl.Padding = new System.Windows.Forms.Padding(5);
            this._GameserverProcessControl.Size = new System.Drawing.Size(498, 149);
            this._GameserverProcessControl.TabIndex = 1;
            this._GameserverProcessControl.ConfigurationChanged += new System.EventHandler(this._GameserverProcessControl_ConfigurationChanged);
            // 
            // _PreProcessControl
            // 
            this._PreProcessControl.Description = "Pre-Prozess";
            this._PreProcessControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._PreProcessControl.Location = new System.Drawing.Point(0, 0);
            this._PreProcessControl.Name = "_PreProcessControl";
            this._PreProcessControl.Padding = new System.Windows.Forms.Padding(5);
            this._PreProcessControl.Size = new System.Drawing.Size(498, 149);
            this._PreProcessControl.TabIndex = 0;
            this._PreProcessControl.ConfigurationChanged += new System.EventHandler(this._PreProcessControl_ConfigurationChanged);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlProcesses);
            this.pnlRight.Controls.Add(this._ToolStripProcesses);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(441, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(500, 474);
            this.pnlRight.TabIndex = 3;
            // 
            // _ToolStripProcesses
            // 
            this._ToolStripProcesses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlblProcess});
            this._ToolStripProcesses.Location = new System.Drawing.Point(0, 0);
            this._ToolStripProcesses.Name = "_ToolStripProcesses";
            this._ToolStripProcesses.Size = new System.Drawing.Size(500, 25);
            this._ToolStripProcesses.TabIndex = 8;
            this._ToolStripProcesses.Text = "toolStrip1";
            // 
            // tlblProcess
            // 
            this.tlblProcess.Name = "tlblProcess";
            this.tlblProcess.Size = new System.Drawing.Size(52, 22);
            this.tlblProcess.Text = "Prozesse";
            // 
            // SetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 474);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlGameServers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(957, 512);
            this.Name = "SetupDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetupDialog";
            this.pnlGameServers.ResumeLayout(false);
            this.pnlGameServers.PerformLayout();
            this._ToolStripGameServers.ResumeLayout(false);
            this._ToolStripGameServers.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this._ToolStripUsers.ResumeLayout(false);
            this._ToolStripUsers.PerformLayout();
            this.pnlProcesses.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this._ToolStripProcesses.ResumeLayout(false);
            this._ToolStripProcesses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameServers;
        private System.Windows.Forms.ListBox lstGameServers;
        private System.Windows.Forms.ToolStrip _ToolStripGameServers;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlProcesses;
        private System.Windows.Forms.ToolStrip _ToolStripUsers;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ToolStrip _ToolStripProcesses;
        private System.Windows.Forms.ToolStripLabel tlblProcess;
        private System.Windows.Forms.ToolStripLabel tlblUsers;
        private System.Windows.Forms.ToolStripButton tbtnAddGameserver;
        private System.Windows.Forms.ToolStripButton tbtnDeleteGameServer;
        private ProcessXmlControl _PostProcessControl;
        private ProcessXmlControl _GameserverProcessControl;
        private ProcessXmlControl _PreProcessControl;
        private System.Windows.Forms.ToolStripLabel tlblGameservers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnAddUser;
        private System.Windows.Forms.ToolStripButton tbtnDeleteUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnToken;
        private System.Windows.Forms.ToolStripDropDownButton tddRechte;
        private System.Windows.Forms.ToolStripMenuItem menAllowMissionUpload;
        private System.Windows.Forms.ToolStripMenuItem menAllowServerStart;
        private System.Windows.Forms.ToolStripMenuItem menAllowServerStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

    }
}