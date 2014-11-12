﻿namespace PALAST
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
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chbCloseAfterLaunch = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArmaExe
            // 
            this.txtArmaExe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArmaExe.Location = new System.Drawing.Point(12, 25);
            this.txtArmaExe.Name = "txtArmaExe";
            this.txtArmaExe.ReadOnly = true;
            this.txtArmaExe.Size = new System.Drawing.Size(508, 20);
            this.txtArmaExe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programmdatei (arma.exe):";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(526, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.chbCheckForUpdates);
            this.grpOptions.Controls.Add(this.chbCloseAfterLaunch);
            this.grpOptions.Location = new System.Drawing.Point(12, 51);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(545, 71);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Optionen";
            // 
            // chbCloseAfterLaunch
            // 
            this.chbCloseAfterLaunch.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbCloseAfterLaunch.Location = new System.Drawing.Point(6, 19);
            this.chbCloseAfterLaunch.Name = "chbCloseAfterLaunch";
            this.chbCloseAfterLaunch.Size = new System.Drawing.Size(595, 20);
            this.chbCloseAfterLaunch.TabIndex = 0;
            this.chbCloseAfterLaunch.Text = "Das Programm beenden, nachdem Arma gestartet wurde.";
            this.chbCloseAfterLaunch.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbCloseAfterLaunch.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(401, 128);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(482, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // chbCheckForUpdates
            // 
            this.chbCheckForUpdates.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbCheckForUpdates.Location = new System.Drawing.Point(6, 45);
            this.chbCheckForUpdates.Name = "chbCheckForUpdates";
            this.chbCheckForUpdates.Size = new System.Drawing.Size(595, 20);
            this.chbCheckForUpdates.TabIndex = 1;
            this.chbCheckForUpdates.Text = "Automatisch nach Updates suchen";
            this.chbCheckForUpdates.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(569, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArmaExe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.grpOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArmaExe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chbCloseAfterLaunch;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chbCheckForUpdates;
    }
}