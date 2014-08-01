namespace YAAL
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
            this.chbAutoConnectEnabled = new System.Windows.Forms.CheckBox();
            this.grpAddons = new System.Windows.Forms.GroupBox();
            this.grpParameter = new System.Windows.Forms.GroupBox();
            this.grpAdditionalParameters = new System.Windows.Forms.GroupBox();
            this.txtAdditionalParameter = new System.Windows.Forms.TextBox();
            this.grpDeveloperOptions = new System.Windows.Forms.GroupBox();
            this.chbCheckSignatures = new System.Windows.Forms.CheckBox();
            this.grpProfileOptions = new System.Windows.Forms.GroupBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.grpPerformance = new System.Windows.Forms.GroupBox();
            this.cmbExThreads = new System.Windows.Forms.ComboBox();
            this.cmbCpuCount = new System.Windows.Forms.ComboBox();
            this.numMaxVRAM = new System.Windows.Forms.NumericUpDown();
            this.numMaxMem = new System.Windows.Forms.NumericUpDown();
            this.chbWinXP = new System.Windows.Forms.CheckBox();
            this.chbNoCB = new System.Windows.Forms.CheckBox();
            this.grpGameLoadingSpeedup = new System.Windows.Forms.GroupBox();
            this.chbWorldEmpty = new System.Windows.Forms.CheckBox();
            this.chbSkipIntro = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.tddbPreset = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.grpAutoConnect.SuspendLayout();
            this.grpAddons.SuspendLayout();
            this.grpParameter.SuspendLayout();
            this.grpAdditionalParameters.SuspendLayout();
            this.grpDeveloperOptions.SuspendLayout();
            this.grpProfileOptions.SuspendLayout();
            this.grpPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).BeginInit();
            this.grpGameLoadingSpeedup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clstAddons
            // 
            this.clstAddons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clstAddons.FormattingEnabled = true;
            this.clstAddons.IntegralHeight = false;
            this.clstAddons.Location = new System.Drawing.Point(10, 23);
            this.clstAddons.Name = "clstAddons";
            this.clstAddons.Size = new System.Drawing.Size(180, 304);
            this.clstAddons.TabIndex = 3;
            this.clstAddons.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstAddons_ItemCheck);
            // 
            // chbShowScriptErrors
            // 
            this.chbShowScriptErrors.AutoSize = true;
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
            this.txtServer.Location = new System.Drawing.Point(87, 13);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(95, 20);
            this.txtServer.TabIndex = 20;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(87, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(95, 20);
            this.txtPort.TabIndex = 21;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtPasswort
            // 
            this.txtPasswort.Enabled = false;
            this.txtPasswort.Location = new System.Drawing.Point(87, 58);
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.Size = new System.Drawing.Size(95, 20);
            this.txtPasswort.TabIndex = 22;
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(50, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Passwort";
            // 
            // grpAutoConnect
            // 
            this.grpAutoConnect.Controls.Add(this.chbAutoConnectEnabled);
            this.grpAutoConnect.Controls.Add(this.label1);
            this.grpAutoConnect.Controls.Add(this.txtServer);
            this.grpAutoConnect.Controls.Add(this.txtPort);
            this.grpAutoConnect.Controls.Add(this.lblPassword);
            this.grpAutoConnect.Controls.Add(this.txtPasswort);
            this.grpAutoConnect.Controls.Add(this.label2);
            this.grpAutoConnect.Location = new System.Drawing.Point(200, 184);
            this.grpAutoConnect.Name = "grpAutoConnect";
            this.grpAutoConnect.Size = new System.Drawing.Size(188, 102);
            this.grpAutoConnect.TabIndex = 30;
            this.grpAutoConnect.TabStop = false;
            this.grpAutoConnect.Text = "Auto-Connect";
            // 
            // chbAutoConnectEnabled
            // 
            this.chbAutoConnectEnabled.AutoSize = true;
            this.chbAutoConnectEnabled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbAutoConnectEnabled.Location = new System.Drawing.Point(118, 83);
            this.chbAutoConnectEnabled.Name = "chbAutoConnectEnabled";
            this.chbAutoConnectEnabled.Size = new System.Drawing.Size(64, 17);
            this.chbAutoConnectEnabled.TabIndex = 27;
            this.chbAutoConnectEnabled.Text = "enabled";
            this.chbAutoConnectEnabled.UseVisualStyleBackColor = true;
            this.chbAutoConnectEnabled.CheckedChanged += new System.EventHandler(this.chbAutoConnectEnabled_CheckedChanged);
            // 
            // grpAddons
            // 
            this.grpAddons.Controls.Add(this.clstAddons);
            this.grpAddons.Location = new System.Drawing.Point(12, 28);
            this.grpAddons.Name = "grpAddons";
            this.grpAddons.Padding = new System.Windows.Forms.Padding(10);
            this.grpAddons.Size = new System.Drawing.Size(200, 337);
            this.grpAddons.TabIndex = 31;
            this.grpAddons.TabStop = false;
            this.grpAddons.Text = "Addons";
            // 
            // grpParameter
            // 
            this.grpParameter.Controls.Add(this.grpAdditionalParameters);
            this.grpParameter.Controls.Add(this.grpDeveloperOptions);
            this.grpParameter.Controls.Add(this.grpProfileOptions);
            this.grpParameter.Controls.Add(this.grpAutoConnect);
            this.grpParameter.Controls.Add(this.grpPerformance);
            this.grpParameter.Controls.Add(this.grpGameLoadingSpeedup);
            this.grpParameter.Location = new System.Drawing.Point(218, 26);
            this.grpParameter.Name = "grpParameter";
            this.grpParameter.Size = new System.Drawing.Size(395, 345);
            this.grpParameter.TabIndex = 32;
            this.grpParameter.TabStop = false;
            this.grpParameter.Text = "Parameter";
            // 
            // grpAdditionalParameters
            // 
            this.grpAdditionalParameters.Controls.Add(this.txtAdditionalParameter);
            this.grpAdditionalParameters.Location = new System.Drawing.Point(6, 292);
            this.grpAdditionalParameters.Name = "grpAdditionalParameters";
            this.grpAdditionalParameters.Size = new System.Drawing.Size(382, 46);
            this.grpAdditionalParameters.TabIndex = 37;
            this.grpAdditionalParameters.TabStop = false;
            this.grpAdditionalParameters.Text = "additional parameters";
            // 
            // txtAdditionalParameter
            // 
            this.txtAdditionalParameter.Location = new System.Drawing.Point(6, 19);
            this.txtAdditionalParameter.Name = "txtAdditionalParameter";
            this.txtAdditionalParameter.Size = new System.Drawing.Size(370, 20);
            this.txtAdditionalParameter.TabIndex = 17;
            this.txtAdditionalParameter.TextChanged += new System.EventHandler(this.txtAdditionalParameter_TextChanged);
            // 
            // grpDeveloperOptions
            // 
            this.grpDeveloperOptions.Controls.Add(this.chbNoPause);
            this.grpDeveloperOptions.Controls.Add(this.chbShowScriptErrors);
            this.grpDeveloperOptions.Controls.Add(this.chbCheckSignatures);
            this.grpDeveloperOptions.Controls.Add(this.chbNoFilePatching);
            this.grpDeveloperOptions.Location = new System.Drawing.Point(200, 70);
            this.grpDeveloperOptions.Name = "grpDeveloperOptions";
            this.grpDeveloperOptions.Size = new System.Drawing.Size(188, 108);
            this.grpDeveloperOptions.TabIndex = 36;
            this.grpDeveloperOptions.TabStop = false;
            this.grpDeveloperOptions.Text = "developer options";
            // 
            // chbCheckSignatures
            // 
            this.chbCheckSignatures.AutoSize = true;
            this.chbCheckSignatures.Location = new System.Drawing.Point(6, 88);
            this.chbCheckSignatures.Name = "chbCheckSignatures";
            this.chbCheckSignatures.Size = new System.Drawing.Size(109, 17);
            this.chbCheckSignatures.TabIndex = 23;
            this.chbCheckSignatures.Text = "-checkSignatures";
            this.chbCheckSignatures.UseVisualStyleBackColor = true;
            this.chbCheckSignatures.CheckedChanged += new System.EventHandler(this.chbCheckSignatures_CheckedChanged);
            // 
            // grpProfileOptions
            // 
            this.grpProfileOptions.Controls.Add(this.cmbName);
            this.grpProfileOptions.Controls.Add(this.chbName);
            this.grpProfileOptions.Location = new System.Drawing.Point(200, 19);
            this.grpProfileOptions.Name = "grpProfileOptions";
            this.grpProfileOptions.Size = new System.Drawing.Size(188, 45);
            this.grpProfileOptions.TabIndex = 35;
            this.grpProfileOptions.TabStop = false;
            this.grpProfileOptions.Text = "profile options";
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
            this.grpPerformance.Controls.Add(this.cmbExThreads);
            this.grpPerformance.Controls.Add(this.cmbCpuCount);
            this.grpPerformance.Controls.Add(this.numMaxVRAM);
            this.grpPerformance.Controls.Add(this.numMaxMem);
            this.grpPerformance.Controls.Add(this.chbMaxMem);
            this.grpPerformance.Controls.Add(this.chbCpuCount);
            this.grpPerformance.Controls.Add(this.chbNoLogs);
            this.grpPerformance.Controls.Add(this.chbMaxVRAM);
            this.grpPerformance.Controls.Add(this.chbWinXP);
            this.grpPerformance.Controls.Add(this.chbExThreads);
            this.grpPerformance.Controls.Add(this.chbNoCB);
            this.grpPerformance.Location = new System.Drawing.Point(6, 110);
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.Size = new System.Drawing.Size(188, 176);
            this.grpPerformance.TabIndex = 34;
            this.grpPerformance.TabStop = false;
            this.grpPerformance.Text = "performance";
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
            // numMaxVRAM
            // 
            this.numMaxVRAM.Enabled = false;
            this.numMaxVRAM.Location = new System.Drawing.Point(87, 41);
            this.numMaxVRAM.Maximum = new decimal(new int[] {
            2047,
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
            // numMaxMem
            // 
            this.numMaxMem.Enabled = false;
            this.numMaxMem.Location = new System.Drawing.Point(87, 18);
            this.numMaxMem.Maximum = new decimal(new int[] {
            3072,
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
            // chbWinXP
            // 
            this.chbWinXP.AutoSize = true;
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
            this.grpGameLoadingSpeedup.Controls.Add(this.chbNoSpalsh);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbWorldEmpty);
            this.grpGameLoadingSpeedup.Controls.Add(this.chbSkipIntro);
            this.grpGameLoadingSpeedup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGameLoadingSpeedup.Location = new System.Drawing.Point(6, 19);
            this.grpGameLoadingSpeedup.Name = "grpGameLoadingSpeedup";
            this.grpGameLoadingSpeedup.Size = new System.Drawing.Size(188, 85);
            this.grpGameLoadingSpeedup.TabIndex = 24;
            this.grpGameLoadingSpeedup.TabStop = false;
            this.grpGameLoadingSpeedup.Text = "game loading speedup";
            // 
            // chbWorldEmpty
            // 
            this.chbWorldEmpty.AutoSize = true;
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
            this.chbSkipIntro.Location = new System.Drawing.Point(6, 65);
            this.chbSkipIntro.Name = "chbSkipIntro";
            this.chbSkipIntro.Size = new System.Drawing.Size(69, 17);
            this.chbSkipIntro.TabIndex = 19;
            this.chbSkipIntro.Text = "-skipIntro";
            this.chbSkipIntro.UseVisualStyleBackColor = true;
            this.chbSkipIntro.CheckedChanged += new System.EventHandler(this.chbSkipIntro_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInfo,
            this.tbtnSettings,
            this.tddbPreset});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnInfo
            // 
            this.tbtnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInfo.Image = global::YAAL.Properties.Resources.help;
            this.tbtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnInfo.Name = "tbtnInfo";
            this.tbtnInfo.Size = new System.Drawing.Size(23, 22);
            this.tbtnInfo.Text = "info";
            this.tbtnInfo.Click += new System.EventHandler(this.tbtnInfo_Click);
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSettings.Image = global::YAAL.Properties.Resources.cog;
            this.tbtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Size = new System.Drawing.Size(23, 22);
            this.tbtnSettings.Text = "settings";
            this.tbtnSettings.Click += new System.EventHandler(this.tbtnSettings_Click);
            // 
            // tddbPreset
            // 
            this.tddbPreset.Image = global::YAAL.Properties.Resources.target;
            this.tddbPreset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tddbPreset.Name = "tddbPreset";
            this.tddbPreset.Size = new System.Drawing.Size(68, 22);
            this.tddbPreset.Text = "Preset";
            this.tddbPreset.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tddbPreset_DropDownItemClicked);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(12, 377);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(601, 28);
            this.btnLaunch.TabIndex = 34;
            this.btnLaunch.Text = "Start ArmA3";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnLaunch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 417);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpParameter);
            this.Controls.Add(this.grpAddons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAAL (Yet Another Arma Launcher)";
            this.grpAutoConnect.ResumeLayout(false);
            this.grpAutoConnect.PerformLayout();
            this.grpAddons.ResumeLayout(false);
            this.grpParameter.ResumeLayout(false);
            this.grpAdditionalParameters.ResumeLayout(false);
            this.grpAdditionalParameters.PerformLayout();
            this.grpDeveloperOptions.ResumeLayout(false);
            this.grpDeveloperOptions.PerformLayout();
            this.grpProfileOptions.ResumeLayout(false);
            this.grpProfileOptions.PerformLayout();
            this.grpPerformance.ResumeLayout(false);
            this.grpPerformance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).EndInit();
            this.grpGameLoadingSpeedup.ResumeLayout(false);
            this.grpGameLoadingSpeedup.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpAddons;
        private System.Windows.Forms.GroupBox grpParameter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton tddbPreset;
        private System.Windows.Forms.ToolStripButton tbtnSettings;
        private System.Windows.Forms.TextBox txtAdditionalParameter;
        private System.Windows.Forms.CheckBox chbSkipIntro;
        private System.Windows.Forms.CheckBox chbWorldEmpty;
        private System.Windows.Forms.CheckBox chbCheckSignatures;
        private System.Windows.Forms.CheckBox chbNoCB;
        private System.Windows.Forms.CheckBox chbWinXP;
        private System.Windows.Forms.GroupBox grpAdditionalParameters;
        private System.Windows.Forms.GroupBox grpDeveloperOptions;
        private System.Windows.Forms.GroupBox grpProfileOptions;
        private System.Windows.Forms.GroupBox grpPerformance;
        private System.Windows.Forms.GroupBox grpGameLoadingSpeedup;
        private System.Windows.Forms.NumericUpDown numMaxVRAM;
        private System.Windows.Forms.NumericUpDown numMaxMem;
        private System.Windows.Forms.ComboBox cmbExThreads;
        private System.Windows.Forms.ComboBox cmbCpuCount;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.CheckBox chbAutoConnectEnabled;
        private System.Windows.Forms.ToolStripButton tbtnInfo;
    }
}

