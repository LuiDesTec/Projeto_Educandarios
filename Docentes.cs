using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Docentes : IPessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string IdentidadeGenero { get; set; }
        public int Idade { get; private set; }
        public Curso Curso { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Docentes(string nome, string sexo, int idade, string identidadeGenero)
        {
            IdentidadeGenero = identidadeGenero;
            this.Nome = nome;
            this.Sexo = sexo;
            this.idadedocente(idade);
        }


        public void idadedocente(int idade)
        {
            if (idade >= 18)
            {

                Idade = idade;

            }
            this.Idade = idade;
        }

        public string GetNome(string nome)
        {
            Nome = nome;
            return Nome;
        }

        public string GetIdade()
        {

            {
                DateTime date = DateTime.Now;


                return date.Year - DataDeNascimento.Year + "anos";
            }


        }

        public string GetPapel()
        {
            throw new NotImplementedException();
        }

    }
}



    