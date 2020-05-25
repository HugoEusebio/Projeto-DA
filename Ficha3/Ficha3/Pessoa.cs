using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha3
{
    class Pessoa
    {
        public string Nome { get; set; }
       public DateTime Dtnascimento { get; set; }
       public string Morada { get; set; }
       public int Pontuacao { get; set; }

        public Pessoa(string nome, DateTime dtnascimento, string morada, int pontuacao)
        {
            Nome = nome;
            Dtnascimento = dtnascimento;
            Morada = morada;
            Pontuacao = 0;

        }

        public int Idade()
        {
            int idade = DateTime.Now.Year - Dtnascimento.Year;
            if (Dtnascimento.DayOfYear < DateTime.Now.DayOfYear)
            {
                idade--;

            }
            return idade;

        }
        public void pontuar (int valor )
        {
            Pontuacao += valor;
        }

        public override string ToString()
        {
            return Nome + "(" + Idade().ToString() + "):" + Pontuacao.ToString();
        }
    }
}
