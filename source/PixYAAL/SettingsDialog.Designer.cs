namespace YAAL
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.txtArmaExe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grpPresets = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPreset = new System.Windows.Forms.ListBox();
            this.grpPresets.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArmaExe
            // 
            resources.ApplyResources(this.txtArmaExe, "txtArmaExe");
            this.txtArmaExe.Name = "txtArmaExe";
            this.txtArmaExe.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpPresets
            // 
            resources.ApplyResources(this.grpPresets, "grpPresets");
            this.grpPresets.Controls.Add(this.btnRemove);
            this.grpPresets.Controls.Add(this.btnRename);
            this.grpPresets.Controls.Add(this.btnClone);
            this.grpPresets.Controls.Add(this.btnAdd);
            this.grpPresets.Controls.Add(this.lstPreset);
            this.grpPresets.Name = "grpPresets";
            this.grpPresets.TabStop = false;
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRename
            // 
            resources.ApplyResources(this.btnRename, "btnRename");
            this.btnRename.Name = "btnRename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClone
            // 
            resources.ApplyResources(this.btnClone, "btnClone");
            this.btnClone.Name = "btnClone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPreset
            // 
            resources.ApplyResources(this.lstPreset, "lstPreset");
            this.lstPreset.FormattingEnabled = true;
            this.lstPreset.Name = "lstPreset";
            this.lstPreset.SelectedIndexChanged += new System.EventHandler(this.lstPreset_SelectedIndexChanged);
            // 
            // SettingsDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpPresets);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArmaExe);
            this.Name = "SettingsDialog";
            this.grpPresets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArmaExe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpPresets;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstPreset;
    }
}