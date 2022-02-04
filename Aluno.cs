using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public  class Aluno : IPessoa
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }// Precisaria ter uma relação com a classe Matricula aqui?
        public string Sexo { get; set; }
        public string IdentidadeGenero { get; set; }
        public int Idade { get; private set; }
        public DateTime DataDeNascimento { get; set; }

        public  BoletimNotas boletim { get; set; }

        public Aluno(string nome, int idade, string matricula)
        {
            Matricula = matricula;
            Nome = nome;
            SetIdade(idade);
        }
        public Aluno(string nome)
        {
            this.Nome = nome;
            this.Idade = 1000;
        }

        public void SetMatricula(String Matricula)
        {
            this.Matricula = Matricula;

        }

        public void SetIdade(int idade)
        {
            if (idade <= 0)
            {

                idade = 1; 

            }
            if (idade > 1000)
            {
                idade = 1000;
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
            DateTime date3 = DateTime.Now;
           

           
            
            return date3.Year - DataDeNascimento.Year + "anos";
        }

        public string GetPapel()
        {
            throw new NotImplementedException();
        }

        
    }
}
