namespace PALAST.RSM
{
    partial class TokenDialog
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
            this.txtClientToken = new System.Windows.Forms.TextBox();
            this.lblClientToken = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbnOK = new System.Windows.Forms.Button();
            this._ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientToken
            // 
            this.txtClientToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientToken.Location = new System.Drawing.Point(23, 25);
            this.txtClientToken.Name = "txtClientToken";
            this.txtClientToken.Size = new System.Drawing.Size(638, 20);
            this.txtClientToken.TabIndex = 1;
            this.txtClientToken.TextChanged += new System.EventHandler(this.txtClientToken_TextChanged);
            // 
            // lblClientToken
            // 
            this.lblClientToken.AutoSize = true;
            this.lblClientToken.Location = new System.Drawing.Point(20, 9);
            this.lblClientToken.Name = "lblClientToken";
            this.lblClientToken.Size = new System.Drawing.Size(41, 13);
            this.lblClientToken.TabIndex = 0;
            this.lblClientToken.Text = "Token:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(586, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbnOK
            // 
            this.tbnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbnOK.Location = new System.Drawing.Point(505, 51);
            this.tbnOK.Name = "tbnOK";
            this.tbnOK.Size = new System.Drawing.Size(75, 23);
            this.tbnOK.TabIndex = 2;
            this.tbnOK.Text = "OK";
            this.tbnOK.UseVisualStyleBackColor = true;
            // 
            // _ErrorProvider
            // 
            this._ErrorProvider.ContainerControl = this;
            // 
            // TokenDialog
            // 
            this.AcceptButton = this.tbnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(684, 88);
            this.Controls.Add(this.tbnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblClientToken);
            this.Controls.Add(this.txtClientToken);
            this.Name = "TokenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Remote Server Setup";
            ((System.ComponentModel.ISupportInitialize)(this._ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientToken;
        private System.Windows.Forms.Label lblClientToken;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button tbnOK;
        private System.Windows.Forms.ErrorProvider _ErrorProvider;
    }
}