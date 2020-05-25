using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ficha_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            try
            {
                float resultados;
                resultados = Convert.ToInt32(textBoxN1.Text) / Convert.ToInt32(textBoxN2.Text);
                textBoxResultado.Text = resultados.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("erro" + ex.Message);
            }
        }

        private void buttonlerficheiro_Click(object sender, EventArgs e)
        {
            try
            {
                int posicao;
                int tamanho;

                posicao = Convert.ToInt32(numericUpDown1.Value);
                tamanho = Convert.ToInt32(numericUpDown2.Value);
                string nomeFicheiro = "Ficheiro.txt";

                char[] ficheiroTexto = File.ReadAllText(nomeFicheiro).Skip(posicao).Take(tamanho).ToArray();

                for (int i= 0; i < tamanho; i++)
                {
                    char linha = ficheiroTexto[i];
                    textBoxResultado.Text += linha;
                }
            }catch(FileNotFoundException ex)
            {
                MessageBox.Show("erro: " + ex.Message);
            }
        }

    }
}
