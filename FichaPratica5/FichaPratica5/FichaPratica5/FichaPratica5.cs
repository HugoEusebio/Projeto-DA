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
    public partial class FichaPratica5 : Form
    {
        public FichaPratica5()
        {
            InitializeComponent();
        }

        //Variavel para guardar o par de chaves
        private RSACryptoServiceProvider rsa;

        private void buttonGenerateKeys_Click(object sender, EventArgs e)
        {
            //Criar novo par de chaves
            rsa = new RSACryptoServiceProvider();
            //Guardar chave publica e privada em XML
            string chavePublica = rsa.ToXmlString(false);
            string chavePrivada = rsa.ToXmlString(true);

            tbPublicKey.Text = chavePublica;
            tbBothKeys.Text = chavePrivada;
        }

        private void buttonSavePublicKey_Click(object sender, EventArgs e)
        {
            //Escrever para o ficheiro public.txt o texto que esta na textbox
            File.WriteAllText("public.txt", tbPublicKey.Text);
        }

        private void buttonSavePublicPrivateKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText("private.txt", tbBothKeys.Text);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            // Guardar a chave simetric que esta na textbox
            string chaveSimetrica = tbSymmentricKey.Text;

            // Converter a chave simetrica para bytes
            byte[] chaveSimetricaBytes = Encoding.UTF8.GetBytes(chaveSimetrica);

            // Cifrar chave simetrica com a chave publica
            byte[] chaveSimetricaCifradaBytes = rsa.Encrypt(chaveSimetricaBytes, true);

            // Converter chave simetrica cifrada em bytes para Base64
            tbSymmetricKeyEncrtypted.Text = Convert.ToBase64String(chaveSimetricaCifradaBytes);

            //Converter a chave simetrica cifrada em array de bytes e mostrar
            tbBitSize.Text = (chaveSimetricaCifradaBytes.Length *8).ToString();

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            // Ir buscar a chave simetrica a textbox
            string chaveSimetricaCifrada = tbSymmetricKeyDecrypted.Text;

            // Converter de Base64 para bytes
            byte[] chaveSimetricaCifradaBytes = Convert.FromBase64String(chaveSimetricaCifrada);

            //Decifrar a chave simetrica utilizando a chave privada
            byte[] chaveSimetricaBytes = rsa.Decrypt(chaveSimetricaCifradaBytes, true);

            // Converter de bytes para string e por na textbox
            tbSymmetricKeyDecrypted.Text = Encoding.UTF8.GetString(chaveSimetricaBytes);
        }

        private void FichaPratica5_Load(object sender, EventArgs e)
        {

        }
    }
}