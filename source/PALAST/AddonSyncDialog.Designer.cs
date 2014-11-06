namespace PALAST
{
    partial class AddonSyncDialog
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstActions = new System.Windows.Forms.ListBox();
            this.btnSynchronize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCompareRepositories = new System.Windows.Forms.Button();
            this.clstCompareResults = new System.Windows.Forms.CheckedListBox();
            this.lvwLog = new System.Windows.Forms.ListView();
            this.clhStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(12, 25);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(659, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Repository-Adresse:";
            // 
            // lstActions
            // 
            this.lstActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActions.FormattingEnabled = true;
            this.lstActions.IntegralHeight = false;
            this.lstActions.Location = new System.Drawing.Point(5, 448);
            this.lstActions.Margin = new System.Windows.Forms.Padding(5);
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(647, 157);
            this.lstActions.TabIndex = 6;
            // 
            // btnSynchronize
            // 
            this.btnSynchronize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSynchronize.Enabled = false;
            this.btnSynchronize.Location = new System.Drawing.Point(440, 672);
            this.btnSynchronize.Name = "btnSynchronize";
            this.btnSynchronize.Size = new System.Drawing.Size(150, 23);
            this.btnSynchronize.TabIndex = 1;
            this.btnSynchronize.Text = "Synchronisieren";
            this.btnSynchronize.UseVisualStyleBackColor = true;
            this.btnSynchronize.Click += new System.EventHandler(this.btnSynchronize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(596, 672);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Beenden";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCompareRepositories
            // 
            this.btnCompareRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompareRepositories.Enabled = false;
            this.btnCompareRepositories.Location = new System.Drawing.Point(334, 672);
            this.btnCompareRepositories.Name = "btnCompareRepositories";
            this.btnCompareRepositories.Size = new System.Drawing.Size(100, 23);
            this.btnCompareRepositories.TabIndex = 0;
            this.btnCompareRepositories.Text = "Überprüfen";
            this.btnCompareRepositories.UseVisualStyleBackColor = true;
            this.btnCompareRepositories.Click += new System.EventHandler(this.btnCompareRepositories_Click);
            // 
            // clstCompareResults
            // 
            this.clstCompareResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clstCompareResults.FormattingEnabled = true;
            this.clstCompareResults.IntegralHeight = false;
            this.clstCompareResults.Location = new System.Drawing.Point(5, 21);
            this.clstCompareResults.Margin = new System.Windows.Forms.Padding(5);
            this.clstCompareResults.Name = "clstCompareResults";
            this.clstCompareResults.Size = new System.Drawing.Size(647, 167);
            this.clstCompareResults.TabIndex = 5;
            this.clstCompareResults.SelectedIndexChanged += new System.EventHandler(this.clstCompareResults_SelectedIndexChanged);
            // 
            // lvwLog
            // 
            this.lvwLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhStatus,
            this.clhName});
            this.lvwLog.Location = new System.Drawing.Point(5, 211);
            this.lvwLog.Margin = new System.Windows.Forms.Padding(5);
            this.lvwLog.Name = "lvwLog";
            this.lvwLog.Size = new System.Drawing.Size(647, 214);
            this.lvwLog.TabIndex = 8;
            this.lvwLog.UseCompatibleStateImageBehavior = false;
            this.lvwLog.View = System.Windows.Forms.View.Details;
            // 
            // clhStatus
            // 
            this.clhStatus.Text = "Status";
            this.clhStatus.Width = 150;
            // 
            // clhName
            // 
            this.clhName.Text = "Dateiname";
            this.clhName.Width = 470;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Meldungen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vorgänge:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Addon Übersicht:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lvwLog);
            this.panel1.Controls.Add(this.clstCompareResults);
            this.panel1.Controls.Add(this.lstActions);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 612);
            this.panel1.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(12, 672);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddonSyncDialog
            // 
            this.AcceptButton = this.btnCompareRepositories;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(683, 703);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCompareRepositories);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSynchronize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Name = "AddonSyncDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddonSync";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstActions;
        private System.Windows.Forms.Button btnSynchronize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCompareRepositories;
        private System.Windows.Forms.CheckedListBox clstCompareResults;
        private System.Windows.Forms.ListView lvwLog;
        private System.Windows.Forms.ColumnHeader clhStatus;
        private System.Windows.Forms.ColumnHeader clhName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;

    }
}