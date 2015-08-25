namespace PALAST
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
            this.chbShowScriptErrors = new System.Windows.Forms.CheckBox();
            this.chbNoPause = new System.Windows.Forms.CheckBox();
            this.chbExThreads = new System.Windows.Forms.CheckBox();
            this.chbNoFilePatching = new System.Windows.Forms.CheckBox();
            this.chbNoSpalsh = new System.Windows.Forms.CheckBox();
            this.chbNoLogs = new System.Windows.Forms.CheckBox();
            this.chbCpuCount = new System.Windows.Forms.CheckBox();
            this.chbMaxMem = new System.Windows.Forms.CheckBox();
            this.chbMaxVRAM = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPasswort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.grpAutoConnect = new System.Windows.Forms.GroupBox();
            this.btnInfoAutoConnect = new System.Windows.Forms.Button();
            this.chbAutoConnectEnabled = new System.Windows.Forms.CheckBox();
            this.grpDeveloperOptions = new System.Windows.Forms.GroupBox();
            this.btnInfoCheckSignatures = new System.Windows.Forms.Button();
            this.btnInfoNoFilePatching = new System.Windows.Forms.Button();
            this.btnInfoShowScriptErrors = new System.Windows.Forms.Button();
            this.chbCheckSignatures = new System.Windows.Forms.CheckBox();
            this.btnInfoNoPause = new System.Windows.Forms.Button();
            this.grpProfileOptions = new System.Windows.Forms.GroupBox();
            this.btnInfoName = new System.Windows.Forms.Button();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.grpPerformance = new System.Windows.Forms.GroupBox();
            this.btnInfoNoLogs = new System.Windows.Forms.Button();
            this.btnInfoExThreads = new System.Windows.Forms.Button();
            this.btnInfoCpuCount = new System.Windows.Forms.Button();
            this.btnInfoNoCB = new System.Windows.Forms.Button();
            this.btnInfoWinXP = new System.Windows.Forms.Button();
            this.btnInfoMaxVRAM = new System.Windows.Forms.Button();
            this.btnInfoMaxMem = new System.Windows.Forms.Button();
            this.cmbExThreads = new System.Windows.Forms.ComboBox();
            this.cmbCpuCount = new System.Windows.Forms.ComboBox();
            this.numMaxMem = new System.Windows.Forms.NumericUpDown();
            this.numMaxVRAM = new System.Windows.Forms.NumericUpDown();
            this.chbWinXP = new System.Windows.Forms.CheckBox();
            this.chbNoCB = new System.Windows.Forms.CheckBox();
            this.grpGameLoadingSpeedup = new System.Windows.Forms.GroupBox();
            this.btnInfoUseBE = new System.Windows.Forms.Button();
            this.chbUseBE = new System.Windows.Forms.CheckBox();
            this.btnInfoSkipIntro = new System.Windows.Forms.Button();
            this.btnInfoWorldEmpty = new System.Windows.Forms.Button();
            this.btnInfoNoSplash = new System.Windows.Forms.Button();
            this.chbWorldEmpty = new System.Windows.Forms.CheckBox();
            this.chbSkipIntro = new System.Windows.Forms.CheckBox();
            this._ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lstPreset = new System.Windows.Forms.ListBox();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.grpExternAddonDirectory = new System.Windows.Forms.GroupBox();
            this.btnBrowseExternAddonDirectory = new System.Windows.Forms.Button();
            this.txtExternAddonDirectory = new System.Windows.Forms.TextBox();
            this.grpAdditionalParameters = new System.Windows.Forms.GroupBox();
            this.txtAdditionalParameter = new System.Windows.Forms.TextBox();
            this._ToolStripAddons = new System.Windows.Forms.ToolStrip();
            this.tbtnLaunch = new System.Windows.Forms.ToolStripButton();
            this.tbtnParameter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnTFAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDeleteAddon = new System.Windows.Forms.ToolStripButton();
            this.tbtnUpdateAddons = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._ToolStripPreset = new System.Windows.Forms.ToolStrip();
            this.tbtnRSM = new System.Windows.Forms.ToolStripButton();
            this.tbtnServerInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbtnServer = new System.Windows.Forms.ToolStripDropDownButton();
            this.menServerNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menServerEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menServerClone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menServerRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.clstAddons = new PALAST.AddonList();
            this.pnlSplitterCenterTop = new System.Windows.Forms.Panel();
            this.pnlSplitterLeft = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSplitterRight = new System.Windows.Forms.Panel();
            this._ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.tbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnExtended = new System.Windows.Forms.ToolStripDropDownButton();
            this.menLogfile = new System.Windows.Forms.ToolStripMenuItem();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.grpAutoConnect.SuspendLayout();
            this.grpDeveloperOptions.SuspendLayout();
            this.grpProfileOptions.SuspendLayout();
            this.grpPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).BeginInit();
            this.grpGameLoadingSpeedup.SuspendLayout();
            this.pnlParameter.SuspendLayout();
            this.grpExternAddonDirectory.SuspendLayout();
            this.grpAdditionalParameters.SuspendLayout();
            this._ToolStripAddons.SuspendLayout();
            this._ToolStripPreset.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this._ToolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbShowScriptErrors
            // 
            this.chbShowScriptErrors.AutoSize = true;
            this.chbShowScriptErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbShowScriptErrors.Location = new System.Drawing.Point(6, 42);
            this.chbShowScriptErrors.Name = "chbShowScriptErrors";
            this.chbShowScriptErrors.Size = new System.Drawing.Size(108, 17);
            this.chbShowScriptErrors.TabIndex = 1;
            this.chbShowScriptErrors.Text = "-showScriptErrors";
            this.chbShowScriptErrors.UseVisualStyleBackColor = true;
            this.chbShowScriptErrors.CheckedChanged += new System.EventHandler(this.chbShowScriptErrors_CheckedChanged);
            // 
            // chbNoPause
            // 
            this.chbNoPause.AutoSize = true;
            this.chbNoPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbNoPause.Location = new System.Drawing.Point(6, 19);
            this.chbNoPause.Name = "chbNoPause";
            this.chbNoPause.Size = new System.Drawing.Size(71, 17);
            this.chbNoPause.TabIndex = 0;
            this.chbNoPause.Text = "-noPause";
            this.chbNoPause.UseVisualStyleBackColor = true;
            this.chbNoPause.CheckedChanged += new System.EventHandler(this.chbNoPause_CheckedChanged);
            // 
            // chbExThreads
            // 
            this.chbExThreads.AutoSize = true;
            this.chbExThreads.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbExThreads.Location = new System.Drawing.Point(6, 134);
            this.chbExThreads.Name = "chbExThreads";
            this.chbExThreads.Size = new System.Drawing.Size(79, 17);
            this.chbExThreads.TabIndex = 8;
            this.chbExThreads.Text = "-exThreads";
            this.chbExThreads.UseVisualStyleBackColor = true;
            this.chbExThreads.CheckedChanged += new System.EventHandler(this.chbExThreads_CheckedChanged);
            // 
            // chbNoFilePatching
            // 
            this.chbNoFilePatching.AutoSize = true;
            this.chbNoFilePatching.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbNoFilePatching.Location = new System.Drawing.Point(6, 65);
            this.chbNoFilePatching.Name = "chbNoFilePatching";
            this.chbNoFilePatching.Size = new System.Drawing.Size(99, 17);
            this.chbNoFilePatching.TabIndex = 2;
            this.chbNoFilePatching.Text = "-noFilePatching";
            this.chbNoFilePatching.UseVisualStyleBackColor = true;
            this.chbNoFilePatching.CheckedChanged += new System.EventHandler(this.chbNoFilePatching_CheckedChanged);
            // 
            // chbNoSpalsh
            // 
            this.chbNoSpalsh.AutoSize = true;
            this.chbNoSpalsh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbNoSpalsh.Location = new System.Drawing.Point(6, 19);
            this.chbNoSpalsh.Name = "chbNoSpalsh";
            this.chbNoSpalsh.Size = new System.Drawing.Size(73, 17);
            this.chbNoSpalsh.TabIndex = 0;
            this.chbNoSpalsh.Text = "-noSplash";
            this.chbNoSpalsh.UseVisualStyleBackColor = true;
            this.chbNoSpalsh.CheckedChanged += new System.EventHandler(this.chbNoSpalsh_CheckedChanged);
            // 
            // chbNoLogs
            // 
            this.chbNoLogs.AutoSize = true;
            this.chbNoLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbNoLogs.Location = new System.Drawing.Point(6, 157);
            this.chbNoLogs.Name = "chbNoLogs";
            this.chbNoLogs.Size = new System.Drawing.Size(64, 17);
            this.chbNoLogs.TabIndex = 10;
            this.chbNoLogs.Text = "-noLogs";
            this.chbNoLogs.UseVisualStyleBackColor = true;
            this.chbNoLogs.CheckedChanged += new System.EventHandler(this.chbNoLogs_CheckedChanged);
            // 
            // chbCpuCount
            // 
            this.chbCpuCount.AutoSize = true;
            this.chbCpuCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbCpuCount.Location = new System.Drawing.Point(6, 111);
            this.chbCpuCount.Name = "chbCpuCount";
            this.chbCpuCount.Size = new System.Drawing.Size(75, 17);
            this.chbCpuCount.TabIndex = 6;
            this.chbCpuCount.Text = "-cpuCount";
            this.chbCpuCount.UseVisualStyleBackColor = true;
            this.chbCpuCount.CheckedChanged += new System.EventHandler(this.chbCpuCount_CheckedChanged);
            // 
            // chbMaxMem
            // 
            this.chbMaxMem.AutoSize = true;
            this.chbMaxMem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbMaxMem.Location = new System.Drawing.Point(6, 19);
            this.chbMaxMem.Name = "chbMaxMem";
            this.chbMaxMem.Size = new System.Drawing.Size(71, 17);
            this.chbMaxMem.TabIndex = 0;
            this.chbMaxMem.Text = "-maxMem";
            this.chbMaxMem.UseVisualStyleBackColor = true;
            this.chbMaxMem.CheckedChanged += new System.EventHandler(this.chbMaxMem_CheckedChanged);
            // 
            // chbMaxVRAM
            // 
            this.chbMaxVRAM.AutoSize = true;
            this.chbMaxVRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbMaxVRAM.Location = new System.Drawing.Point(6, 42);
            this.chbMaxVRAM.Name = "chbMaxVRAM";
            this.chbMaxVRAM.Size = new System.Drawing.Size(79, 17);
            this.chbMaxVRAM.TabIndex = 2;
            this.chbMaxVRAM.Text = "-maxVRAM";
            this.chbMaxVRAM.UseVisualStyleBackColor = true;
            this.chbMaxVRAM.CheckedChanged += new System.EventHandler(this.chbMaxVRAM_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbName.Location = new System.Drawing.Point(6, 19);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(55, 17);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "-name";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(84, 33);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(172, 20);
            this.txtServer.TabIndex = 2;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(84, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(172, 20);
            this.txtPort.TabIndex = 4;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswort.Enabled = false;
            this.txtPasswort.Location = new System.Drawing.Point(84, 77);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(172, 20);
            this.txtPasswort.TabIndex = 6;
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(6, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Passwort";
            // 
            // grpAutoConnect
            // 
            this.grpAutoConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAutoConnect.Controls.Add(this.btnInfoAutoConnect);
            this.grpAutoConnect.Controls.Add(this.chbAutoConnectEnabled);
            this.grpAutoConnect.Controls.Add(this.label1);
            this.grpAutoConnect.Controls.Add(this.txtServer);
            this.grpAutoConnect.Controls.Add(this.txtPort);
            this.grpAutoConnect.Controls.Add(this.lblPassword);
            this.grpAutoConnect.Controls.Add(this.txtPasswort);
            this.grpAutoConnect.Controls.Add(this.label2);
            this.grpAutoConnect.Location = new System.Drawing.Point(7, 5);
            this.grpAutoConnect.Margin = new System.Windows.Forms.Padding(5);
            this.grpAutoConnect.Name = "grpAutoConnect";
            this.grpAutoConnect.Size = new System.Drawing.Size(288, 105);
            this.grpAutoConnect.TabIndex = 0;
            this.grpAutoConnect.TabStop = false;
            this.grpAutoConnect.Text = "Automatisch verbinden";
            // 
            // btnInfoAutoConnect
            // 
            this.btnInfoAutoConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoAutoConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoAutoConnect.Image")));
            this.btnInfoAutoConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoAutoConnect.Location = new System.Drawing.Point(266, 13);
            this.btnInfoAutoConnect.Name = "btnInfoAutoConnect";
            this.btnInfoAutoConnect.Size = new System.Drawing.Size(16, 16);
            this.btnInfoAutoConnect.TabIndex = 42;
            this.btnInfoAutoConnect.Tag = "-autoConnect";
            this._ToolTip.SetToolTip(this.btnInfoAutoConnect, "Infos");
            this.btnInfoAutoConnect.UseVisualStyleBackColor = true;
            this.btnInfoAutoConnect.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbAutoConnectEnabled
            // 
            this.chbAutoConnectEnabled.AutoSize = true;
            this.chbAutoConnectEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbAutoConnectEnabled.Location = new System.Drawing.Point(6, 19);
            this.chbAutoConnectEnabled.Name = "chbAutoConnectEnabled";
            this.chbAutoConnectEnabled.Size = new System.Drawing.Size(63, 17);
            this.chbAutoConnectEnabled.TabIndex = 0;
            this.chbAutoConnectEnabled.Text = "aktiviert";
            this.chbAutoConnectEnabled.UseVisualStyleBackColor = true;
            this.chbAutoConnectEnabled.CheckedChanged += new System.EventHandler(this.chbAutoConnectEnabled_CheckedChanged);
            // 
            // grpDeveloperOptions
            // 
            this.grpDeveloperOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDeveloperOptions.Controls.Add(this.btnInfoCheckSignatures);
            this.grpDeveloperOptions.Controls.Add(this.chbNoPause);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoNoFilePatching);
            this.grpDeveloperOptions.Controls.Add(this.chbShowScriptErrors);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoShowScriptErrors);
            this.grpDeveloperOptions.Controls.Add(this.chbCheckSignatures);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoNoPause);
            this.grpDeveloperOptions.Controls.Add(this.chbNoFilePatching);
            this.grpDeveloperOptions.Location = new System.Drawing.Point(7, 484);
            this.grpDeveloperOptions.Margin = new System.Windows.Forms.Padding(5);
            this.grpDeveloperOptions.Name = "grpDeveloperOptions";
            this.grpDeveloperOptions.Size = new System.Drawing.Size(288, 111);
            this.grpDeveloperOptions.TabIndex = 4;
            this.grpDeveloperOptions.TabStop = false;
            this.grpDeveloperOptions.Text = "Entwickler Optionen";
            // 
            // btnInfoCheckSignatures
            // 
            this.btnInfoCheckSignatures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoCheckSignatures.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoCheckSignatures.Image")));
            this.btnInfoCheckSignatures.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoCheckSignatures.Location = new System.Drawing.Point(266, 87);
            this.btnInfoCheckSignatures.Name = "btnInfoCheckSignatures";
            this.btnInfoCheckSignatures.Size = new System.Drawing.Size(16, 16);
            this.btnInfoCheckSignatures.TabIndex = 45;
            this.btnInfoCheckSignatures.Tag = "-checkSignatures";
            this._ToolTip.SetToolTip(this.btnInfoCheckSignatures, "Infos");
            this.btnInfoCheckSignatures.UseVisualStyleBackColor = true;
            this.btnInfoCheckSignatures.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoFilePatching
            // 
            this.btnInfoNoFilePatching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNoFilePatching.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoNoFilePatching.Image")));
            this.btnInfoNoFilePatching.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoFilePatching.Location = new System.Drawing.Point(266, 64);
            this.btnInfoNoFilePatching.Name = "btnInfoNoFilePatching";
            this.btnInfoNoFilePatching.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoFilePatching.TabIndex = 44;
            this.btnInfoNoFilePatching.Tag = "-noFilePatching";
            this._ToolTip.SetToolTip(this.btnInfoNoFilePatching, "Infos");
            this.btnInfoNoFilePatching.UseVisualStyleBackColor = true;
            this.btnInfoNoFilePatching.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoShowScriptErrors
            // 
            this.btnInfoShowScriptErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoShowScriptErrors.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoShowScriptErrors.Image")));
            this.btnInfoShowScriptErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoShowScriptErrors.Location = new System.Drawing.Point(266, 41);
            this.btnInfoShowScriptErrors.Name = "btnInfoShowScriptErrors";
            this.btnInfoShowScriptErrors.Size = new System.Drawing.Size(16, 16);
            this.btnInfoShowScriptErrors.TabIndex = 43;
            this.btnInfoShowScriptErrors.Tag = "-showScriptErrors";
            this._ToolTip.SetToolTip(this.btnInfoShowScriptErrors, "Infos");
            this.btnInfoShowScriptErrors.UseVisualStyleBackColor = true;
            this.btnInfoShowScriptErrors.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbCheckSignatures
            // 
            this.chbCheckSignatures.AutoSize = true;
            this.chbCheckSignatures.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbCheckSignatures.Location = new System.Drawing.Point(6, 88);
            this.chbCheckSignatures.Name = "chbCheckSignatures";
            this.chbCheckSignatures.Size = new System.Drawing.Size(109, 17);
            this.chbCheckSignatures.TabIndex = 3;
            this.chbCheckSignatures.Text = "-checkSignatures";
            this.chbCheckSignatures.UseVisualStyleBackColor = true;
            this.chbCheckSignatures.CheckedChanged += new System.EventHandler(this.chbCheckSignatures_CheckedChanged);
            // 
            // btnInfoNoPause
            // 
            this.btnInfoNoPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNoPause.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoNoPause.Image")));
            this.btnInfoNoPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoPause.Location = new System.Drawing.Point(266, 18);
            this.btnInfoNoPause.Name = "btnInfoNoPause";
            this.btnInfoNoPause.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoPause.TabIndex = 42;
            this.btnInfoNoPause.Tag = "-noPause";
            this._ToolTip.SetToolTip(this.btnInfoNoPause, "Infos");
            this.btnInfoNoPause.UseVisualStyleBackColor = true;
            this.btnInfoNoPause.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // grpProfileOptions
            // 
            this.grpProfileOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProfileOptions.Controls.Add(this.btnInfoName);
            this.grpProfileOptions.Controls.Add(this.cmbName);
            this.grpProfileOptions.Controls.Add(this.chbName);
            this.grpProfileOptions.Location = new System.Drawing.Point(7, 429);
            this.grpProfileOptions.Margin = new System.Windows.Forms.Padding(5);
            this.grpProfileOptions.Name = "grpProfileOptions";
            this.grpProfileOptions.Size = new System.Drawing.Size(288, 45);
            this.grpProfileOptions.TabIndex = 3;
            this.grpProfileOptions.TabStop = false;
            this.grpProfileOptions.Text = "Profil Optionen";
            // 
            // btnInfoName
            // 
            this.btnInfoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoName.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoName.Image")));
            this.btnInfoName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoName.Location = new System.Drawing.Point(266, 19);
            this.btnInfoName.Name = "btnInfoName";
            this.btnInfoName.Size = new System.Drawing.Size(16, 16);
            this.btnInfoName.TabIndex = 21;
            this.btnInfoName.Tag = "-name";
            this._ToolTip.SetToolTip(this.btnInfoName, "Infos");
            this.btnInfoName.UseVisualStyleBackColor = true;
            this.btnInfoName.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbName
            // 
            this.cmbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbName.Enabled = false;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(87, 17);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(172, 21);
            this.cmbName.TabIndex = 1;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // grpPerformance
            // 
            this.grpPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPerformance.Controls.Add(this.btnInfoNoLogs);
            this.grpPerformance.Controls.Add(this.btnInfoExThreads);
            this.grpPerformance.Controls.Add(this.btnInfoCpuCount);
            this.grpPerformance.Controls.Add(this.btnInfoNoCB);
            this.grpPerformance.Controls.Add(this.btnInfoWinXP);
            this.grpPerformance.Controls.Add(this.btnInfoMaxVRAM);
            this.grpPerformance.Controls.Add(this.btnInfoMaxMem);
            this.grpPerformance.Controls.Add(this.cmbExThreads);
            this.grpPerformance.Controls.Add(this.cmbCpuCount);
            this.grpPerformance.Controls.Add(this.numMaxMem);
            this.grpPerformance.Controls.Add(this.numMaxVRAM);
            this.grpPerformance.Controls.Add(this.chbCpuCount);
            this.grpPerformance.Controls.Add(this.chbMaxMem);
            this.grpPerformance.Controls.Add(this.chbNoLogs);
            this.grpPerformance.Controls.Add(this.chbMaxVRAM);
            this.grpPerformance.Controls.Add(this.chbWinXP);
            this.grpPerformance.Controls.Add(this.chbExThreads);
            this.grpPerformance.Controls.Add(this.chbNoCB);
            this.grpPerformance.Location = new System.Drawing.Point(7, 240);
            this.grpPerformance.Margin = new System.Windows.Forms.Padding(5);
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.Size = new System.Drawing.Size(288, 179);
            this.grpPerformance.TabIndex = 2;
            this.grpPerformance.TabStop = false;
            this.grpPerformance.Text = "Leistung";
            // 
            // btnInfoNoLogs
            // 
            this.btnInfoNoLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNoLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoNoLogs.Image")));
            this.btnInfoNoLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoLogs.Location = new System.Drawing.Point(265, 156);
            this.btnInfoNoLogs.Name = "btnInfoNoLogs";
            this.btnInfoNoLogs.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoLogs.TabIndex = 41;
            this.btnInfoNoLogs.Tag = "-noLogs";
            this._ToolTip.SetToolTip(this.btnInfoNoLogs, "Infos");
            this.btnInfoNoLogs.UseVisualStyleBackColor = true;
            this.btnInfoNoLogs.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoExThreads
            // 
            this.btnInfoExThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoExThreads.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoExThreads.Image")));
            this.btnInfoExThreads.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoExThreads.Location = new System.Drawing.Point(265, 133);
            this.btnInfoExThreads.Name = "btnInfoExThreads";
            this.btnInfoExThreads.Size = new System.Drawing.Size(16, 16);
            this.btnInfoExThreads.TabIndex = 40;
            this.btnInfoExThreads.Tag = "-exThreads";
            this._ToolTip.SetToolTip(this.btnInfoExThreads, "Infos");
            this.btnInfoExThreads.UseVisualStyleBackColor = true;
            this.btnInfoExThreads.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoCpuCount
            // 
            this.btnInfoCpuCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoCpuCount.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoCpuCount.Image")));
            this.btnInfoCpuCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoCpuCount.Location = new System.Drawing.Point(265, 110);
            this.btnInfoCpuCount.Name = "btnInfoCpuCount";
            this.btnInfoCpuCount.Size = new System.Drawing.Size(16, 16);
            this.btnInfoCpuCount.TabIndex = 39;
            this.btnInfoCpuCount.Tag = "-cpuCount";
            this._ToolTip.SetToolTip(this.btnInfoCpuCount, "Infos");
            this.btnInfoCpuCount.UseVisualStyleBackColor = true;
            this.btnInfoCpuCount.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoCB
            // 
            this.btnInfoNoCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNoCB.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoNoCB.Image")));
            this.btnInfoNoCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoCB.Location = new System.Drawing.Point(265, 87);
            this.btnInfoNoCB.Name = "btnInfoNoCB";
            this.btnInfoNoCB.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoCB.TabIndex = 38;
            this.btnInfoNoCB.Tag = "-noCB";
            this._ToolTip.SetToolTip(this.btnInfoNoCB, "Infos");
            this.btnInfoNoCB.UseVisualStyleBackColor = true;
            this.btnInfoNoCB.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWinXP
            // 
            this.btnInfoWinXP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoWinXP.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoWinXP.Image")));
            this.btnInfoWinXP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoWinXP.Location = new System.Drawing.Point(265, 64);
            this.btnInfoWinXP.Name = "btnInfoWinXP";
            this.btnInfoWinXP.Size = new System.Drawing.Size(16, 16);
            this.btnInfoWinXP.TabIndex = 28;
            this.btnInfoWinXP.Tag = "-winXP";
            this._ToolTip.SetToolTip(this.btnInfoWinXP, "Infos");
            this.btnInfoWinXP.UseVisualStyleBackColor = true;
            this.btnInfoWinXP.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxVRAM
            // 
            this.btnInfoMaxVRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoMaxVRAM.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoMaxVRAM.Image")));
            this.btnInfoMaxVRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoMaxVRAM.Location = new System.Drawing.Point(265, 41);
            this.btnInfoMaxVRAM.Name = "btnInfoMaxVRAM";
            this.btnInfoMaxVRAM.Size = new System.Drawing.Size(16, 16);
            this.btnInfoMaxVRAM.TabIndex = 27;
            this.btnInfoMaxVRAM.Tag = "-maxVRAM";
            this._ToolTip.SetToolTip(this.btnInfoMaxVRAM, "Infos");
            this.btnInfoMaxVRAM.UseVisualStyleBackColor = true;
            this.btnInfoMaxVRAM.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxMem
            // 
            this.btnInfoMaxMem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoMaxMem.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoMaxMem.Image")));
            this.btnInfoMaxMem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoMaxMem.Location = new System.Drawing.Point(265, 18);
            this.btnInfoMaxMem.Name = "btnInfoMaxMem";
            this.btnInfoMaxMem.Size = new System.Drawing.Size(16, 16);
            this.btnInfoMaxMem.TabIndex = 26;
            this.btnInfoMaxMem.Tag = "-maxMem";
            this._ToolTip.SetToolTip(this.btnInfoMaxMem, "Infos");
            this.btnInfoMaxMem.UseVisualStyleBackColor = true;
            this.btnInfoMaxMem.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbExThreads
            // 
            this.cmbExThreads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbExThreads.Enabled = false;
            this.cmbExThreads.FormattingEnabled = true;
            this.cmbExThreads.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "5",
            "7"});
            this.cmbExThreads.Location = new System.Drawing.Point(87, 132);
            this.cmbExThreads.Name = "cmbExThreads";
            this.cmbExThreads.Size = new System.Drawing.Size(172, 21);
            this.cmbExThreads.TabIndex = 9;
            this.cmbExThreads.SelectedIndexChanged += new System.EventHandler(this.cmbExThreads_SelectedIndexChanged);
            // 
            // cmbCpuCount
            // 
            this.cmbCpuCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCpuCount.Enabled = false;
            this.cmbCpuCount.FormattingEnabled = true;
            this.cmbCpuCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmbCpuCount.Location = new System.Drawing.Point(87, 109);
            this.cmbCpuCount.Name = "cmbCpuCount";
            this.cmbCpuCount.Size = new System.Drawing.Size(172, 21);
            this.cmbCpuCount.TabIndex = 7;
            this.cmbCpuCount.SelectedIndexChanged += new System.EventHandler(this.cmbCpuCount_SelectedIndexChanged);
            // 
            // numMaxMem
            // 
            this.numMaxMem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxMem.Enabled = false;
            this.numMaxMem.Location = new System.Drawing.Point(87, 18);
            this.numMaxMem.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.numMaxMem.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMaxMem.Name = "numMaxMem";
            this.numMaxMem.Size = new System.Drawing.Size(172, 20);
            this.numMaxMem.TabIndex = 1;
            this.numMaxMem.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.numMaxMem.ValueChanged += new System.EventHandler(this.numMaxMem_ValueChanged);
            // 
            // numMaxVRAM
            // 
            this.numMaxVRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMaxVRAM.Enabled = false;
            this.numMaxVRAM.Location = new System.Drawing.Point(87, 41);
            this.numMaxVRAM.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.numMaxVRAM.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numMaxVRAM.Name = "numMaxVRAM";
            this.numMaxVRAM.Size = new System.Drawing.Size(172, 20);
            this.numMaxVRAM.TabIndex = 3;
            this.numMaxVRAM.Value = new decimal(new int[] {
            2047,
            0,
            0,
            0});
            this.numMaxVRAM.ValueChanged += new System.EventHandler(this.numMaxVRAM_ValueChanged);
            // 
            // chbWinXP
            // 
            this.chbWinXP.AutoSize = true;
            this.chbWinXP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbWinXP.Location = new System.Drawing.Point(6, 65);
            this.chbWinXP.Name = "chbWinXP";
            this.chbWinXP.Size = new System.Drawing.Size(59, 17);
            this.chbWinXP.TabIndex = 4;
            this.chbWinXP.Text = "-winXP";
            this.chbWinXP.UseVisualStyleBackColor = true;
            this.chbWinXP.CheckedChanged += new System.EventHandler(this.chbWinXP_CheckedChanged);
            // 
            // chbNoCB
            // 
            this.chbNoCB.AutoSize = true;
            this.chbNoCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbNoCB.Location = new System.Drawing.Point(6, 88);
            this.chbNoCB.Name = "chbNoCB";
            this.chbNoCB.Size = new System.Drawing.Size(55, 17);
            this.chbNoCB.TabIndex = 5;
            this.chbNoCB.Text = "-noCB";
            this.chbNoCB.UseVisualStyleBackColor = true;
            this.chbNoCB.CheckedChanged += new System.EventHandler(this.chbNoCB_CheckedChanged);
            // 
            // grpGameLoadingSpeedup
            // 
            this.grpGameLoadingSpeedup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGameLoadingSpeedup.BackColor = System.Drawing.SystemColors.Control;
            this.grpGameLoadingSpeedup.Controls.Add(this.btnInfoUseBE);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbUseBE);
            this.grpGameLoadingSpeedup.Controls.Add(this.btnInfoSkipIntro);
            this.grpGameLoadingSpeedup.Controls.Add(this.btnInfoWorldEmpty);
            this.grpGameLoadingSpeedup.Controls.Add(this.btnInfoNoSplash);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbNoSpalsh);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbWorldEmpty);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbSkipIntro);
            this.grpGameLoadingSpeedup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grpGameLoadingSpeedup.Location = new System.Drawing.Point(7, 120);
            this.grpGameLoadingSpeedup.Margin = new System.Windows.Forms.Padding(5);
            this.grpGameLoadingSpeedup.Name = "grpGameLoadingSpeedup";
            this.grpGameLoadingSpeedup.Size = new System.Drawing.Size(288, 110);
            this.grpGameLoadingSpeedup.TabIndex = 1;
            this.grpGameLoadingSpeedup.TabStop = false;
            this.grpGameLoadingSpeedup.Text = "Spielstartbeschleunigung";
            // 
            // btnInfoUseBE
            // 
            this.btnInfoUseBE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoUseBE.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoUseBE.Image")));
            this.btnInfoUseBE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoUseBE.Location = new System.Drawing.Point(265, 87);
            this.btnInfoUseBE.Name = "btnInfoUseBE";
            this.btnInfoUseBE.Size = new System.Drawing.Size(16, 16);
            this.btnInfoUseBE.TabIndex = 24;
            this.btnInfoUseBE.Tag = "-useBE";
            this._ToolTip.SetToolTip(this.btnInfoUseBE, "Infos");
            this.btnInfoUseBE.UseVisualStyleBackColor = true;
            this.btnInfoUseBE.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbUseBE
            // 
            this.chbUseBE.AutoSize = true;
            this.chbUseBE.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbUseBE.Location = new System.Drawing.Point(6, 88);
            this.chbUseBE.Name = "chbUseBE";
            this.chbUseBE.Size = new System.Drawing.Size(60, 17);
            this.chbUseBE.TabIndex = 23;
            this.chbUseBE.Text = "-useBE";
            this.chbUseBE.UseVisualStyleBackColor = true;
            this.chbUseBE.CheckedChanged += new System.EventHandler(this.chbUseBE_CheckedChanged);
            // 
            // btnInfoSkipIntro
            // 
            this.btnInfoSkipIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoSkipIntro.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoSkipIntro.Image")));
            this.btnInfoSkipIntro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoSkipIntro.Location = new System.Drawing.Point(265, 64);
            this.btnInfoSkipIntro.Name = "btnInfoSkipIntro";
            this.btnInfoSkipIntro.Size = new System.Drawing.Size(16, 16);
            this.btnInfoSkipIntro.TabIndex = 22;
            this.btnInfoSkipIntro.Tag = "-skipIntro";
            this._ToolTip.SetToolTip(this.btnInfoSkipIntro, "Infos");
            this.btnInfoSkipIntro.UseVisualStyleBackColor = true;
            this.btnInfoSkipIntro.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWorldEmpty
            // 
            this.btnInfoWorldEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoWorldEmpty.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoWorldEmpty.Image")));
            this.btnInfoWorldEmpty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoWorldEmpty.Location = new System.Drawing.Point(265, 41);
            this.btnInfoWorldEmpty.Name = "btnInfoWorldEmpty";
            this.btnInfoWorldEmpty.Size = new System.Drawing.Size(16, 16);
            this.btnInfoWorldEmpty.TabIndex = 21;
            this.btnInfoWorldEmpty.Tag = "-worldEmtpy";
            this._ToolTip.SetToolTip(this.btnInfoWorldEmpty, "Infos");
            this.btnInfoWorldEmpty.UseVisualStyleBackColor = true;
            this.btnInfoWorldEmpty.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoSplash
            // 
            this.btnInfoNoSplash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoNoSplash.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoNoSplash.Image")));
            this.btnInfoNoSplash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoSplash.Location = new System.Drawing.Point(265, 18);
            this.btnInfoNoSplash.Name = "btnInfoNoSplash";
            this.btnInfoNoSplash.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoSplash.TabIndex = 20;
            this.btnInfoNoSplash.Tag = "-noSplash";
            this._ToolTip.SetToolTip(this.btnInfoNoSplash, "Infos");
            this.btnInfoNoSplash.UseVisualStyleBackColor = true;
            this.btnInfoNoSplash.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbWorldEmpty
            // 
            this.chbWorldEmpty.AutoSize = true;
            this.chbWorldEmpty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbWorldEmpty.Location = new System.Drawing.Point(6, 42);
            this.chbWorldEmpty.Name = "chbWorldEmpty";
            this.chbWorldEmpty.Size = new System.Drawing.Size(88, 17);
            this.chbWorldEmpty.TabIndex = 1;
            this.chbWorldEmpty.Text = "-world=empty";
            this.chbWorldEmpty.UseVisualStyleBackColor = true;
            this.chbWorldEmpty.CheckedChanged += new System.EventHandler(this.chbWorldEmpty_CheckedChanged);
            // 
            // chbSkipIntro
            // 
            this.chbSkipIntro.AutoSize = true;
            this.chbSkipIntro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbSkipIntro.Location = new System.Drawing.Point(6, 65);
            this.chbSkipIntro.Name = "chbSkipIntro";
            this.chbSkipIntro.Size = new System.Drawing.Size(69, 17);
            this.chbSkipIntro.TabIndex = 2;
            this.chbSkipIntro.Text = "-skipIntro";
            this.chbSkipIntro.UseVisualStyleBackColor = true;
            this.chbSkipIntro.CheckedChanged += new System.EventHandler(this.chbSkipIntro_CheckedChanged);
            // 
            // lstPreset
            // 
            this.lstPreset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.IntegralHeight = false;
            this.lstPreset.Location = new System.Drawing.Point(0, 39);
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.Size = new System.Drawing.Size(198, 675);
            this.lstPreset.TabIndex = 2;
            this.lstPreset.SelectedIndexChanged += new System.EventHandler(this.lstPreset_SelectedIndexChanged);
            // 
            // pnlParameter
            // 
            this.pnlParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParameter.Controls.Add(this.grpExternAddonDirectory);
            this.pnlParameter.Controls.Add(this.grpAdditionalParameters);
            this.pnlParameter.Controls.Add(this.grpAutoConnect);
            this.pnlParameter.Controls.Add(this.grpDeveloperOptions);
            this.pnlParameter.Controls.Add(this.grpGameLoadingSpeedup);
            this.pnlParameter.Controls.Add(this.grpProfileOptions);
            this.pnlParameter.Controls.Add(this.grpPerformance);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParameter.Location = new System.Drawing.Point(456, 0);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(304, 716);
            this.pnlParameter.TabIndex = 2;
            // 
            // grpExternAddonDirectory
            // 
            this.grpExternAddonDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExternAddonDirectory.Controls.Add(this.btnBrowseExternAddonDirectory);
            this.grpExternAddonDirectory.Controls.Add(this.txtExternAddonDirectory);
            this.grpExternAddonDirectory.Location = new System.Drawing.Point(7, 660);
            this.grpExternAddonDirectory.Margin = new System.Windows.Forms.Padding(5);
            this.grpExternAddonDirectory.Name = "grpExternAddonDirectory";
            this.grpExternAddonDirectory.Size = new System.Drawing.Size(288, 47);
            this.grpExternAddonDirectory.TabIndex = 38;
            this.grpExternAddonDirectory.TabStop = false;
            this.grpExternAddonDirectory.Text = "Externes Addonverzeichnis";
            // 
            // btnBrowseExternAddonDirectory
            // 
            this.btnBrowseExternAddonDirectory.Location = new System.Drawing.Point(255, 17);
            this.btnBrowseExternAddonDirectory.Name = "btnBrowseExternAddonDirectory";
            this.btnBrowseExternAddonDirectory.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseExternAddonDirectory.TabIndex = 1;
            this.btnBrowseExternAddonDirectory.Text = "...";
            this.btnBrowseExternAddonDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseExternAddonDirectory.Click += new System.EventHandler(this.btnBrowseExternAddonDirectory_Click);
            // 
            // txtExternAddonDirectory
            // 
            this.txtExternAddonDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExternAddonDirectory.Location = new System.Drawing.Point(9, 19);
            this.txtExternAddonDirectory.Name = "txtExternAddonDirectory";
            this.txtExternAddonDirectory.Size = new System.Drawing.Size(240, 20);
            this.txtExternAddonDirectory.TabIndex = 0;
            this.txtExternAddonDirectory.TextChanged += new System.EventHandler(this.txtExternAddonDirectory_TextChanged);
            // 
            // grpAdditionalParameters
            // 
            this.grpAdditionalParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAdditionalParameters.Controls.Add(this.txtAdditionalParameter);
            this.grpAdditionalParameters.Location = new System.Drawing.Point(7, 604);
            this.grpAdditionalParameters.Margin = new System.Windows.Forms.Padding(5);
            this.grpAdditionalParameters.Name = "grpAdditionalParameters";
            this.grpAdditionalParameters.Size = new System.Drawing.Size(288, 46);
            this.grpAdditionalParameters.TabIndex = 37;
            this.grpAdditionalParameters.TabStop = false;
            this.grpAdditionalParameters.Text = "Zusätzliche Parameter";
            // 
            // txtAdditionalParameter
            // 
            this.txtAdditionalParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdditionalParameter.Location = new System.Drawing.Point(6, 19);
            this.txtAdditionalParameter.Name = "txtAdditionalParameter";
            this.txtAdditionalParameter.Size = new System.Drawing.Size(276, 20);
            this.txtAdditionalParameter.TabIndex = 0;
            this.txtAdditionalParameter.TextChanged += new System.EventHandler(this.txtAdditionalParameter_TextChanged);
            // 
            // _ToolStripAddons
            // 
            this._ToolStripAddons.CanOverflow = false;
            this._ToolStripAddons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._ToolStripAddons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnLaunch,
            this.tbtnParameter,
            this.toolStripSeparator5,
            this.tbtnTFAR,
            this.toolStripSeparator3,
            this.tbtnDeleteAddon,
            this.tbtnUpdateAddons,
            this.toolStripSeparator4});
            this._ToolStripAddons.Location = new System.Drawing.Point(0, 0);
            this._ToolStripAddons.Name = "_ToolStripAddons";
            this._ToolStripAddons.Size = new System.Drawing.Size(248, 38);
            this._ToolStripAddons.TabIndex = 0;
            this._ToolStripAddons.Text = "toolStrip3";
            // 
            // tbtnLaunch
            // 
            this.tbtnLaunch.Enabled = false;
            this.tbtnLaunch.ForeColor = System.Drawing.Color.Red;
            this.tbtnLaunch.Image = ((System.Drawing.Image)(resources.GetObject("tbtnLaunch.Image")));
            this.tbtnLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLaunch.Name = "tbtnLaunch";
            this.tbtnLaunch.Size = new System.Drawing.Size(48, 35);
            this.tbtnLaunch.Text = "Starten";
            this.tbtnLaunch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnLaunch.ToolTipText = "Spiel starten";
            this.tbtnLaunch.Click += new System.EventHandler(this.tbtnLaunch_Click);
            // 
            // tbtnParameter
            // 
            this.tbtnParameter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnParameter.Image = ((System.Drawing.Image)(resources.GetObject("tbtnParameter.Image")));
            this.tbtnParameter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnParameter.Name = "tbtnParameter";
            this.tbtnParameter.Size = new System.Drawing.Size(50, 35);
            this.tbtnParameter.Text = "Params";
            this.tbtnParameter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnParameter.ToolTipText = "Parameter auf-/zuklappen";
            this.tbtnParameter.Click += new System.EventHandler(this.tbtnParameter_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // tbtnTFAR
            // 
            this.tbtnTFAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnTFAR.Enabled = false;
            this.tbtnTFAR.Image = ((System.Drawing.Image)(resources.GetObject("tbtnTFAR.Image")));
            this.tbtnTFAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnTFAR.Name = "tbtnTFAR";
            this.tbtnTFAR.Size = new System.Drawing.Size(39, 35);
            this.tbtnTFAR.Text = "TFAR";
            this.tbtnTFAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnTFAR.ToolTipText = "TFAR Setup - Zum Ausführen, das TFAR Addon auswählen.";
            this.tbtnTFAR.Click += new System.EventHandler(this.tbtnTFAR_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tbtnDeleteAddon
            // 
            this.tbtnDeleteAddon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnDeleteAddon.Enabled = false;
            this.tbtnDeleteAddon.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeleteAddon.Image")));
            this.tbtnDeleteAddon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteAddon.Name = "tbtnDeleteAddon";
            this.tbtnDeleteAddon.Size = new System.Drawing.Size(55, 35);
            this.tbtnDeleteAddon.Text = "Löschen";
            this.tbtnDeleteAddon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnDeleteAddon.ToolTipText = "Addon löschen";
            this.tbtnDeleteAddon.Click += new System.EventHandler(this.tbtnDeleteAddon_Click);
            // 
            // tbtnUpdateAddons
            // 
            this.tbtnUpdateAddons.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnUpdateAddons.Enabled = false;
            this.tbtnUpdateAddons.Image = ((System.Drawing.Image)(resources.GetObject("tbtnUpdateAddons.Image")));
            this.tbtnUpdateAddons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUpdateAddons.Name = "tbtnUpdateAddons";
            this.tbtnUpdateAddons.Size = new System.Drawing.Size(36, 35);
            this.tbtnUpdateAddons.Text = "Sync";
            this.tbtnUpdateAddons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnUpdateAddons.ToolTipText = "Addons synchronisieren";
            this.tbtnUpdateAddons.Click += new System.EventHandler(this.tbtnUpdateAddons_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // _ToolStripPreset
            // 
            this._ToolStripPreset.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._ToolStripPreset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnRSM,
            this.tbtnServerInfo,
            this.toolStripSeparator6,
            this.ddbtnServer,
            this.toolStripSeparator1});
            this._ToolStripPreset.Location = new System.Drawing.Point(0, 0);
            this._ToolStripPreset.Name = "_ToolStripPreset";
            this._ToolStripPreset.Size = new System.Drawing.Size(198, 38);
            this._ToolStripPreset.TabIndex = 1;
            this._ToolStripPreset.Text = "toolStrip2";
            // 
            // tbtnRSM
            // 
            this.tbtnRSM.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnRSM.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRSM.Image")));
            this.tbtnRSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRSM.Name = "tbtnRSM";
            this.tbtnRSM.Size = new System.Drawing.Size(35, 35);
            this.tbtnRSM.Text = "RSM";
            this.tbtnRSM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnRSM.Click += new System.EventHandler(this.tbtnRSM_Click);
            // 
            // tbtnServerInfo
            // 
            this.tbtnServerInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnServerInfo.Image = ((System.Drawing.Image)(resources.GetObject("tbtnServerInfo.Image")));
            this.tbtnServerInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnServerInfo.Name = "tbtnServerInfo";
            this.tbtnServerInfo.Size = new System.Drawing.Size(32, 35);
            this.tbtnServerInfo.Text = "Info";
            this.tbtnServerInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnServerInfo.Click += new System.EventHandler(this.tbtnServerInfo_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // ddbtnServer
            // 
            this.ddbtnServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menServerNeu,
            this.menServerEdit,
            this.menServerClone,
            this.toolStripMenuItem1,
            this.menServerRemove});
            this.ddbtnServer.Image = ((System.Drawing.Image)(resources.GetObject("ddbtnServer.Image")));
            this.ddbtnServer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbtnServer.Name = "ddbtnServer";
            this.ddbtnServer.Size = new System.Drawing.Size(52, 35);
            this.ddbtnServer.Text = "Server";
            this.ddbtnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menServerNeu
            // 
            this.menServerNeu.Image = ((System.Drawing.Image)(resources.GetObject("menServerNeu.Image")));
            this.menServerNeu.Name = "menServerNeu";
            this.menServerNeu.Size = new System.Drawing.Size(130, 22);
            this.menServerNeu.Text = "Neu";
            this.menServerNeu.Click += new System.EventHandler(this.menServerNeu_Click);
            // 
            // menServerEdit
            // 
            this.menServerEdit.Image = ((System.Drawing.Image)(resources.GetObject("menServerEdit.Image")));
            this.menServerEdit.Name = "menServerEdit";
            this.menServerEdit.Size = new System.Drawing.Size(130, 22);
            this.menServerEdit.Text = "Bearbeiten";
            this.menServerEdit.Click += new System.EventHandler(this.menServerEdit_Click);
            // 
            // menServerClone
            // 
            this.menServerClone.Image = ((System.Drawing.Image)(resources.GetObject("menServerClone.Image")));
            this.menServerClone.Name = "menServerClone";
            this.menServerClone.Size = new System.Drawing.Size(130, 22);
            this.menServerClone.Text = "Kopieren";
            this.menServerClone.Click += new System.EventHandler(this.menServerClone_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // menServerRemove
            // 
            this.menServerRemove.Image = ((System.Drawing.Image)(resources.GetObject("menServerRemove.Image")));
            this.menServerRemove.Name = "menServerRemove";
            this.menServerRemove.Size = new System.Drawing.Size(130, 22);
            this.menServerRemove.Text = "Löschen";
            this.menServerRemove.Click += new System.EventHandler(this.menServerRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlCenter);
            this.pnlMain.Controls.Add(this.pnlSplitterLeft);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlSplitterRight);
            this.pnlMain.Controls.Add(this.pnlParameter);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 25);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(760, 716);
            this.pnlMain.TabIndex = 36;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCenter.Controls.Add(this.clstAddons);
            this.pnlCenter.Controls.Add(this.pnlSplitterCenterTop);
            this.pnlCenter.Controls.Add(this._ToolStripAddons);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCenter.Location = new System.Drawing.Point(203, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(250, 716);
            this.pnlCenter.TabIndex = 0;
            // 
            // clstAddons
            // 
            this.clstAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clstAddons.ImageChecked = ((System.Drawing.Image)(resources.GetObject("clstAddons.ImageChecked")));
            this.clstAddons.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("clstAddons.ImageUnchecked")));
            this.clstAddons.Location = new System.Drawing.Point(0, 39);
            this.clstAddons.Name = "clstAddons";
            this.clstAddons.SelectedIndex = -1;
            this.clstAddons.Size = new System.Drawing.Size(248, 675);
            this.clstAddons.TabIndex = 1;
            this.clstAddons.CheckedChanged += new System.EventHandler(this.clstAddons_CheckedChanged);
            this.clstAddons.SelectedIndexChanged += new System.EventHandler(this.clstAddons_SelectedIndexChanged);
            // 
            // pnlSplitterCenterTop
            // 
            this.pnlSplitterCenterTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSplitterCenterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSplitterCenterTop.Location = new System.Drawing.Point(0, 38);
            this.pnlSplitterCenterTop.Name = "pnlSplitterCenterTop";
            this.pnlSplitterCenterTop.Size = new System.Drawing.Size(248, 1);
            this.pnlSplitterCenterTop.TabIndex = 38;
            // 
            // pnlSplitterLeft
            // 
            this.pnlSplitterLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSplitterLeft.Location = new System.Drawing.Point(200, 0);
            this.pnlSplitterLeft.Name = "pnlSplitterLeft";
            this.pnlSplitterLeft.Size = new System.Drawing.Size(3, 716);
            this.pnlSplitterLeft.TabIndex = 34;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.lstPreset);
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this._ToolStripPreset);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 716);
            this.pnlLeft.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 1);
            this.panel1.TabIndex = 40;
            // 
            // pnlSplitterRight
            // 
            this.pnlSplitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSplitterRight.Location = new System.Drawing.Point(453, 0);
            this.pnlSplitterRight.Name = "pnlSplitterRight";
            this.pnlSplitterRight.Size = new System.Drawing.Size(3, 716);
            this.pnlSplitterRight.TabIndex = 36;
            // 
            // _ToolStripTop
            // 
            this._ToolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInfo,
            this.tbtnSettings,
            this.toolStripSeparator2,
            this.tbtnExtended});
            this._ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this._ToolStripTop.Name = "_ToolStripTop";
            this._ToolStripTop.Size = new System.Drawing.Size(760, 25);
            this._ToolStripTop.TabIndex = 1;
            this._ToolStripTop.Text = "toolStrip2";
            // 
            // tbtnInfo
            // 
            this.tbtnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tbtnInfo.Image")));
            this.tbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInfo.Name = "tbtnInfo";
            this.tbtnInfo.Size = new System.Drawing.Size(23, 22);
            this.tbtnInfo.Text = "Informationen";
            this.tbtnInfo.Click += new System.EventHandler(this.tbtnInfo_Click);
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSettings.Image")));
            this.tbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Size = new System.Drawing.Size(98, 22);
            this.tbtnSettings.Text = "Einstellungen";
            this.tbtnSettings.Click += new System.EventHandler(this.tbtnSettings_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnExtended
            // 
            this.tbtnExtended.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menLogfile});
            this.tbtnExtended.Image = ((System.Drawing.Image)(resources.GetObject("tbtnExtended.Image")));
            this.tbtnExtended.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExtended.Name = "tbtnExtended";
            this.tbtnExtended.Size = new System.Drawing.Size(66, 22);
            this.tbtnExtended.Text = "Extras";
            // 
            // menLogfile
            // 
            this.menLogfile.Image = ((System.Drawing.Image)(resources.GetObject("menLogfile.Image")));
            this.menLogfile.Name = "menLogfile";
            this.menLogfile.Size = new System.Drawing.Size(170, 22);
            this.menLogfile.Text = "Logdatei anzeigen";
            this.menLogfile.Click += new System.EventHandler(this.menLogfile_Click);
            // 
            // timerBlink
            // 
            this.timerBlink.Enabled = true;
            this.timerBlink.Interval = 1000;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 741);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this._ToolStripTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(776, 779);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(469, 779);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PALAST (Pixingers Arma Launcher and Sync Tool)";
            this.grpAutoConnect.ResumeLayout(false);
            this.grpAutoConnect.PerformLayout();
            this.grpDeveloperOptions.ResumeLayout(false);
            this.grpDeveloperOptions.PerformLayout();
            this.grpProfileOptions.ResumeLayout(false);
            this.grpProfileOptions.PerformLayout();
            this.grpPerformance.ResumeLayout(false);
            this.grpPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).EndInit();
            this.grpGameLoadingSpeedup.ResumeLayout(false);
            this.grpGameLoadingSpeedup.PerformLayout();
            this.pnlParameter.ResumeLayout(false);
            this.grpExternAddonDirectory.ResumeLayout(false);
            this.grpExternAddonDirectory.PerformLayout();
            this.grpAdditionalParameters.ResumeLayout(false);
            this.grpAdditionalParameters.PerformLayout();
            this._ToolStripAddons.ResumeLayout(false);
            this._ToolStripAddons.PerformLayout();
            this._ToolStripPreset.ResumeLayout(false);
            this._ToolStripPreset.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlCenter.ResumeLayout(false);
            this.pnlCenter.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this._ToolStripTop.ResumeLayout(false);
            this._ToolStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbShowScriptErrors;
        private System.Windows.Forms.CheckBox chbNoPause;
        private System.Windows.Forms.CheckBox chbExThreads;
        private System.Windows.Forms.CheckBox chbNoFilePatching;
        private System.Windows.Forms.CheckBox chbNoSpalsh;
        private System.Windows.Forms.CheckBox chbNoLogs;
        private System.Windows.Forms.CheckBox chbCpuCount;
        private System.Windows.Forms.CheckBox chbMaxMem;
        private System.Windows.Forms.CheckBox chbMaxVRAM;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPasswort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox grpAutoConnect;
        private System.Windows.Forms.CheckBox chbSkipIntro;
        private System.Windows.Forms.CheckBox chbWorldEmpty;
        private System.Windows.Forms.CheckBox chbCheckSignatures;
        private System.Windows.Forms.CheckBox chbNoCB;
        private System.Windows.Forms.CheckBox chbWinXP;
        private System.Windows.Forms.GroupBox grpDeveloperOptions;
        private System.Windows.Forms.GroupBox grpProfileOptions;
        private System.Windows.Forms.GroupBox grpPerformance;
        private System.Windows.Forms.GroupBox grpGameLoadingSpeedup;
        private System.Windows.Forms.NumericUpDown numMaxVRAM;
        private System.Windows.Forms.NumericUpDown numMaxMem;
        private System.Windows.Forms.ComboBox cmbExThreads;
        private System.Windows.Forms.ComboBox cmbCpuCount;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.CheckBox chbAutoConnectEnabled;
        private System.Windows.Forms.ToolTip _ToolTip;
        private System.Windows.Forms.Button btnInfoNoSplash;
        private System.Windows.Forms.Button btnInfoSkipIntro;
        private System.Windows.Forms.Button btnInfoWorldEmpty;
        private System.Windows.Forms.Button btnInfoAutoConnect;
        private System.Windows.Forms.Button btnInfoCheckSignatures;
        private System.Windows.Forms.Button btnInfoNoFilePatching;
        private System.Windows.Forms.Button btnInfoShowScriptErrors;
        private System.Windows.Forms.Button btnInfoNoPause;
        private System.Windows.Forms.Button btnInfoName;
        private System.Windows.Forms.Button btnInfoNoLogs;
        private System.Windows.Forms.Button btnInfoExThreads;
        private System.Windows.Forms.Button btnInfoCpuCount;
        private System.Windows.Forms.Button btnInfoNoCB;
        private System.Windows.Forms.Button btnInfoWinXP;
        private System.Windows.Forms.Button btnInfoMaxVRAM;
        private System.Windows.Forms.Button btnInfoMaxMem;
        private System.Windows.Forms.ListBox lstPreset;
        private System.Windows.Forms.Panel pnlParameter;
        private System.Windows.Forms.GroupBox grpAdditionalParameters;
        private System.Windows.Forms.TextBox txtAdditionalParameter;
        private System.Windows.Forms.ToolStrip _ToolStripAddons;
        private System.Windows.Forms.ToolStripButton tbtnLaunch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnUpdateAddons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip _ToolStripPreset;
        private System.Windows.Forms.ToolStripButton tbtnTFAR;
        private AddonList clstAddons;
        private System.Windows.Forms.ToolStripButton tbtnDeleteAddon;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Panel pnlSplitterRight;
        private System.Windows.Forms.Panel pnlSplitterLeft;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlSplitterCenterTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip _ToolStripTop;
        private System.Windows.Forms.ToolStripButton tbtnInfo;
        private System.Windows.Forms.ToolStripButton tbtnSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tbtnExtended;
        private System.Windows.Forms.ToolStripMenuItem menLogfile;
        private System.Windows.Forms.ToolStripButton tbtnParameter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tbtnRSM;
        private System.Windows.Forms.ToolStripButton tbtnServerInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton ddbtnServer;
        private System.Windows.Forms.ToolStripMenuItem menServerNeu;
        private System.Windows.Forms.ToolStripMenuItem menServerEdit;
        private System.Windows.Forms.ToolStripMenuItem menServerClone;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menServerRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.GroupBox grpExternAddonDirectory;
        private System.Windows.Forms.Button btnBrowseExternAddonDirectory;
        private System.Windows.Forms.TextBox txtExternAddonDirectory;
        private System.Windows.Forms.Button btnInfoUseBE;
        private System.Windows.Forms.CheckBox chbUseBE;
    }
}

