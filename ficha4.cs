using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ficha_4
{
    public partial class Form1 : Form
    {
        public List<Coisa> coisaList = null;
        public Form1()
        {
            InitializeComponent();
            coisaList = new List<Coisa>();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listboxNome.Items.Add(txtNome.Text.Trim());
            txtNome.Text = string.Empty;
        }

        private void buttonBaralhar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int tamanhoLista = listboxNome.Items.Count;
            int random = 0;
            for (int i = 0; i < numeroAddNomes.Value; i++)
            {
                random = rnd.Next(0, tamanhoLista);
                coisaList.Add(new Coisa(listboxNome.Items[random].ToString));
            }
            Atualizalista();
        }
        

        private void buttonDarValores_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (Coisa item in coisaList)
            {
                item.ValorList.Add(rnd.Next(0, 100));
            }

        }
        private void Atualizalista()
        {
            listBoxBalburdia.DataSource = null;
            listBoxBalburdia.DataSource = coisaList;
        }

    }
}
