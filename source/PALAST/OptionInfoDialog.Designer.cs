namespace PALAST
{
    partial class OptionInfoDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionInfoDialog));
            this._Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _Label
            // 
            resources.ApplyResources(this._Label, "_Label");
            this._Label.Name = "_Label";
            // 
            // OptionInfoDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Label);
            this.Name = "OptionInfoDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _Label;

    }
}