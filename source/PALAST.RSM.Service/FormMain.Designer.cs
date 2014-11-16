namespace PALAST.RSM.Service
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
            this._NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmenOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenCloseGameServers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmenSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenPrefixSetup = new System.Windows.Forms.ToolStripMenuItem();
            this._ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _NotifyIcon
            // 
            this._NotifyIcon.ContextMenuStrip = this._ContextMenuStrip;
            this._NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_NotifyIcon.Icon")));
            this._NotifyIcon.Text = "PALAST RSM Service";
            this._NotifyIcon.Visible = true;
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmenOnline,
            this.cmenCloseGameServers,
            this.toolStripMenuItem2,
            this.cmenSetup,
            this.cmenPrefixSetup,
            this.toolStripMenuItem1,
            this.cmenClose});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(209, 148);
            // 
            // cmenOnline
            // 
            this.cmenOnline.Name = "cmenOnline";
            this.cmenOnline.Size = new System.Drawing.Size(208, 22);
            this.cmenOnline.Text = "Online";
            this.cmenOnline.Click += new System.EventHandler(this.cmenOnline_Click);
            // 
            // cmenCloseGameServers
            // 
            this.cmenCloseGameServers.Enabled = false;
            this.cmenCloseGameServers.Name = "cmenCloseGameServers";
            this.cmenCloseGameServers.Size = new System.Drawing.Size(208, 22);
            this.cmenCloseGameServers.Text = "Alle Gameserver beenden";
            this.cmenCloseGameServers.Click += new System.EventHandler(this.cmenCloseGameServers_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(205, 6);
            // 
            // cmenSetup
            // 
            this.cmenSetup.Name = "cmenSetup";
            this.cmenSetup.Size = new System.Drawing.Size(208, 22);
            this.cmenSetup.Text = "Einstellungen";
            this.cmenSetup.Click += new System.EventHandler(this.cmenSetup_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // cmenClose
            // 
            this.cmenClose.Name = "cmenClose";
            this.cmenClose.Size = new System.Drawing.Size(208, 22);
            this.cmenClose.Text = "Beenden";
            this.cmenClose.Click += new System.EventHandler(this.cmenClose_Click);
            // 
            // cmenPrefixSetup
            // 
            this.cmenPrefixSetup.Name = "cmenPrefixSetup";
            this.cmenPrefixSetup.Size = new System.Drawing.Size(208, 22);
            this.cmenPrefixSetup.Text = "Prefix festlegen";
            this.cmenPrefixSetup.Click += new System.EventHandler(this.cmenPrefixSetup_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PALAST RSM Service";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this._ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon _NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cmenCloseGameServers;
        private System.Windows.Forms.ToolStripMenuItem cmenSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmenClose;
        private System.Windows.Forms.ToolStripMenuItem cmenOnline;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cmenPrefixSetup;
    }
}

