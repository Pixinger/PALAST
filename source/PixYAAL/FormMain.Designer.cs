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
            this.grpAddons = new System.Windows.Forms.GroupBox();
            this.grpParameter = new System.Windows.Forms.GroupBox();
            this.grpAdditionalParameters = new System.Windows.Forms.GroupBox();
            this.txtAdditionalParameter = new System.Windows.Forms.TextBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnInfo = new System.Windows.Forms.ToolStripButton();
            this.tbtnSettings = new System.Windows.Forms.ToolStripButton();
            this.tddbPreset = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpAutoConnect.SuspendLayout();
            this.grpAddons.SuspendLayout();
            this.grpParameter.SuspendLayout();
            this.grpAdditionalParameters.SuspendLayout();
            this.grpDeveloperOptions.SuspendLayout();
            this.grpProfileOptions.SuspendLayout();
            this.grpPerformance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).BeginInit();
            this.grpGameLoadingSpeedup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clstAddons
            // 
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
            // grpAddons
            // 
            this.grpAddons.Controls.Add(this.clstAddons);
            resources.ApplyResources(this.grpAddons, "grpAddons");
            this.grpAddons.Name = "grpAddons";
            this.grpAddons.TabStop = false;
            // 
            // grpParameter
            // 
            this.grpParameter.Controls.Add(this.grpAdditionalParameters);
            this.grpParameter.Controls.Add(this.grpDeveloperOptions);
            this.grpParameter.Controls.Add(this.grpProfileOptions);
            this.grpParameter.Controls.Add(this.grpAutoConnect);
            this.grpParameter.Controls.Add(this.grpPerformance);
            this.grpParameter.Controls.Add(this.grpGameLoadingSpeedup);
            resources.ApplyResources(this.grpParameter, "grpParameter");
            this.grpParameter.Name = "grpParameter";
            this.grpParameter.TabStop = false;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnInfo,
            this.tbtnSettings,
            this.tddbPreset});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
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
            // tddbPreset
            // 
            this.tddbPreset.Image = global::YAAL.Properties.Resources.target;
            resources.ApplyResources(this.tddbPreset, "tddbPreset");
            this.tddbPreset.Name = "tddbPreset";
            this.tddbPreset.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tddbPreset_DropDownItemClicked);
            // 
            // btnLaunch
            // 
            resources.ApplyResources(this.btnLaunch, "btnLaunch");
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnLaunch;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpParameter);
            this.Controls.Add(this.grpAddons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
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
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxVRAM)).EndInit();
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
    }
}

