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
            this.clstAddons = new System.Windows.Forms.CheckedListBox();
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
            this.btnInfoSkipIntro = new System.Windows.Forms.Button();
            this.btnInfoWorldEmpty = new System.Windows.Forms.Button();
            this.btnInfoNoSplash = new System.Windows.Forms.Button();
            this.chbWorldEmpty = new System.Windows.Forms.CheckBox();
            this.chbSkipIntro = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lstPreset = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlParameter = new System.Windows.Forms.Panel();
            this.grpAdditionalParameters = new System.Windows.Forms.GroupBox();
            this.txtAdditionalParameter = new System.Windows.Forms.TextBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tbtnLaunch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnUpdateAddons = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbtnAddPreset = new System.Windows.Forms.ToolStripButton();
            this.tbtnEditPreset = new System.Windows.Forms.ToolStripButton();
            this.tbtnClonePreset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnDeletePreset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.grpAutoConnect.SuspendLayout();
            this.grpDeveloperOptions.SuspendLayout();
            this.grpProfileOptions.SuspendLayout();
            this.grpPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).BeginInit();
            this.grpGameLoadingSpeedup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlParameter.SuspendLayout();
            this.grpAdditionalParameters.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clstAddons
            // 
            this.clstAddons.CheckOnClick = true;
            this.clstAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clstAddons.FormattingEnabled = true;
            this.clstAddons.IntegralHeight = false;
            this.clstAddons.Location = new System.Drawing.Point(0, 25);
            this.clstAddons.Name = "clstAddons";
            this.clstAddons.Size = new System.Drawing.Size(219, 643);
            this.clstAddons.TabIndex = 3;
            this.clstAddons.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstAddons_ItemCheck);
            // 
            // chbShowScriptErrors
            // 
            this.chbShowScriptErrors.AutoSize = true;
            this.chbShowScriptErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbShowScriptErrors.Location = new System.Drawing.Point(6, 42);
            this.chbShowScriptErrors.Name = "chbShowScriptErrors";
            this.chbShowScriptErrors.Size = new System.Drawing.Size(108, 17);
            this.chbShowScriptErrors.TabIndex = 4;
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
            this.chbNoPause.TabIndex = 5;
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
            this.chbExThreads.TabIndex = 6;
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
            this.chbNoFilePatching.TabIndex = 7;
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
            this.chbNoSpalsh.TabIndex = 9;
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
            this.chbNoLogs.TabIndex = 11;
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
            this.chbCpuCount.TabIndex = 12;
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
            this.chbMaxMem.TabIndex = 13;
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
            this.chbMaxVRAM.TabIndex = 14;
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
            this.chbName.TabIndex = 15;
            this.chbName.Text = "-name";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Enabled = false;
            this.txtServer.Location = new System.Drawing.Point(84, 33);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(95, 20);
            this.txtServer.TabIndex = 20;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(84, 55);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(95, 20);
            this.txtPort.TabIndex = 21;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Enabled = false;
            this.txtPasswort.Location = new System.Drawing.Point(84, 77);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(95, 20);
            this.txtPasswort.TabIndex = 22;
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(6, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Passwort";
            // 
            // grpAutoConnect
            // 
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
            this.grpAutoConnect.Size = new System.Drawing.Size(211, 105);
            this.grpAutoConnect.TabIndex = 30;
            this.grpAutoConnect.TabStop = false;
            this.grpAutoConnect.Text = "Automatisch verbinden";
            // 
            // btnInfoAutoConnect
            // 
            this.btnInfoAutoConnect.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoAutoConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoAutoConnect.Location = new System.Drawing.Point(189, 13);
            this.btnInfoAutoConnect.Name = "btnInfoAutoConnect";
            this.btnInfoAutoConnect.Size = new System.Drawing.Size(16, 16);
            this.btnInfoAutoConnect.TabIndex = 42;
            this.btnInfoAutoConnect.Tag = "-autoConnect";
            this.toolTip1.SetToolTip(this.btnInfoAutoConnect, "Infos");
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
            this.chbAutoConnectEnabled.TabIndex = 27;
            this.chbAutoConnectEnabled.Text = "aktiviert";
            this.chbAutoConnectEnabled.UseVisualStyleBackColor = true;
            this.chbAutoConnectEnabled.CheckedChanged += new System.EventHandler(this.chbAutoConnectEnabled_CheckedChanged);
            // 
            // grpDeveloperOptions
            // 
            this.grpDeveloperOptions.Controls.Add(this.btnInfoCheckSignatures);
            this.grpDeveloperOptions.Controls.Add(this.chbNoPause);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoNoFilePatching);
            this.grpDeveloperOptions.Controls.Add(this.chbShowScriptErrors);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoShowScriptErrors);
            this.grpDeveloperOptions.Controls.Add(this.chbCheckSignatures);
            this.grpDeveloperOptions.Controls.Add(this.btnInfoNoPause);
            this.grpDeveloperOptions.Controls.Add(this.chbNoFilePatching);
            this.grpDeveloperOptions.Location = new System.Drawing.Point(7, 462);
            this.grpDeveloperOptions.Margin = new System.Windows.Forms.Padding(5);
            this.grpDeveloperOptions.Name = "grpDeveloperOptions";
            this.grpDeveloperOptions.Size = new System.Drawing.Size(211, 111);
            this.grpDeveloperOptions.TabIndex = 36;
            this.grpDeveloperOptions.TabStop = false;
            this.grpDeveloperOptions.Text = "Entwickler Optionen";
            // 
            // btnInfoCheckSignatures
            // 
            this.btnInfoCheckSignatures.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoCheckSignatures.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoCheckSignatures.Location = new System.Drawing.Point(189, 87);
            this.btnInfoCheckSignatures.Name = "btnInfoCheckSignatures";
            this.btnInfoCheckSignatures.Size = new System.Drawing.Size(16, 16);
            this.btnInfoCheckSignatures.TabIndex = 45;
            this.btnInfoCheckSignatures.Tag = "-checkSignatures";
            this.toolTip1.SetToolTip(this.btnInfoCheckSignatures, "Infos");
            this.btnInfoCheckSignatures.UseVisualStyleBackColor = true;
            this.btnInfoCheckSignatures.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoFilePatching
            // 
            this.btnInfoNoFilePatching.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoNoFilePatching.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoFilePatching.Location = new System.Drawing.Point(189, 64);
            this.btnInfoNoFilePatching.Name = "btnInfoNoFilePatching";
            this.btnInfoNoFilePatching.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoFilePatching.TabIndex = 44;
            this.btnInfoNoFilePatching.Tag = "-noFilePatching";
            this.toolTip1.SetToolTip(this.btnInfoNoFilePatching, "Infos");
            this.btnInfoNoFilePatching.UseVisualStyleBackColor = true;
            this.btnInfoNoFilePatching.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoShowScriptErrors
            // 
            this.btnInfoShowScriptErrors.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoShowScriptErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoShowScriptErrors.Location = new System.Drawing.Point(189, 41);
            this.btnInfoShowScriptErrors.Name = "btnInfoShowScriptErrors";
            this.btnInfoShowScriptErrors.Size = new System.Drawing.Size(16, 16);
            this.btnInfoShowScriptErrors.TabIndex = 43;
            this.btnInfoShowScriptErrors.Tag = "-showScriptErrors";
            this.toolTip1.SetToolTip(this.btnInfoShowScriptErrors, "Infos");
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
            this.chbCheckSignatures.TabIndex = 23;
            this.chbCheckSignatures.Text = "-checkSignatures";
            this.chbCheckSignatures.UseVisualStyleBackColor = true;
            this.chbCheckSignatures.CheckedChanged += new System.EventHandler(this.chbCheckSignatures_CheckedChanged);
            // 
            // btnInfoNoPause
            // 
            this.btnInfoNoPause.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoNoPause.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoPause.Location = new System.Drawing.Point(189, 18);
            this.btnInfoNoPause.Name = "btnInfoNoPause";
            this.btnInfoNoPause.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoPause.TabIndex = 42;
            this.btnInfoNoPause.Tag = "-noPause";
            this.toolTip1.SetToolTip(this.btnInfoNoPause, "Infos");
            this.btnInfoNoPause.UseVisualStyleBackColor = true;
            this.btnInfoNoPause.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // grpProfileOptions
            // 
            this.grpProfileOptions.Controls.Add(this.btnInfoName);
            this.grpProfileOptions.Controls.Add(this.cmbName);
            this.grpProfileOptions.Controls.Add(this.chbName);
            this.grpProfileOptions.Location = new System.Drawing.Point(7, 407);
            this.grpProfileOptions.Margin = new System.Windows.Forms.Padding(5);
            this.grpProfileOptions.Name = "grpProfileOptions";
            this.grpProfileOptions.Size = new System.Drawing.Size(211, 45);
            this.grpProfileOptions.TabIndex = 35;
            this.grpProfileOptions.TabStop = false;
            this.grpProfileOptions.Text = "Profil Optionen";
            // 
            // btnInfoName
            // 
            this.btnInfoName.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoName.Location = new System.Drawing.Point(189, 19);
            this.btnInfoName.Name = "btnInfoName";
            this.btnInfoName.Size = new System.Drawing.Size(16, 16);
            this.btnInfoName.TabIndex = 21;
            this.btnInfoName.Tag = "-name";
            this.toolTip1.SetToolTip(this.btnInfoName, "Infos");
            this.btnInfoName.UseVisualStyleBackColor = true;
            this.btnInfoName.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbName
            // 
            this.cmbName.Enabled = false;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(87, 17);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(95, 21);
            this.cmbName.TabIndex = 17;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // grpPerformance
            // 
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
            this.grpPerformance.Location = new System.Drawing.Point(7, 218);
            this.grpPerformance.Margin = new System.Windows.Forms.Padding(5);
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.Size = new System.Drawing.Size(211, 179);
            this.grpPerformance.TabIndex = 34;
            this.grpPerformance.TabStop = false;
            this.grpPerformance.Text = "Leistung";
            // 
            // btnInfoNoLogs
            // 
            this.btnInfoNoLogs.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoNoLogs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoLogs.Location = new System.Drawing.Point(188, 156);
            this.btnInfoNoLogs.Name = "btnInfoNoLogs";
            this.btnInfoNoLogs.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoLogs.TabIndex = 41;
            this.btnInfoNoLogs.Tag = "-noLogs";
            this.toolTip1.SetToolTip(this.btnInfoNoLogs, "Infos");
            this.btnInfoNoLogs.UseVisualStyleBackColor = true;
            this.btnInfoNoLogs.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoExThreads
            // 
            this.btnInfoExThreads.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoExThreads.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoExThreads.Location = new System.Drawing.Point(188, 133);
            this.btnInfoExThreads.Name = "btnInfoExThreads";
            this.btnInfoExThreads.Size = new System.Drawing.Size(16, 16);
            this.btnInfoExThreads.TabIndex = 40;
            this.btnInfoExThreads.Tag = "-exThreads";
            this.toolTip1.SetToolTip(this.btnInfoExThreads, "Infos");
            this.btnInfoExThreads.UseVisualStyleBackColor = true;
            this.btnInfoExThreads.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoCpuCount
            // 
            this.btnInfoCpuCount.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoCpuCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoCpuCount.Location = new System.Drawing.Point(188, 110);
            this.btnInfoCpuCount.Name = "btnInfoCpuCount";
            this.btnInfoCpuCount.Size = new System.Drawing.Size(16, 16);
            this.btnInfoCpuCount.TabIndex = 39;
            this.btnInfoCpuCount.Tag = "-cpuCount";
            this.toolTip1.SetToolTip(this.btnInfoCpuCount, "Infos");
            this.btnInfoCpuCount.UseVisualStyleBackColor = true;
            this.btnInfoCpuCount.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoCB
            // 
            this.btnInfoNoCB.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoNoCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoCB.Location = new System.Drawing.Point(188, 87);
            this.btnInfoNoCB.Name = "btnInfoNoCB";
            this.btnInfoNoCB.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoCB.TabIndex = 38;
            this.btnInfoNoCB.Tag = "-noCB";
            this.toolTip1.SetToolTip(this.btnInfoNoCB, "Infos");
            this.btnInfoNoCB.UseVisualStyleBackColor = true;
            this.btnInfoNoCB.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWinXP
            // 
            this.btnInfoWinXP.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoWinXP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoWinXP.Location = new System.Drawing.Point(188, 64);
            this.btnInfoWinXP.Name = "btnInfoWinXP";
            this.btnInfoWinXP.Size = new System.Drawing.Size(16, 16);
            this.btnInfoWinXP.TabIndex = 28;
            this.btnInfoWinXP.Tag = "-winXP";
            this.toolTip1.SetToolTip(this.btnInfoWinXP, "Infos");
            this.btnInfoWinXP.UseVisualStyleBackColor = true;
            this.btnInfoWinXP.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxVRAM
            // 
            this.btnInfoMaxVRAM.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoMaxVRAM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoMaxVRAM.Location = new System.Drawing.Point(188, 41);
            this.btnInfoMaxVRAM.Name = "btnInfoMaxVRAM";
            this.btnInfoMaxVRAM.Size = new System.Drawing.Size(16, 16);
            this.btnInfoMaxVRAM.TabIndex = 27;
            this.btnInfoMaxVRAM.Tag = "-maxVRAM";
            this.toolTip1.SetToolTip(this.btnInfoMaxVRAM, "Infos");
            this.btnInfoMaxVRAM.UseVisualStyleBackColor = true;
            this.btnInfoMaxVRAM.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxMem
            // 
            this.btnInfoMaxMem.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoMaxMem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoMaxMem.Location = new System.Drawing.Point(188, 18);
            this.btnInfoMaxMem.Name = "btnInfoMaxMem";
            this.btnInfoMaxMem.Size = new System.Drawing.Size(16, 16);
            this.btnInfoMaxMem.TabIndex = 26;
            this.btnInfoMaxMem.Tag = "-maxMem";
            this.toolTip1.SetToolTip(this.btnInfoMaxMem, "Infos");
            this.btnInfoMaxMem.UseVisualStyleBackColor = true;
            this.btnInfoMaxMem.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbExThreads
            // 
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
            this.cmbExThreads.Size = new System.Drawing.Size(95, 21);
            this.cmbExThreads.TabIndex = 25;
            this.cmbExThreads.SelectedIndexChanged += new System.EventHandler(this.cmbExThreads_SelectedIndexChanged);
            // 
            // cmbCpuCount
            // 
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
            this.cmbCpuCount.Size = new System.Drawing.Size(95, 21);
            this.cmbCpuCount.TabIndex = 24;
            this.cmbCpuCount.SelectedIndexChanged += new System.EventHandler(this.cmbCpuCount_SelectedIndexChanged);
            // 
            // numMaxMem
            // 
            this.numMaxMem.Enabled = false;
            this.numMaxMem.Location = new System.Drawing.Point(87, 18);
            this.numMaxMem.Maximum = new decimal(new int[] {
            16000,
            0,
            0,
            0});
            this.numMaxMem.Minimum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numMaxMem.Name = "numMaxMem";
            this.numMaxMem.Size = new System.Drawing.Size(95, 20);
            this.numMaxMem.TabIndex = 22;
            this.numMaxMem.Value = new decimal(new int[] {
            3072,
            0,
            0,
            0});
            this.numMaxMem.ValueChanged += new System.EventHandler(this.numMaxMem_ValueChanged);
            // 
            // numMaxVRAM
            // 
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
            this.numMaxVRAM.Size = new System.Drawing.Size(95, 20);
            this.numMaxVRAM.TabIndex = 23;
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
            this.chbWinXP.TabIndex = 20;
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
            this.chbNoCB.TabIndex = 21;
            this.chbNoCB.Text = "-noCB";
            this.chbNoCB.UseVisualStyleBackColor = true;
            this.chbNoCB.CheckedChanged += new System.EventHandler(this.chbNoCB_CheckedChanged);
            // 
            // grpGameLoadingSpeedup
            // 
            this.grpGameLoadingSpeedup.BackColor = System.Drawing.SystemColors.Control;
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
            this.grpGameLoadingSpeedup.Size = new System.Drawing.Size(211, 88);
            this.grpGameLoadingSpeedup.TabIndex = 24;
            this.grpGameLoadingSpeedup.TabStop = false;
            this.grpGameLoadingSpeedup.Text = "Spielstartbeschleunigung";
            // 
            // btnInfoSkipIntro
            // 
            this.btnInfoSkipIntro.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoSkipIntro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoSkipIntro.Location = new System.Drawing.Point(188, 64);
            this.btnInfoSkipIntro.Name = "btnInfoSkipIntro";
            this.btnInfoSkipIntro.Size = new System.Drawing.Size(16, 16);
            this.btnInfoSkipIntro.TabIndex = 22;
            this.btnInfoSkipIntro.Tag = "-skipIntro";
            this.toolTip1.SetToolTip(this.btnInfoSkipIntro, "Infos");
            this.btnInfoSkipIntro.UseVisualStyleBackColor = true;
            this.btnInfoSkipIntro.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWorldEmpty
            // 
            this.btnInfoWorldEmpty.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoWorldEmpty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoWorldEmpty.Location = new System.Drawing.Point(188, 41);
            this.btnInfoWorldEmpty.Name = "btnInfoWorldEmpty";
            this.btnInfoWorldEmpty.Size = new System.Drawing.Size(16, 16);
            this.btnInfoWorldEmpty.TabIndex = 21;
            this.btnInfoWorldEmpty.Tag = "-worldEmtpy";
            this.toolTip1.SetToolTip(this.btnInfoWorldEmpty, "Infos");
            this.btnInfoWorldEmpty.UseVisualStyleBackColor = true;
            this.btnInfoWorldEmpty.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoSplash
            // 
            this.btnInfoNoSplash.Image = global::PALAST.Properties.Resources.exclamation;
            this.btnInfoNoSplash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInfoNoSplash.Location = new System.Drawing.Point(188, 18);
            this.btnInfoNoSplash.Name = "btnInfoNoSplash";
            this.btnInfoNoSplash.Size = new System.Drawing.Size(16, 16);
            this.btnInfoNoSplash.TabIndex = 20;
            this.btnInfoNoSplash.Tag = "-noSplash";
            this.toolTip1.SetToolTip(this.btnInfoNoSplash, "Infos");
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
            this.chbWorldEmpty.TabIndex = 18;
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
            this.chbSkipIntro.TabIndex = 19;
            this.chbSkipIntro.Text = "-skipIntro";
            this.chbSkipIntro.UseVisualStyleBackColor = true;
            this.chbSkipIntro.CheckedChanged += new System.EventHandler(this.chbSkipIntro_CheckedChanged);
            // 
            // lstPreset
            // 
            this.lstPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.IntegralHeight = false;
            this.lstPreset.Location = new System.Drawing.Point(0, 0);
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.Size = new System.Drawing.Size(204, 668);
            this.lstPreset.TabIndex = 33;
            this.lstPreset.SelectedIndexChanged += new System.EventHandler(this.lstPreset_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstPreset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clstAddons);
            this.splitContainer1.Panel2.Controls.Add(this.pnlParameter);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(654, 668);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 34;
            // 
            // pnlParameter
            // 
            this.pnlParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParameter.Controls.Add(this.grpAdditionalParameters);
            this.pnlParameter.Controls.Add(this.grpAutoConnect);
            this.pnlParameter.Controls.Add(this.grpDeveloperOptions);
            this.pnlParameter.Controls.Add(this.grpGameLoadingSpeedup);
            this.pnlParameter.Controls.Add(this.grpProfileOptions);
            this.pnlParameter.Controls.Add(this.grpPerformance);
            this.pnlParameter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParameter.Location = new System.Drawing.Point(219, 25);
            this.pnlParameter.Name = "pnlParameter";
            this.pnlParameter.Size = new System.Drawing.Size(227, 643);
            this.pnlParameter.TabIndex = 36;
            // 
            // grpAdditionalParameters
            // 
            this.grpAdditionalParameters.Controls.Add(this.txtAdditionalParameter);
            this.grpAdditionalParameters.Location = new System.Drawing.Point(7, 582);
            this.grpAdditionalParameters.Margin = new System.Windows.Forms.Padding(5);
            this.grpAdditionalParameters.Name = "grpAdditionalParameters";
            this.grpAdditionalParameters.Size = new System.Drawing.Size(211, 46);
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
            this.txtAdditionalParameter.Size = new System.Drawing.Size(199, 20);
            this.txtAdditionalParameter.TabIndex = 17;
            this.txtAdditionalParameter.TextChanged += new System.EventHandler(this.txtAdditionalParameter_TextChanged);
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnLaunch,
            this.toolStripSeparator3,
            this.tbtnUpdateAddons,
            this.toolStripSeparator4});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(446, 25);
            this.toolStrip3.TabIndex = 35;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tbtnLaunch
            // 
            this.tbtnLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnLaunch.Enabled = false;
            this.tbtnLaunch.Image = global::PALAST.Properties.Resources.control_play_blue;
            this.tbtnLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnLaunch.Name = "tbtnLaunch";
            this.tbtnLaunch.Size = new System.Drawing.Size(23, 22);
            this.tbtnLaunch.Text = "Spiel starten";
            this.tbtnLaunch.Click += new System.EventHandler(this.tbtnLaunch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnUpdateAddons
            // 
            this.tbtnUpdateAddons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnUpdateAddons.Enabled = false;
            this.tbtnUpdateAddons.Image = global::PALAST.Properties.Resources.arrow_refresh_small;
            this.tbtnUpdateAddons.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUpdateAddons.Name = "tbtnUpdateAddons";
            this.tbtnUpdateAddons.Size = new System.Drawing.Size(23, 22);
            this.tbtnUpdateAddons.Text = "Addons synchronisieren";
            this.tbtnUpdateAddons.Click += new System.EventHandler(this.tbtnUpdateAddons_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAddPreset,
            this.tbtnEditPreset,
            this.tbtnClonePreset,
            this.toolStripSeparator1,
            this.tbtnDeletePreset,
            this.toolStripSeparator2,
            this.tbtnInfo,
            this.tbtnSettings});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(654, 25);
            this.toolStrip2.TabIndex = 35;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbtnAddPreset
            // 
            this.tbtnAddPreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddPreset.Image = global::PALAST.Properties.Resources.table_add;
            this.tbtnAddPreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddPreset.Name = "tbtnAddPreset";
            this.tbtnAddPreset.Size = new System.Drawing.Size(23, 22);
            this.tbtnAddPreset.Text = "Vorlage hinzufügen";
            this.tbtnAddPreset.Click += new System.EventHandler(this.tbtnAddPreset_Click);
            // 
            // tbtnEditPreset
            // 
            this.tbtnEditPreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnEditPreset.Enabled = false;
            this.tbtnEditPreset.Image = global::PALAST.Properties.Resources.table_edit;
            this.tbtnEditPreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEditPreset.Name = "tbtnEditPreset";
            this.tbtnEditPreset.Size = new System.Drawing.Size(23, 22);
            this.tbtnEditPreset.Text = "Vorlage bearbeiten";
            this.tbtnEditPreset.Click += new System.EventHandler(this.tbtnEditPreset_Click);
            // 
            // tbtnClonePreset
            // 
            this.tbtnClonePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnClonePreset.Enabled = false;
            this.tbtnClonePreset.Image = global::PALAST.Properties.Resources.table_go;
            this.tbtnClonePreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnClonePreset.Name = "tbtnClonePreset";
            this.tbtnClonePreset.Size = new System.Drawing.Size(23, 22);
            this.tbtnClonePreset.Text = "Vorlage klonen";
            this.tbtnClonePreset.Click += new System.EventHandler(this.tbtnClonePreset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnDeletePreset
            // 
            this.tbtnDeletePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnDeletePreset.Enabled = false;
            this.tbtnDeletePreset.Image = global::PALAST.Properties.Resources.table_delete;
            this.tbtnDeletePreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeletePreset.Name = "tbtnDeletePreset";
            this.tbtnDeletePreset.Size = new System.Drawing.Size(23, 22);
            this.tbtnDeletePreset.Text = "Vorlage löschen";
            this.tbtnDeletePreset.Click += new System.EventHandler(this.tbtnDeletePreset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnInfo
            // 
            this.tbtnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInfo.Image = global::PALAST.Properties.Resources.help;
            this.tbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInfo.Name = "tbtnInfo";
            this.tbtnInfo.Size = new System.Drawing.Size(23, 22);
            this.tbtnInfo.Text = "Informationen";
            this.tbtnInfo.Click += new System.EventHandler(this.tbtnInfo_Click);
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSettings.Image = global::PALAST.Properties.Resources.cog;
            this.tbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Size = new System.Drawing.Size(23, 22);
            this.tbtnSettings.Text = "Einstellungen";
            this.tbtnSettings.Click += new System.EventHandler(this.tbtnSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 693);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlParameter.ResumeLayout(false);
            this.grpAdditionalParameters.ResumeLayout(false);
            this.grpAdditionalParameters.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clstAddons;
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
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlParameter;
        private System.Windows.Forms.GroupBox grpAdditionalParameters;
        private System.Windows.Forms.TextBox txtAdditionalParameter;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tbtnLaunch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tbtnUpdateAddons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbtnAddPreset;
        private System.Windows.Forms.ToolStripButton tbtnEditPreset;
        private System.Windows.Forms.ToolStripButton tbtnClonePreset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbtnDeletePreset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnInfo;
        private System.Windows.Forms.ToolStripButton tbtnSettings;
    }
}

