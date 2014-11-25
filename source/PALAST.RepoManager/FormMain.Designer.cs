namespace PALAST.RepoManager
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.cmenMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenReSign = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenCopyKey = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSynchronize = new System.Windows.Forms.Button();
            this.btnCompareRepositories = new System.Windows.Forms.Button();
            this.tabControlMode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFtpAddress = new System.Windows.Forms.TextBox();
            this.txtFtpPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFtpUsername = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBrowseLocalRepositoryDirectory = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalRepositoryDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseAddonDirectory = new System.Windows.Forms.Button();
            this.txtAddonDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menReloadAddons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.openDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveDlg = new System.Windows.Forms.SaveFileDialog();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.clstAddons = new PALAST.AddonList();
            this.folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.cmenMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControlMode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmenMain
            // 
            this.cmenMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenReSign,
            this.cmenCopyKey});
            this.cmenMain.Name = "cmenMain";
            this.cmenMain.Size = new System.Drawing.Size(122, 48);
            this.cmenMain.Opening += new System.ComponentModel.CancelEventHandler(this.cmenMain_Opening);
            // 
            // cmenReSign
            // 
            this.cmenReSign.Name = "cmenReSign";
            this.cmenReSign.Size = new System.Drawing.Size(121, 22);
            this.cmenReSign.Text = "re-sign";
            this.cmenReSign.Click += new System.EventHandler(this.cmenReSign_Click);
            // 
            // cmenCopyKey
            // 
            this.cmenCopyKey.Name = "cmenCopyKey";
            this.cmenCopyKey.Size = new System.Drawing.Size(121, 22);
            this.cmenCopyKey.Text = "copy key";
            this.cmenCopyKey.Click += new System.EventHandler(this.cmenCopyKey_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSynchronize);
            this.panel3.Controls.Add(this.btnCompareRepositories);
            this.panel3.Controls.Add(this.tabControlMode);
            this.panel3.Controls.Add(this.btnBrowseAddonDirectory);
            this.panel3.Controls.Add(this.txtAddonDirectory);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 255);
            this.panel3.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(11, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.Location = new System.Drawing.Point(277, 222);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(130, 23);
            this.btnSynchronize.TabIndex = 18;
            this.btnSynchronize.Text = "Synchronisieren";
            this.btnSynchronize.UseVisualStyleBackColor = true;
            this.btnSynchronize.Click += new System.EventHandler(this.btnSynchronize_Click);
            // 
            // btnCompareRepositories
            // 
            this.btnCompareRepositories.Location = new System.Drawing.Point(141, 222);
            this.btnCompareRepositories.Name = "btnCompareRepositories";
            this.btnCompareRepositories.Size = new System.Drawing.Size(130, 23);
            this.btnCompareRepositories.TabIndex = 17;
            this.btnCompareRepositories.Text = "Überprüfen";
            this.btnCompareRepositories.UseVisualStyleBackColor = true;
            this.btnCompareRepositories.Click += new System.EventHandler(this.btnCompareRepositories_Click);
            // 
            // tabControlMode
            // 
            this.tabControlMode.Controls.Add(this.tabPage1);
            this.tabControlMode.Controls.Add(this.tabPage2);
            this.tabControlMode.Location = new System.Drawing.Point(11, 52);
            this.tabControlMode.Name = "tabControlMode";
            this.tabControlMode.SelectedIndex = 0;
            this.tabControlMode.Size = new System.Drawing.Size(396, 164);
            this.tabControlMode.TabIndex = 14;
            this.tabControlMode.SelectedIndexChanged += new System.EventHandler(this.tabControlMode_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtFtpAddress);
            this.tabPage1.Controls.Add(this.txtFtpPassword);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtFtpUsername);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(388, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FTP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "address";
            // 
            // txtFtpAddress
            // 
            this.txtFtpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpAddress.Location = new System.Drawing.Point(13, 24);
            this.txtFtpAddress.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txtFtpAddress.Name = "txtFtpAddress";
            this.txtFtpAddress.Size = new System.Drawing.Size(362, 20);
            this.txtFtpAddress.TabIndex = 8;
            this.txtFtpAddress.TextChanged += new System.EventHandler(this.txtFtpAddress_TextChanged);
            // 
            // txtFtpPassword
            // 
            this.txtFtpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpPassword.Location = new System.Drawing.Point(13, 102);
            this.txtFtpPassword.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtFtpPassword.Name = "txtFtpPassword";
            this.txtFtpPassword.PasswordChar = '*';
            this.txtFtpPassword.Size = new System.Drawing.Size(362, 20);
            this.txtFtpPassword.TabIndex = 12;
            this.txtFtpPassword.TextChanged += new System.EventHandler(this.txtFtpPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "username";
            // 
            // txtFtpUsername
            // 
            this.txtFtpUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFtpUsername.Location = new System.Drawing.Point(13, 63);
            this.txtFtpUsername.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.txtFtpUsername.Name = "txtFtpUsername";
            this.txtFtpUsername.Size = new System.Drawing.Size(362, 20);
            this.txtFtpUsername.TabIndex = 10;
            this.txtFtpUsername.TextChanged += new System.EventHandler(this.txtFtpUsername_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBrowseLocalRepositoryDirectory);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtLocalRepositoryDirectory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(388, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filesystem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnBrowseLocalRepositoryDirectory
            // 
            this.btnBrowseLocalRepositoryDirectory.Location = new System.Drawing.Point(347, 22);
            this.btnBrowseLocalRepositoryDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnBrowseLocalRepositoryDirectory.Name = "btnBrowseLocalRepositoryDirectory";
            this.btnBrowseLocalRepositoryDirectory.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseLocalRepositoryDirectory.TabIndex = 17;
            this.btnBrowseLocalRepositoryDirectory.Text = "...";
            this.btnBrowseLocalRepositoryDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseLocalRepositoryDirectory.Click += new System.EventHandler(this.btnBrowseLocalRepositoryDirectory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "repository directory";
            // 
            // txtLocalRepositoryDirectory
            // 
            this.txtLocalRepositoryDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalRepositoryDirectory.Location = new System.Drawing.Point(13, 24);
            this.txtLocalRepositoryDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtLocalRepositoryDirectory.Name = "txtLocalRepositoryDirectory";
            this.txtLocalRepositoryDirectory.Size = new System.Drawing.Size(326, 20);
            this.txtLocalRepositoryDirectory.TabIndex = 8;
            this.txtLocalRepositoryDirectory.TextChanged += new System.EventHandler(this.txtLocalRepositoryDirectory_TextChanged);
            // 
            // btnBrowseAddonDirectory
            // 
            this.btnBrowseAddonDirectory.Location = new System.Drawing.Point(379, 24);
            this.btnBrowseAddonDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnBrowseAddonDirectory.Name = "btnBrowseAddonDirectory";
            this.btnBrowseAddonDirectory.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseAddonDirectory.TabIndex = 16;
            this.btnBrowseAddonDirectory.Text = "...";
            this.btnBrowseAddonDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseAddonDirectory.Click += new System.EventHandler(this.btnBrowseAddonDirectory_Click);
            // 
            // txtAddonDirectory
            // 
            this.txtAddonDirectory.Location = new System.Drawing.Point(11, 26);
            this.txtAddonDirectory.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtAddonDirectory.Name = "txtAddonDirectory";
            this.txtAddonDirectory.Size = new System.Drawing.Size(360, 20);
            this.txtAddonDirectory.TabIndex = 0;
            this.txtAddonDirectory.TextChanged += new System.EventHandler(this.txtAddonDirectory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "addon directory";
            // 
            // lstLog
            // 
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.IntegralHeight = false;
            this.lstLog.Location = new System.Drawing.Point(0, 279);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(626, 238);
            this.lstLog.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.menInfo});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(626, 24);
            this.mainMenu.TabIndex = 7;
            this.mainMenu.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menNew,
            this.menOpen,
            this.menSave,
            this.menSaveAs,
            this.toolStripMenuItem1,
            this.menReloadAddons,
            this.toolStripMenuItem3,
            this.menExit});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "project";
            // 
            // menNew
            // 
            this.menNew.Name = "menNew";
            this.menNew.Size = new System.Drawing.Size(149, 22);
            this.menNew.Text = "new";
            this.menNew.Click += new System.EventHandler(this.menNew_Click);
            // 
            // menOpen
            // 
            this.menOpen.Name = "menOpen";
            this.menOpen.Size = new System.Drawing.Size(149, 22);
            this.menOpen.Text = "open";
            this.menOpen.Click += new System.EventHandler(this.menOpen_Click);
            // 
            // menSave
            // 
            this.menSave.Enabled = false;
            this.menSave.Name = "menSave";
            this.menSave.Size = new System.Drawing.Size(149, 22);
            this.menSave.Text = "save";
            this.menSave.Click += new System.EventHandler(this.menSave_Click);
            // 
            // menSaveAs
            // 
            this.menSaveAs.Enabled = false;
            this.menSaveAs.Name = "menSaveAs";
            this.menSaveAs.Size = new System.Drawing.Size(149, 22);
            this.menSaveAs.Text = "save as";
            this.menSaveAs.Click += new System.EventHandler(this.menSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // menReloadAddons
            // 
            this.menReloadAddons.Name = "menReloadAddons";
            this.menReloadAddons.Size = new System.Drawing.Size(149, 22);
            this.menReloadAddons.Text = "reload addons";
            this.menReloadAddons.Click += new System.EventHandler(this.menReloadAddons_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(146, 6);
            // 
            // menExit
            // 
            this.menExit.Name = "menExit";
            this.menExit.Size = new System.Drawing.Size(149, 22);
            this.menExit.Text = "exit";
            this.menExit.Click += new System.EventHandler(this.menExit_Click);
            // 
            // menInfo
            // 
            this.menInfo.Name = "menInfo";
            this.menInfo.Size = new System.Drawing.Size(40, 20);
            this.menInfo.Text = "info";
            this.menInfo.Click += new System.EventHandler(this.menInfo_Click);
            // 
            // openDlg
            // 
            this.openDlg.DefaultExt = "*.yaast.proj";
            this.openDlg.Filter = "PALAST Project|*.ppp";
            this.openDlg.SupportMultiDottedExtensions = true;
            // 
            // saveDlg
            // 
            this.saveDlg.DefaultExt = "*.yaast.proj";
            this.saveDlg.Filter = "PALAST Project|*.ppp";
            this.saveDlg.SupportMultiDottedExtensions = true;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.clstAddons);
            this.pnlTop.Controls.Add(this.panel3);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Enabled = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 24);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(626, 255);
            this.pnlTop.TabIndex = 9;
            // 
            // clstAddons
            // 
            this.clstAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clstAddons.ImageChecked = ((System.Drawing.Image)(resources.GetObject("clstAddons.ImageChecked")));
            this.clstAddons.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("clstAddons.ImageUnchecked")));
            this.clstAddons.Location = new System.Drawing.Point(421, 0);
            this.clstAddons.Name = "clstAddons";
            this.clstAddons.SelectedIndex = -1;
            this.clstAddons.Size = new System.Drawing.Size(205, 255);
            this.clstAddons.TabIndex = 16;
            this.clstAddons.CheckedChanged += new System.EventHandler(this.clstAddons_CheckedChanged);
            // 
            // folderDlg
            // 
            this.folderDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 517);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PALAST Server";
            this.cmenMain.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControlMode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddonDirectory;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menNew;
        private System.Windows.Forms.ToolStripMenuItem menOpen;
        private System.Windows.Forms.ToolStripMenuItem menSave;
        private System.Windows.Forms.ToolStripMenuItem menSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFtpPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFtpUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFtpAddress;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBrowseAddonDirectory;
        private System.Windows.Forms.Button btnBrowseLocalRepositoryDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLocalRepositoryDirectory;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.TabControl tabControlMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.FolderBrowserDialog folderDlg;
        private System.Windows.Forms.ToolStripMenuItem menReloadAddons;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menInfo;
        private System.Windows.Forms.ContextMenuStrip cmenMain;
        private System.Windows.Forms.ToolStripMenuItem cmenReSign;
        private System.Windows.Forms.ToolStripMenuItem cmenCopyKey;
        private System.Windows.Forms.Button btnSynchronize;
        private System.Windows.Forms.Button btnCompareRepositories;
        private System.Windows.Forms.Button btnCancel;
        private AddonList clstAddons;
    }
}

