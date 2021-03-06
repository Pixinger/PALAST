﻿namespace PALAST.RSM
{
    partial class ManagerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDialog));
            this._ToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnStart = new System.Windows.Forms.ToolStripButton();
            this.tbtnSetup = new System.Windows.Forms.ToolStripButton();
            this.tbtnStop = new System.Windows.Forms.ToolStripButton();
            this.tbtnMissionUpload = new System.Windows.Forms.ToolStripButton();
            this._StatusStrip = new System.Windows.Forms.StatusStrip();
            this.slblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblStatusData = new System.Windows.Forms.ToolStripStatusLabel();
            this._AddonList = new PALAST.AddonList();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.slblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this._ToolStrip.SuspendLayout();
            this._StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ToolStrip
            // 
            this._ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnRefresh,
            this.toolStripSeparator2,
            this.tbtnStart,
            this.tbtnSetup,
            this.tbtnStop,
            this.toolStripSeparator1,
            this.tbtnMissionUpload});
            this._ToolStrip.Location = new System.Drawing.Point(0, 0);
            this._ToolStrip.Name = "_ToolStrip";
            this._ToolStrip.Size = new System.Drawing.Size(490, 25);
            this._ToolStrip.TabIndex = 0;
            this._ToolStrip.Text = "toolStrip1";
            // 
            // tbtnRefresh
            // 
            this.tbtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnRefresh.Enabled = false;
            this.tbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tbtnRefresh.Image")));
            this.tbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnRefresh.Name = "tbtnRefresh";
            this.tbtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.tbtnRefresh.Text = "Aktualisieren";
            this.tbtnRefresh.Click += new System.EventHandler(this.tbtnRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbtnStart
            // 
            this.tbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnStart.Enabled = false;
            this.tbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tbtnStart.Image")));
            this.tbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStart.Name = "tbtnStart";
            this.tbtnStart.Size = new System.Drawing.Size(23, 22);
            this.tbtnStart.Text = "Starten";
            this.tbtnStart.Click += new System.EventHandler(this.tbtnStart_Click);
            // 
            // tbtnSetup
            // 
            this.tbtnSetup.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbtnSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSetup.Image = ((System.Drawing.Image)(resources.GetObject("tbtnSetup.Image")));
            this.tbtnSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSetup.Name = "tbtnSetup";
            this.tbtnSetup.Size = new System.Drawing.Size(23, 22);
            this.tbtnSetup.Text = "Einstellungen";
            this.tbtnSetup.Click += new System.EventHandler(this.tbtnSetup_Click);
            // 
            // tbtnStop
            // 
            this.tbtnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnStop.Enabled = false;
            this.tbtnStop.Image = ((System.Drawing.Image)(resources.GetObject("tbtnStop.Image")));
            this.tbtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStop.Name = "tbtnStop";
            this.tbtnStop.Size = new System.Drawing.Size(23, 22);
            this.tbtnStop.Text = "Stoppen";
            this.tbtnStop.Click += new System.EventHandler(this.tbtnStop_Click);
            // 
            // tbtnMissionUpload
            // 
            this.tbtnMissionUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMissionUpload.Enabled = false;
            this.tbtnMissionUpload.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMissionUpload.Image")));
            this.tbtnMissionUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMissionUpload.Name = "tbtnMissionUpload";
            this.tbtnMissionUpload.Size = new System.Drawing.Size(23, 22);
            this.tbtnMissionUpload.Text = "Mission hochladen";
            this.tbtnMissionUpload.Click += new System.EventHandler(this.tbtnMissionUpload_Click);
            // 
            // _StatusStrip
            // 
            this._StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.slblName,
            this.toolStripStatusLabel2,
            this.slblStatus,
            this.slblStatusData});
            this._StatusStrip.Location = new System.Drawing.Point(0, 226);
            this._StatusStrip.Name = "_StatusStrip";
            this._StatusStrip.Size = new System.Drawing.Size(490, 24);
            this._StatusStrip.TabIndex = 2;
            this._StatusStrip.Text = "statusStrip1";
            // 
            // slblStatus
            // 
            this.slblStatus.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.slblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblStatus.Name = "slblStatus";
            this.slblStatus.Size = new System.Drawing.Size(46, 19);
            this.slblStatus.Text = "Status:";
            // 
            // slblStatusData
            // 
            this.slblStatusData.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblStatusData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.slblStatusData.Name = "slblStatusData";
            this.slblStatusData.Size = new System.Drawing.Size(120, 19);
            this.slblStatusData.Text = "Verbindungsaufbau...";
            this.slblStatusData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _AddonList
            // 
            this._AddonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._AddonList.ImageChecked = ((System.Drawing.Image)(resources.GetObject("_AddonList.ImageChecked")));
            this._AddonList.ImageUnchecked = ((System.Drawing.Image)(resources.GetObject("_AddonList.ImageUnchecked")));
            this._AddonList.Location = new System.Drawing.Point(0, 25);
            this._AddonList.Name = "_AddonList";
            this._AddonList.SelectedIndex = -1;
            this._AddonList.Size = new System.Drawing.Size(490, 201);
            this._AddonList.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // slblName
            // 
            this.slblName.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.slblName.Name = "slblName";
            this.slblName.Size = new System.Drawing.Size(28, 19);
            this.slblName.Text = "###";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(46, 19);
            this.toolStripStatusLabel1.Text = "Server:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 19);
            // 
            // ManagerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 250);
            this.Controls.Add(this._AddonList);
            this.Controls.Add(this._StatusStrip);
            this.Controls.Add(this._ToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Server Manager";
            this._ToolStrip.ResumeLayout(false);
            this._ToolStrip.PerformLayout();
            this._StatusStrip.ResumeLayout(false);
            this._StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _ToolStrip;
        private AddonList _AddonList;
        private System.Windows.Forms.StatusStrip _StatusStrip;
        private System.Windows.Forms.ToolStripButton tbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbtnStart;
        private System.Windows.Forms.ToolStripButton tbtnStop;
        private System.Windows.Forms.ToolStripButton tbtnSetup;
        private System.Windows.Forms.ToolStripStatusLabel slblStatusData;
        private System.Windows.Forms.ToolStripStatusLabel slblStatus;
        private System.Windows.Forms.ToolStripButton tbtnMissionUpload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel slblName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}