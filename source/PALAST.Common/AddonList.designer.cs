namespace PALAST
{
    partial class AddonList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddonList));
            this._Listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _Listbox
            // 
            this._Listbox.BackColor = System.Drawing.SystemColors.Window;
            this._Listbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this._Listbox, "_Listbox");
            this._Listbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._Listbox.FormattingEnabled = true;
            this._Listbox.Name = "_Listbox";
            this._Listbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._Listbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this._Listbox_MouseClick);
            this._Listbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._Listbox_DrawItem);
            this._Listbox.SelectedIndexChanged += new System.EventHandler(this._Listbox_SelectedIndexChanged);
            this._Listbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._Listbox_KeyDown);
            // 
            // AddonList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Listbox);
            this.DoubleBuffered = true;
            this.Name = "AddonList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox _Listbox;

    }
}
