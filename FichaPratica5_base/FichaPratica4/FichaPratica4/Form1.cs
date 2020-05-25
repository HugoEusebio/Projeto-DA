using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FichaPratica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        RSACryptoServiceProvider rsa;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGenerateKeys_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider();

            string publickey = rsa.ToXmlString(false);

            string bothkeys = rsa.ToXmlString(true);

            tbPublicKey.Text = publickey;
            tbBothKeys.Text = bothkeys;
        }

        private void buttonSavePublicKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText("public.txt", tbPublicKey.Text);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string keyS = tbSymmentricKey.Text;
            byte[] dados = Encoding.UTF8.GetBytes(keyS);

            byte[] dadosEnc = rsa.Encrypt(dados, true);

            tbSymmetricKeyEncrtypted.Text = Convert.ToBase64String(dadosEnc);
            tbBitSize.Text = (dadosEnc.Length * 8).ToString();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string keyEnc = tbSymmetricKeyEncrtypted.Text;
            byte[] dados = Convert.FromBase64String(keyEnc);
            byte[] dadosDec = rsa.Decrypt(dados, true);
            tbSymmetricKeyDecrypted.Text = Encoding.UTF8.GetString(dados);
        }
    }
}
