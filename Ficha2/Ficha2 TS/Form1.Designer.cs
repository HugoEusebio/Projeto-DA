namespace Ficha2_TS
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcliente = new System.Windows.Forms.TextBox();
            this.textBoxservidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxmsg = new System.Windows.Forms.RichTextBox();
            this.richTextBoxresposta = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP servidor";
            // 
            // textBoxcliente
            // 
            this.textBoxcliente.Location = new System.Drawing.Point(108, 58);
            this.textBoxcliente.Name = "textBoxcliente";
            this.textBoxcliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxcliente.TabIndex = 1;
            // 
            // textBoxservidor
            // 
            this.textBoxservidor.Location = new System.Drawing.Point(411, 58);
            this.textBoxservidor.Name = "textBoxservidor";
            this.textBoxservidor.Size = new System.Drawing.Size(100, 20);
            this.textBoxservidor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Porto servidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensagem";
            // 
            // richTextBoxmsg
            // 
            this.richTextBoxmsg.Location = new System.Drawing.Point(91, 137);
            this.richTextBoxmsg.Name = "richTextBoxmsg";
            this.richTextBoxmsg.Size = new System.Drawing.Size(237, 96);
            this.richTextBoxmsg.TabIndex = 5;
            this.richTextBoxmsg.Text = "";
            // 
            // richTextBoxresposta
            // 
            this.richTextBoxresposta.Enabled = false;
            this.richTextBoxresposta.Location = new System.Drawing.Point(91, 294);
            this.richTextBoxresposta.Name = "richTextBoxresposta";
            this.richTextBoxresposta.Size = new System.Drawing.Size(237, 96);
            this.richTextBoxresposta.TabIndex = 6;
            this.richTextBoxresposta.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxresposta);
            this.Controls.Add(this.richTextBoxmsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxservidor);
            this.Controls.Add(this.textBoxcliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcliente;
        private System.Windows.Forms.TextBox textBoxservidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxmsg;
        private System.Windows.Forms.RichTextBox richTextBoxresposta;
        private System.Windows.Forms.Button button1;
    }
}

