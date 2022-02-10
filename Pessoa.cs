using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        
        public DateTime DataDeNascimento { get; set; }

        public Pessoa(string nome, string sexo, DateTime datanascimento)
        {
            this.Nome = nome;   
            this.Sexo = sexo;   
            
            this.DataDeNascimento = datanascimento;

        }

        public void SetPessoa(string nome, string sexo, DateTime datanascimento)
        {
            this.Nome = nome;
            this.Sexo = sexo;
            this.DataDeNascimento = datanascimento;
        }

        public string GetIdade()
        {   
            return DateTime.Now.Year - DataDeNascimento.Year + " years old";
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetSexo()
        {
            return this.Sexo;
        }

   

     
    }
}
