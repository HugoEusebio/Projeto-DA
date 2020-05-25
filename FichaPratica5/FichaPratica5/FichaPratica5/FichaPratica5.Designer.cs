namespace FichaPratica4
{
    partial class FichaPratica5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.tbSymmetricKeyDecrypted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBitSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSymmetricKeyEncrtypted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.tbSymmentricKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSavePublicPrivateKey = new System.Windows.Forms.Button();
            this.buttonSavePublicKey = new System.Windows.Forms.Button();
            this.tbBothKeys = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateKeys = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonDecrypt);
            this.panel1.Controls.Add(this.tbSymmetricKeyDecrypted);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbBitSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbSymmetricKeyEncrtypted);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonEncrypt);
            this.panel1.Controls.Add(this.tbSymmentricKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 169);
            this.panel1.TabIndex = 15;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(369, 129);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(116, 23);
            this.buttonDecrypt.TabIndex = 9;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // tbSymmetricKeyDecrypted
            // 
            this.tbSymmetricKeyDecrypted.Location = new System.Drawing.Point(138, 133);
            this.tbSymmetricKeyDecrypted.Name = "tbSymmetricKeyDecrypted";
            this.tbSymmetricKeyDecrypted.Size = new System.Drawing.Size(225, 20);
            this.tbSymmetricKeyDecrypted.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Decrypted Symmetric Key";
            // 
            // tbBitSize
            // 
            this.tbBitSize.Location = new System.Drawing.Point(12, 93);
            this.tbBitSize.Name = "tbBitSize";
            this.tbBitSize.Size = new System.Drawing.Size(100, 20);
            this.tbBitSize.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number of Bits";
            // 
            // tbSymmetricKeyEncrtypted
            // 
            this.tbSymmetricKeyEncrtypted.Location = new System.Drawing.Point(138, 39);
            this.tbSymmetricKeyEncrtypted.Multiline = true;
            this.tbSymmetricKeyEncrtypted.Name = "tbSymmetricKeyEncrtypted";
            this.tbSymmetricKeyEncrtypted.Size = new System.Drawing.Size(348, 74);
            this.tbSymmetricKeyEncrtypted.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encrypted Symmetric Key";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(369, 7);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(117, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // tbSymmentricKey
            // 
            this.tbSymmentricKey.Location = new System.Drawing.Point(138, 9);
            this.tbSymmentricKey.Name = "tbSymmentricKey";
            this.tbSymmentricKey.Size = new System.Drawing.Size(225, 20);
            this.tbSymmentricKey.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Symmetric Key to Encrypt";
            // 
            // buttonSavePublicPrivateKey
            // 
            this.buttonSavePublicPrivateKey.Location = new System.Drawing.Point(368, 131);
            this.buttonSavePublicPrivateKey.Name = "buttonSavePublicPrivateKey";
            this.buttonSavePublicPrivateKey.Size = new System.Drawing.Size(138, 23);
            this.buttonSavePublicPrivateKey.TabIndex = 14;
            this.buttonSavePublicPrivateKey.Text = "Save PrivatePublicKey.txt";
            this.buttonSavePublicPrivateKey.UseVisualStyleBackColor = true;
            this.buttonSavePublicPrivateKey.Click += new System.EventHandler(this.buttonSavePublicPrivateKey_Click);
            // 
            // buttonSavePublicKey
            // 
            this.buttonSavePublicKey.Location = new System.Drawing.Point(368, 38);
            this.buttonSavePublicKey.Name = "buttonSavePublicKey";
            this.buttonSavePublicKey.Size = new System.Drawing.Size(139, 23);
            this.buttonSavePublicKey.TabIndex = 13;
            this.buttonSavePublicKey.Text = "Save PublicKey.txt";
            this.buttonSavePublicKey.UseVisualStyleBackColor = true;
            this.buttonSavePublicKey.Click += new System.EventHandler(this.buttonSavePublicKey_Click);
            // 
            // tbBothKeys
            // 
            this.tbBothKeys.Location = new System.Drawing.Point(16, 160);
            this.tbBothKeys.Multiline = true;
            this.tbBothKeys.Name = "tbBothKeys";
            this.tbBothKeys.Size = new System.Drawing.Size(492, 119);
            this.tbBothKeys.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Private / Public Key";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(16, 67);
            this.tbPublicKey.Multiline = true;
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.Size = new System.Drawing.Size(492, 53);
            this.tbPublicKey.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Public Key";
            // 
            // buttonGenerateKeys
            // 
            this.buttonGenerateKeys.Location = new System.Drawing.Point(16, 17);
            this.buttonGenerateKeys.Name = "buttonGenerateKeys";
            this.buttonGenerateKeys.Size = new System.Drawing.Size(199, 23);
            this.buttonGenerateKeys.TabIndex = 8;
            this.buttonGenerateKeys.Text = "Generate Keys (Private / Public)";
            this.buttonGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateKeys.Click += new System.EventHandler(this.buttonGenerateKeys_Click);
            // 
            // FichaPratica5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSavePublicPrivateKey);
            this.Controls.Add(this.buttonSavePublicKey);
            this.Controls.Add(this.tbBothKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPublicKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGenerateKeys);
            this.Name = "FichaPratica5";
            this.Text = "Ficha Prática 5";
            this.Load += new System.EventHandler(this.FichaPratica5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.TextBox tbSymmetricKeyDecrypted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBitSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSymmetricKeyEncrtypted;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox tbSymmentricKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSavePublicPrivateKey;
        private System.Windows.Forms.Button buttonSavePublicKey;
        private System.Windows.Forms.TextBox tbBothKeys;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenerateKeys;
    }
}

