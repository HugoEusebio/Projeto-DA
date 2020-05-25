
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string morada = textBoxMorada.Text;
            string nome = textBoxNome.Text;
            DateTime datanascimento = monthcalender1.SelectionStart;
            Pessoa pessoa = new Pessoa(nome, datanascimento, morada ,0);
            listBox1.Items.Add(pessoa);
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = (Pessoa)listBox1.SelectedItem;
            pessoa.pontuar(10);
            listBox1.Items[listBox1.SelectedIndex] = pessoa;

        }
    }
}
