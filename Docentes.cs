using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Docentes
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string IdentidadeGenero { get; set; }
        public int Idade { get; private set; }
        public Curso Curso { get; set; }  

        public Docentes (string nome, string sexo, int idade, string identidadeGenero)
        {   
            IdentidadeGenero = identidadeGenero;
            this.Nome = nome;
            this.Sexo = sexo;
            this. idadedocente(idade);
        }
        

        public void idadedocente(int idade) 
        {
            if (idade >= 18)
            {

                Idade = idade;

            }
            this.Idade = idade;
        }
    
    
    
    }
}