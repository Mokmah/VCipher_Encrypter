namespace Vigenere_Crypter
{
    partial class CipherForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.lblEncode = new System.Windows.Forms.Label();
            this.lblDecode = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(32, 64);
            this.txtEncode.Multiline = true;
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(177, 89);
            this.txtEncode.TabIndex = 0;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(215, 64);
            this.txtDecode.Multiline = true;
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.ReadOnly = true;
            this.txtDecode.Size = new System.Drawing.Size(177, 89);
            this.txtDecode.TabIndex = 1;
            // 
            // lblEncode
            // 
            this.lblEncode.AutoSize = true;
            this.lblEncode.Location = new System.Drawing.Point(29, 45);
            this.lblEncode.Name = "lblEncode";
            this.lblEncode.Size = new System.Drawing.Size(93, 13);
            this.lblEncode.TabIndex = 2;
            this.lblEncode.Text = "Message Source :";
            // 
            // lblDecode
            // 
            this.lblDecode.AutoSize = true;
            this.lblDecode.Location = new System.Drawing.Point(212, 45);
            this.lblDecode.Name = "lblDecode";
            this.lblDecode.Size = new System.Drawing.Size(104, 13);
            this.lblDecode.TabIndex = 3;
            this.lblDecode.Text = "Message Résultant :";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(69, 158);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(101, 32);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "Encrypter";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(252, 158);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(105, 32);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Décrypter";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(153, 15);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 6;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(116, 18);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(28, 13);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "Clé :";
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 202);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.lblDecode);
            this.Controls.Add(this.lblEncode);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.txtEncode);
            this.Name = "CipherForm";
            this.Text = "Encrypteur Vigenère par William Garneau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label lblEncode;
        private System.Windows.Forms.Label lblDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
    }
}

