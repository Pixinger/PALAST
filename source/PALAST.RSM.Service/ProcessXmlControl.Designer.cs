namespace PALAST.RSM.Service
{
    partial class ProcessXmlControl
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessXmlControl));
            this.btnBrowseWorkingDirectory = new System.Windows.Forms.Button();
            this.btnBrowseFilename = new System.Windows.Forms.Button();
            this.lblArguments = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.lblWorkingdirectoy = new System.Windows.Forms.Label();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseWorkingDirectory
            // 
            this.btnBrowseWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseWorkingDirectory.Location = new System.Drawing.Point(424, 74);
            this.btnBrowseWorkingDirectory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBrowseWorkingDirectory.Name = "btnBrowseWorkingDirectory";
            this.btnBrowseWorkingDirectory.Size = new System.Drawing.Size(26, 20);
            this.btnBrowseWorkingDirectory.TabIndex = 7;
            this.btnBrowseWorkingDirectory.Text = "...";
            this.btnBrowseWorkingDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseWorkingDirectory.Click += new System.EventHandler(this.btnBrowseWorkingDirectory_Click);
            // 
            // btnBrowseFilename
            // 
            this.btnBrowseFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFilename.Location = new System.Drawing.Point(424, 35);
            this.btnBrowseFilename.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBrowseFilename.Name = "btnBrowseFilename";
            this.btnBrowseFilename.Size = new System.Drawing.Size(26, 20);
            this.btnBrowseFilename.TabIndex = 6;
            this.btnBrowseFilename.Text = "...";
            this.btnBrowseFilename.UseVisualStyleBackColor = true;
            this.btnBrowseFilename.Click += new System.EventHandler(this.btnBrowseFilename_Click);
            // 
            // lblArguments
            // 
            this.lblArguments.AutoSize = true;
            this.lblArguments.Location = new System.Drawing.Point(0, 97);
            this.lblArguments.Margin = new System.Windows.Forms.Padding(0);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(61, 13);
            this.lblArguments.TabIndex = 4;
            this.lblArguments.Text = "Argumente:";
            // 
            // txtArguments
            // 
            this.txtArguments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArguments.Location = new System.Drawing.Point(3, 113);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(447, 20);
            this.txtArguments.TabIndex = 5;
            this.txtArguments.TextChanged += new System.EventHandler(this.txtArguments_TextChanged);
            // 
            // lblWorkingdirectoy
            // 
            this.lblWorkingdirectoy.AutoSize = true;
            this.lblWorkingdirectoy.Location = new System.Drawing.Point(0, 58);
            this.lblWorkingdirectoy.Margin = new System.Windows.Forms.Padding(0);
            this.lblWorkingdirectoy.Name = "lblWorkingdirectoy";
            this.lblWorkingdirectoy.Size = new System.Drawing.Size(95, 13);
            this.lblWorkingdirectoy.TabIndex = 2;
            this.lblWorkingdirectoy.Text = "Arbeitsverzeichnis:";
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkingDirectory.Location = new System.Drawing.Point(3, 74);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(418, 20);
            this.txtWorkingDirectory.TabIndex = 3;
            this.txtWorkingDirectory.TextChanged += new System.EventHandler(this.txtWorkingDirectory_TextChanged);
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(0, 19);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(61, 13);
            this.lblFilename.TabIndex = 0;
            this.lblFilename.Text = "Dateiname:";
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(3, 35);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(418, 20);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.TextChanged += new System.EventHandler(this.txtFilename_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(424, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(26, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.btnBrowseWorkingDirectory);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnBrowseFilename);
            this.panel1.Controls.Add(this.lblFilename);
            this.panel1.Controls.Add(this.txtFilename);
            this.panel1.Controls.Add(this.lblArguments);
            this.panel1.Controls.Add(this.txtWorkingDirectory);
            this.panel1.Controls.Add(this.txtArguments);
            this.panel1.Controls.Add(this.lblWorkingdirectoy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 139);
            this.panel1.TabIndex = 9;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(0, 3);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "lblDescription";
            // 
            // ProcessXmlControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProcessXmlControl";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(465, 149);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseWorkingDirectory;
        private System.Windows.Forms.Button btnBrowseFilename;
        private System.Windows.Forms.Label lblArguments;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label lblWorkingdirectoy;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
    }
}
