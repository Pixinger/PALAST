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
            resources.ApplyResources(this.clstAddons, "clstAddons");
            this.clstAddons.FormattingEnabled = true;
            this.clstAddons.Name = "clstAddons";
            this.clstAddons.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstAddons_ItemCheck);
            // 
            // chbShowScriptErrors
            // 
            resources.ApplyResources(this.chbShowScriptErrors, "chbShowScriptErrors");
            this.chbShowScriptErrors.Name = "chbShowScriptErrors";
            this.chbShowScriptErrors.UseVisualStyleBackColor = true;
            this.chbShowScriptErrors.CheckedChanged += new System.EventHandler(this.chbShowScriptErrors_CheckedChanged);
            // 
            // chbNoPause
            // 
            resources.ApplyResources(this.chbNoPause, "chbNoPause");
            this.chbNoPause.Name = "chbNoPause";
            this.chbNoPause.UseVisualStyleBackColor = true;
            this.chbNoPause.CheckedChanged += new System.EventHandler(this.chbNoPause_CheckedChanged);
            // 
            // chbExThreads
            // 
            resources.ApplyResources(this.chbExThreads, "chbExThreads");
            this.chbExThreads.Name = "chbExThreads";
            this.chbExThreads.UseVisualStyleBackColor = true;
            this.chbExThreads.CheckedChanged += new System.EventHandler(this.chbExThreads_CheckedChanged);
            // 
            // chbNoFilePatching
            // 
            resources.ApplyResources(this.chbNoFilePatching, "chbNoFilePatching");
            this.chbNoFilePatching.Name = "chbNoFilePatching";
            this.chbNoFilePatching.UseVisualStyleBackColor = true;
            this.chbNoFilePatching.CheckedChanged += new System.EventHandler(this.chbNoFilePatching_CheckedChanged);
            // 
            // chbNoSpalsh
            // 
            resources.ApplyResources(this.chbNoSpalsh, "chbNoSpalsh");
            this.chbNoSpalsh.Name = "chbNoSpalsh";
            this.chbNoSpalsh.UseVisualStyleBackColor = true;
            this.chbNoSpalsh.CheckedChanged += new System.EventHandler(this.chbNoSpalsh_CheckedChanged);
            // 
            // chbNoLogs
            // 
            resources.ApplyResources(this.chbNoLogs, "chbNoLogs");
            this.chbNoLogs.Name = "chbNoLogs";
            this.chbNoLogs.UseVisualStyleBackColor = true;
            this.chbNoLogs.CheckedChanged += new System.EventHandler(this.chbNoLogs_CheckedChanged);
            // 
            // chbCpuCount
            // 
            resources.ApplyResources(this.chbCpuCount, "chbCpuCount");
            this.chbCpuCount.Name = "chbCpuCount";
            this.chbCpuCount.UseVisualStyleBackColor = true;
            this.chbCpuCount.CheckedChanged += new System.EventHandler(this.chbCpuCount_CheckedChanged);
            // 
            // chbMaxMem
            // 
            resources.ApplyResources(this.chbMaxMem, "chbMaxMem");
            this.chbMaxMem.Name = "chbMaxMem";
            this.chbMaxMem.UseVisualStyleBackColor = true;
            this.chbMaxMem.CheckedChanged += new System.EventHandler(this.chbMaxMem_CheckedChanged);
            // 
            // chbMaxVRAM
            // 
            resources.ApplyResources(this.chbMaxVRAM, "chbMaxVRAM");
            this.chbMaxVRAM.Name = "chbMaxVRAM";
            this.chbMaxVRAM.UseVisualStyleBackColor = true;
            this.chbMaxVRAM.CheckedChanged += new System.EventHandler(this.chbMaxVRAM_CheckedChanged);
            // 
            // chbName
            // 
            resources.ApplyResources(this.chbName, "chbName");
            this.chbName.Name = "chbName";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // txtServer
            // 
            resources.ApplyResources(this.txtServer, "txtServer");
            this.txtServer.Name = "txtServer";
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // txtPort
            // 
            resources.ApplyResources(this.txtPort, "txtPort");
            this.txtPort.Name = "txtPort";
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtPasswort
            // 
            resources.ApplyResources(this.txtPasswort, "txtPasswort");
            this.txtPasswort.Name = "txtPasswort";
            this.txtPasswort.TextChanged += new System.EventHandler(this.txtPasswort_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
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
            resources.ApplyResources(this.grpAutoConnect, "grpAutoConnect");
            this.grpAutoConnect.Name = "grpAutoConnect";
            this.grpAutoConnect.TabStop = false;
            // 
            // btnInfoAutoConnect
            // 
            this.btnInfoAutoConnect.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoAutoConnect, "btnInfoAutoConnect");
            this.btnInfoAutoConnect.Name = "btnInfoAutoConnect";
            this.btnInfoAutoConnect.Tag = "-autoConnect";
            this.toolTip1.SetToolTip(this.btnInfoAutoConnect, resources.GetString("btnInfoAutoConnect.ToolTip"));
            this.btnInfoAutoConnect.UseVisualStyleBackColor = true;
            this.btnInfoAutoConnect.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbAutoConnectEnabled
            // 
            resources.ApplyResources(this.chbAutoConnectEnabled, "chbAutoConnectEnabled");
            this.chbAutoConnectEnabled.Name = "chbAutoConnectEnabled";
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
            resources.ApplyResources(this.grpDeveloperOptions, "grpDeveloperOptions");
            this.grpDeveloperOptions.Name = "grpDeveloperOptions";
            this.grpDeveloperOptions.TabStop = false;
            // 
            // btnInfoCheckSignatures
            // 
            this.btnInfoCheckSignatures.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoCheckSignatures, "btnInfoCheckSignatures");
            this.btnInfoCheckSignatures.Name = "btnInfoCheckSignatures";
            this.btnInfoCheckSignatures.Tag = "-checkSignatures";
            this.toolTip1.SetToolTip(this.btnInfoCheckSignatures, resources.GetString("btnInfoCheckSignatures.ToolTip"));
            this.btnInfoCheckSignatures.UseVisualStyleBackColor = true;
            this.btnInfoCheckSignatures.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoFilePatching
            // 
            this.btnInfoNoFilePatching.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoNoFilePatching, "btnInfoNoFilePatching");
            this.btnInfoNoFilePatching.Name = "btnInfoNoFilePatching";
            this.btnInfoNoFilePatching.Tag = "-noFilePatching";
            this.toolTip1.SetToolTip(this.btnInfoNoFilePatching, resources.GetString("btnInfoNoFilePatching.ToolTip"));
            this.btnInfoNoFilePatching.UseVisualStyleBackColor = true;
            this.btnInfoNoFilePatching.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoShowScriptErrors
            // 
            this.btnInfoShowScriptErrors.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoShowScriptErrors, "btnInfoShowScriptErrors");
            this.btnInfoShowScriptErrors.Name = "btnInfoShowScriptErrors";
            this.btnInfoShowScriptErrors.Tag = "-showScriptErrors";
            this.toolTip1.SetToolTip(this.btnInfoShowScriptErrors, resources.GetString("btnInfoShowScriptErrors.ToolTip"));
            this.btnInfoShowScriptErrors.UseVisualStyleBackColor = true;
            this.btnInfoShowScriptErrors.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbCheckSignatures
            // 
            resources.ApplyResources(this.chbCheckSignatures, "chbCheckSignatures");
            this.chbCheckSignatures.Name = "chbCheckSignatures";
            this.chbCheckSignatures.UseVisualStyleBackColor = true;
            this.chbCheckSignatures.CheckedChanged += new System.EventHandler(this.chbCheckSignatures_CheckedChanged);
            // 
            // btnInfoNoPause
            // 
            this.btnInfoNoPause.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoNoPause, "btnInfoNoPause");
            this.btnInfoNoPause.Name = "btnInfoNoPause";
            this.btnInfoNoPause.Tag = "-noPause";
            this.toolTip1.SetToolTip(this.btnInfoNoPause, resources.GetString("btnInfoNoPause.ToolTip"));
            this.btnInfoNoPause.UseVisualStyleBackColor = true;
            this.btnInfoNoPause.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // grpProfileOptions
            // 
            this.grpProfileOptions.Controls.Add(this.btnInfoName);
            this.grpProfileOptions.Controls.Add(this.cmbName);
            this.grpProfileOptions.Controls.Add(this.chbName);
            resources.ApplyResources(this.grpProfileOptions, "grpProfileOptions");
            this.grpProfileOptions.Name = "grpProfileOptions";
            this.grpProfileOptions.TabStop = false;
            // 
            // btnInfoName
            // 
            this.btnInfoName.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoName, "btnInfoName");
            this.btnInfoName.Name = "btnInfoName";
            this.btnInfoName.Tag = "-name";
            this.toolTip1.SetToolTip(this.btnInfoName, resources.GetString("btnInfoName.ToolTip"));
            this.btnInfoName.UseVisualStyleBackColor = true;
            this.btnInfoName.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbName
            // 
            resources.ApplyResources(this.cmbName, "cmbName");
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Name = "cmbName";
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
            resources.ApplyResources(this.grpPerformance, "grpPerformance");
            this.grpPerformance.Name = "grpPerformance";
            this.grpPerformance.TabStop = false;
            // 
            // btnInfoNoLogs
            // 
            this.btnInfoNoLogs.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoNoLogs, "btnInfoNoLogs");
            this.btnInfoNoLogs.Name = "btnInfoNoLogs";
            this.btnInfoNoLogs.Tag = "-noLogs";
            this.toolTip1.SetToolTip(this.btnInfoNoLogs, resources.GetString("btnInfoNoLogs.ToolTip"));
            this.btnInfoNoLogs.UseVisualStyleBackColor = true;
            this.btnInfoNoLogs.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoExThreads
            // 
            this.btnInfoExThreads.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoExThreads, "btnInfoExThreads");
            this.btnInfoExThreads.Name = "btnInfoExThreads";
            this.btnInfoExThreads.Tag = "-exThreads";
            this.toolTip1.SetToolTip(this.btnInfoExThreads, resources.GetString("btnInfoExThreads.ToolTip"));
            this.btnInfoExThreads.UseVisualStyleBackColor = true;
            this.btnInfoExThreads.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoCpuCount
            // 
            this.btnInfoCpuCount.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoCpuCount, "btnInfoCpuCount");
            this.btnInfoCpuCount.Name = "btnInfoCpuCount";
            this.btnInfoCpuCount.Tag = "-cpuCount";
            this.toolTip1.SetToolTip(this.btnInfoCpuCount, resources.GetString("btnInfoCpuCount.ToolTip"));
            this.btnInfoCpuCount.UseVisualStyleBackColor = true;
            this.btnInfoCpuCount.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoCB
            // 
            this.btnInfoNoCB.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoNoCB, "btnInfoNoCB");
            this.btnInfoNoCB.Name = "btnInfoNoCB";
            this.btnInfoNoCB.Tag = "-noCB";
            this.toolTip1.SetToolTip(this.btnInfoNoCB, resources.GetString("btnInfoNoCB.ToolTip"));
            this.btnInfoNoCB.UseVisualStyleBackColor = true;
            this.btnInfoNoCB.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWinXP
            // 
            this.btnInfoWinXP.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoWinXP, "btnInfoWinXP");
            this.btnInfoWinXP.Name = "btnInfoWinXP";
            this.btnInfoWinXP.Tag = "-winXP";
            this.toolTip1.SetToolTip(this.btnInfoWinXP, resources.GetString("btnInfoWinXP.ToolTip"));
            this.btnInfoWinXP.UseVisualStyleBackColor = true;
            this.btnInfoWinXP.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxVRAM
            // 
            this.btnInfoMaxVRAM.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoMaxVRAM, "btnInfoMaxVRAM");
            this.btnInfoMaxVRAM.Name = "btnInfoMaxVRAM";
            this.btnInfoMaxVRAM.Tag = "-maxVRAM";
            this.toolTip1.SetToolTip(this.btnInfoMaxVRAM, resources.GetString("btnInfoMaxVRAM.ToolTip"));
            this.btnInfoMaxVRAM.UseVisualStyleBackColor = true;
            this.btnInfoMaxVRAM.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoMaxMem
            // 
            this.btnInfoMaxMem.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoMaxMem, "btnInfoMaxMem");
            this.btnInfoMaxMem.Name = "btnInfoMaxMem";
            this.btnInfoMaxMem.Tag = "-maxMem";
            this.toolTip1.SetToolTip(this.btnInfoMaxMem, resources.GetString("btnInfoMaxMem.ToolTip"));
            this.btnInfoMaxMem.UseVisualStyleBackColor = true;
            this.btnInfoMaxMem.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // cmbExThreads
            // 
            resources.ApplyResources(this.cmbExThreads, "cmbExThreads");
            this.cmbExThreads.FormattingEnabled = true;
            this.cmbExThreads.Items.AddRange(new object[] {
            resources.GetString("cmbExThreads.Items"),
            resources.GetString("cmbExThreads.Items1"),
            resources.GetString("cmbExThreads.Items2"),
            resources.GetString("cmbExThreads.Items3"),
            resources.GetString("cmbExThreads.Items4")});
            this.cmbExThreads.Name = "cmbExThreads";
            this.cmbExThreads.SelectedIndexChanged += new System.EventHandler(this.cmbExThreads_SelectedIndexChanged);
            // 
            // cmbCpuCount
            // 
            resources.ApplyResources(this.cmbCpuCount, "cmbCpuCount");
            this.cmbCpuCount.FormattingEnabled = true;
            this.cmbCpuCount.Items.AddRange(new object[] {
            resources.GetString("cmbCpuCount.Items"),
            resources.GetString("cmbCpuCount.Items1"),
            resources.GetString("cmbCpuCount.Items2"),
            resources.GetString("cmbCpuCount.Items3"),
            resources.GetString("cmbCpuCount.Items4"),
            resources.GetString("cmbCpuCount.Items5"),
            resources.GetString("cmbCpuCount.Items6"),
            resources.GetString("cmbCpuCount.Items7"),
            resources.GetString("cmbCpuCount.Items8"),
            resources.GetString("cmbCpuCount.Items9"),
            resources.GetString("cmbCpuCount.Items10"),
            resources.GetString("cmbCpuCount.Items11"),
            resources.GetString("cmbCpuCount.Items12"),
            resources.GetString("cmbCpuCount.Items13"),
            resources.GetString("cmbCpuCount.Items14"),
            resources.GetString("cmbCpuCount.Items15")});
            this.cmbCpuCount.Name = "cmbCpuCount";
            this.cmbCpuCount.SelectedIndexChanged += new System.EventHandler(this.cmbCpuCount_SelectedIndexChanged);
            // 
            // numMaxMem
            // 
            resources.ApplyResources(this.numMaxMem, "numMaxMem");
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
            this.numMaxMem.Value = new decimal(new int[] {
            3072,
            0,
            0,
            0});
            this.numMaxMem.ValueChanged += new System.EventHandler(this.numMaxMem_ValueChanged);
            // 
            // numMaxVRAM
            // 
            resources.ApplyResources(this.numMaxVRAM, "numMaxVRAM");
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
            this.numMaxVRAM.Value = new decimal(new int[] {
            2047,
            0,
            0,
            0});
            this.numMaxVRAM.ValueChanged += new System.EventHandler(this.numMaxVRAM_ValueChanged);
            // 
            // chbWinXP
            // 
            resources.ApplyResources(this.chbWinXP, "chbWinXP");
            this.chbWinXP.Name = "chbWinXP";
            this.chbWinXP.UseVisualStyleBackColor = true;
            this.chbWinXP.CheckedChanged += new System.EventHandler(this.chbWinXP_CheckedChanged);
            // 
            // chbNoCB
            // 
            resources.ApplyResources(this.chbNoCB, "chbNoCB");
            this.chbNoCB.Name = "chbNoCB";
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
            resources.ApplyResources(this.grpGameLoadingSpeedup, "grpGameLoadingSpeedup");
            this.grpGameLoadingSpeedup.Name = "grpGameLoadingSpeedup";
            this.grpGameLoadingSpeedup.TabStop = false;
            // 
            // btnInfoSkipIntro
            // 
            this.btnInfoSkipIntro.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoSkipIntro, "btnInfoSkipIntro");
            this.btnInfoSkipIntro.Name = "btnInfoSkipIntro";
            this.btnInfoSkipIntro.Tag = "-skipIntro";
            this.toolTip1.SetToolTip(this.btnInfoSkipIntro, resources.GetString("btnInfoSkipIntro.ToolTip"));
            this.btnInfoSkipIntro.UseVisualStyleBackColor = true;
            this.btnInfoSkipIntro.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoWorldEmpty
            // 
            this.btnInfoWorldEmpty.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoWorldEmpty, "btnInfoWorldEmpty");
            this.btnInfoWorldEmpty.Name = "btnInfoWorldEmpty";
            this.btnInfoWorldEmpty.Tag = "-worldEmtpy";
            this.toolTip1.SetToolTip(this.btnInfoWorldEmpty, resources.GetString("btnInfoWorldEmpty.ToolTip"));
            this.btnInfoWorldEmpty.UseVisualStyleBackColor = true;
            this.btnInfoWorldEmpty.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // btnInfoNoSplash
            // 
            this.btnInfoNoSplash.Image = global::YAAL.Properties.Resources.exclamation;
            resources.ApplyResources(this.btnInfoNoSplash, "btnInfoNoSplash");
            this.btnInfoNoSplash.Name = "btnInfoNoSplash";
            this.btnInfoNoSplash.Tag = "-noSplash";
            this.toolTip1.SetToolTip(this.btnInfoNoSplash, resources.GetString("btnInfoNoSplash.ToolTip"));
            this.btnInfoNoSplash.UseVisualStyleBackColor = true;
            this.btnInfoNoSplash.Click += new System.EventHandler(this.btnInfoOptions_Click);
            // 
            // chbWorldEmpty
            // 
            resources.ApplyResources(this.chbWorldEmpty, "chbWorldEmpty");
            this.chbWorldEmpty.Name = "chbWorldEmpty";
            this.chbWorldEmpty.UseVisualStyleBackColor = true;
            this.chbWorldEmpty.CheckedChanged += new System.EventHandler(this.chbWorldEmpty_CheckedChanged);
            // 
            // chbSkipIntro
            // 
            resources.ApplyResources(this.chbSkipIntro, "chbSkipIntro");
            this.chbSkipIntro.Name = "chbSkipIntro";
            this.chbSkipIntro.UseVisualStyleBackColor = true;
            this.chbSkipIntro.CheckedChanged += new System.EventHandler(this.chbSkipIntro_CheckedChanged);
            // 
            // lstPreset
            // 
            resources.ApplyResources(this.lstPreset, "lstPreset");
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.SelectedIndexChanged += new System.EventHandler(this.lstPreset_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
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
            resources.ApplyResources(this.pnlParameter, "pnlParameter");
            this.pnlParameter.Name = "pnlParameter";
            // 
            // grpAdditionalParameters
            // 
            this.grpAdditionalParameters.Controls.Add(this.txtAdditionalParameter);
            resources.ApplyResources(this.grpAdditionalParameters, "grpAdditionalParameters");
            this.grpAdditionalParameters.Name = "grpAdditionalParameters";
            this.grpAdditionalParameters.TabStop = false;
            // 
            // txtAdditionalParameter
            // 
            resources.ApplyResources(this.txtAdditionalParameter, "txtAdditionalParameter");
            this.txtAdditionalParameter.Name = "txtAdditionalParameter";
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
            resources.ApplyResources(this.toolStrip3, "toolStrip3");
            this.toolStrip3.Name = "toolStrip3";
            // 
            // tbtnLaunch
            // 
            this.tbtnLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbtnLaunch, "tbtnLaunch");
            this.tbtnLaunch.Image = global::YAAL.Properties.Resources.control_play_blue;
            this.tbtnLaunch.Name = "tbtnLaunch";
            this.tbtnLaunch.Click += new System.EventHandler(this.tbtnLaunch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // tbtnUpdateAddons
            // 
            this.tbtnUpdateAddons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbtnUpdateAddons, "tbtnUpdateAddons");
            this.tbtnUpdateAddons.Image = global::YAAL.Properties.Resources.arrow_refresh_small;
            this.tbtnUpdateAddons.Name = "tbtnUpdateAddons";
            this.tbtnUpdateAddons.Click += new System.EventHandler(this.tbtnUpdateAddons_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
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
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.Name = "toolStrip2";
            // 
            // tbtnAddPreset
            // 
            this.tbtnAddPreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddPreset.Image = global::YAAL.Properties.Resources.table_add;
            resources.ApplyResources(this.tbtnAddPreset, "tbtnAddPreset");
            this.tbtnAddPreset.Name = "tbtnAddPreset";
            this.tbtnAddPreset.Click += new System.EventHandler(this.tbtnAddPreset_Click);
            // 
            // tbtnEditPreset
            // 
            this.tbtnEditPreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbtnEditPreset, "tbtnEditPreset");
            this.tbtnEditPreset.Image = global::YAAL.Properties.Resources.table_edit;
            this.tbtnEditPreset.Name = "tbtnEditPreset";
            this.tbtnEditPreset.Click += new System.EventHandler(this.tbtnEditPreset_Click);
            // 
            // tbtnClonePreset
            // 
            this.tbtnClonePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbtnClonePreset, "tbtnClonePreset");
            this.tbtnClonePreset.Image = global::YAAL.Properties.Resources.table_go;
            this.tbtnClonePreset.Name = "tbtnClonePreset";
            this.tbtnClonePreset.Click += new System.EventHandler(this.tbtnClonePreset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tbtnDeletePreset
            // 
            this.tbtnDeletePreset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tbtnDeletePreset, "tbtnDeletePreset");
            this.tbtnDeletePreset.Image = global::YAAL.Properties.Resources.table_delete;
            this.tbtnDeletePreset.Name = "tbtnDeletePreset";
            this.tbtnDeletePreset.Click += new System.EventHandler(this.tbtnDeletePreset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tbtnInfo
            // 
            this.tbtnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnInfo.Image = global::YAAL.Properties.Resources.help;
            resources.ApplyResources(this.tbtnInfo, "tbtnInfo");
            this.tbtnInfo.Name = "tbtnInfo";
            this.tbtnInfo.Click += new System.EventHandler(this.tbtnInfo_Click);
            // 
            // tbtnSettings
            // 
            this.tbtnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSettings.Image = global::YAAL.Properties.Resources.cog;
            resources.ApplyResources(this.tbtnSettings, "tbtnSettings");
            this.tbtnSettings.Name = "tbtnSettings";
            this.tbtnSettings.Click += new System.EventHandler(this.tbtnSettings_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
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

