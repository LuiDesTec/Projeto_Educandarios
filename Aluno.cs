using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; private set; }
        public  BoletimNotas boletim { get; set; }//

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            SetIdade(idade);//
        }
        public Aluno(string nome)
        {
            this.Nome = nome;
            this.Idade = 1000;
        }
        public void SetIdade(int idade)
        {
            if (idade <= 0)
            {

                idade = 1; //

            }
            if (idade > 1000)
            {
                idade = 1000;
            }

            this.Idade = idade;

        }
    }
}
