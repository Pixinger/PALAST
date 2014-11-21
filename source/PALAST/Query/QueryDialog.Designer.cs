namespace PALAST.Query
{
    partial class QueryDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryDialog));
            this.lblNameData = new System.Windows.Forms.Label();
            this.lblMissionData = new System.Windows.Forms.Label();
            this.lvwPlayers = new System.Windows.Forms.ListView();
            this.clhIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstDetails = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameData
            // 
            this.lblNameData.AutoSize = true;
            this.lblNameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameData.Location = new System.Drawing.Point(12, 9);
            this.lblNameData.Name = "lblNameData";
            this.lblNameData.Size = new System.Drawing.Size(79, 13);
            this.lblNameData.TabIndex = 1;
            this.lblNameData.Text = "lblNameData";
            // 
            // lblMissionData
            // 
            this.lblMissionData.AutoSize = true;
            this.lblMissionData.ForeColor = System.Drawing.Color.Red;
            this.lblMissionData.Location = new System.Drawing.Point(12, 27);
            this.lblMissionData.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblMissionData.Name = "lblMissionData";
            this.lblMissionData.Size = new System.Drawing.Size(75, 13);
            this.lblMissionData.TabIndex = 7;
            this.lblMissionData.Text = "lblMissionData";
            // 
            // lvwPlayers
            // 
            this.lvwPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhIndex,
            this.clhName,
            this.clhScore,
            this.clhDuration});
            this.lvwPlayers.GridLines = true;
            this.lvwPlayers.Location = new System.Drawing.Point(239, 45);
            this.lvwPlayers.Name = "lvwPlayers";
            this.lvwPlayers.Size = new System.Drawing.Size(412, 386);
            this.lvwPlayers.TabIndex = 10;
            this.lvwPlayers.UseCompatibleStateImageBehavior = false;
            this.lvwPlayers.View = System.Windows.Forms.View.Details;
            // 
            // clhIndex
            // 
            this.clhIndex.Text = "Rang";
            this.clhIndex.Width = 40;
            // 
            // clhName
            // 
            this.clhName.Text = "Name";
            this.clhName.Width = 200;
            // 
            // clhScore
            // 
            this.clhScore.Text = "Punkte";
            this.clhScore.Width = 70;
            // 
            // clhDuration
            // 
            this.clhDuration.Text = "Zeit (min.)";
            this.clhDuration.Width = 70;
            // 
            // lstDetails
            // 
            this.lstDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDetails.FormattingEnabled = true;
            this.lstDetails.IntegralHeight = false;
            this.lstDetails.Location = new System.Drawing.Point(12, 45);
            this.lstDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lstDetails.Name = "lstDetails";
            this.lstDetails.Size = new System.Drawing.Size(221, 386);
            this.lstDetails.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(612, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(39, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // QueryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 443);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstDetails);
            this.Controls.Add(this.lvwPlayers);
            this.Controls.Add(this.lblMissionData);
            this.Controls.Add(this.lblNameData);
            this.Name = "QueryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serverinformationen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameData;
        private System.Windows.Forms.Label lblMissionData;
        private System.Windows.Forms.ListView lvwPlayers;
        private System.Windows.Forms.ColumnHeader clhIndex;
        private System.Windows.Forms.ColumnHeader clhName;
        private System.Windows.Forms.ColumnHeader clhScore;
        private System.Windows.Forms.ColumnHeader clhDuration;
        private System.Windows.Forms.ListBox lstDetails;
        private System.Windows.Forms.Button btnRefresh;
    }
}