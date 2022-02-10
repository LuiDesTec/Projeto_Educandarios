using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public  class Aluno : Pessoa
    {
        public Aluno(string nome, string sexo,  DateTime datanascimento) 
            : base(nome, sexo, datanascimento)
        {
        }

        public string Matricula { get; set; }// Precisaria ter uma relação com a classe Matricula aqui?
               

        public  BoletimNotas boletim { get; set; }

        public void SetMatricula(String Matricula)
        {
            this.Matricula = Matricula;

        }

    

        

        //public string GetIdade()
        //{
        //    DateTime date3 = DateTime.Now;
        //    return date3.Year - DataDeNascimento.Year + " anosh";
        //}

        

        
    }
}
