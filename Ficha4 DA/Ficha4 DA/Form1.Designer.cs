namespace Ficha4_DA
{
    partial class Form1
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
            this.labelNome = new System.Windows.Forms.Label();
            this.richTextBoxNome = new System.Windows.Forms.RichTextBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.buttonBaralhar = new System.Windows.Forms.Button();
            this.richTextBoxBalburdia = new System.Windows.Forms.RichTextBox();
            this.labelBalburdia = new System.Windows.Forms.Label();
            this.buttonDarValores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(43, 38);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // richTextBoxNome
            // 
            this.richTextBoxNome.Location = new System.Drawing.Point(46, 73);
            this.richTextBoxNome.Name = "richTextBoxNome";
            this.richTextBoxNome.Size = new System.Drawing.Size(173, 191);
            this.richTextBoxNome.TabIndex = 1;
            this.richTextBoxNome.Text = "";
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(46, 296);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(108, 20);
            this.textBoxAdd.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(171, 292);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Iteraçoes";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(296, 153);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 5;
            this.domainUpDown1.Text = "domainUpDownBalburdia";
            // 
            // buttonBaralhar
            // 
            this.buttonBaralhar.Location = new System.Drawing.Point(296, 179);
            this.buttonBaralhar.Name = "buttonBaralhar";
            this.buttonBaralhar.Size = new System.Drawing.Size(120, 58);
            this.buttonBaralhar.TabIndex = 6;
            this.buttonBaralhar.Text = "Baralhar";
            this.buttonBaralhar.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBalburdia
            // 
            this.richTextBoxBalburdia.Location = new System.Drawing.Point(476, 73);
            this.richTextBoxBalburdia.Name = "richTextBoxBalburdia";
            this.richTextBoxBalburdia.Size = new System.Drawing.Size(312, 191);
            this.richTextBoxBalburdia.TabIndex = 7;
            this.richTextBoxBalburdia.Text = "";
            // 
            // labelBalburdia
            // 
            this.labelBalburdia.AutoSize = true;
            this.labelBalburdia.Location = new System.Drawing.Point(476, 54);
            this.labelBalburdia.Name = "labelBalburdia";
            this.labelBalburdia.Size = new System.Drawing.Size(51, 13);
            this.labelBalburdia.TabIndex = 8;
            this.labelBalburdia.Text = "Balburdia";
            // 
            // buttonDarValores
            // 
            this.buttonDarValores.Location = new System.Drawing.Point(479, 271);
            this.buttonDarValores.Name = "buttonDarValores";
            this.buttonDarValores.Size = new System.Drawing.Size(309, 23);
            this.buttonDarValores.TabIndex = 9;
            this.buttonDarValores.Text = "Dar Valores";
            this.buttonDarValores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDarValores);
            this.Controls.Add(this.labelBalburdia);
            this.Controls.Add(this.richTextBoxBalburdia);
            this.Controls.Add(this.buttonBaralhar);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.richTextBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.RichTextBox richTextBoxNome;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Button buttonBaralhar;
        private System.Windows.Forms.RichTextBox richTextBoxBalburdia;
        private System.Windows.Forms.Label labelBalburdia;
        private System.Windows.Forms.Button buttonDarValores;
    }
}

