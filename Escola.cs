using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Escola
    {
        public string Nome { get; private set; }

        public List<Aluno> Alunos { get; private set; }

        public Endereco Endereco { get; private set; }







        public Escola(string nomedaescola)
        {
            this.Nome = nomedaescola;
            this.Alunos = new List<Aluno>();
            this.Endereco = new Endereco();
            
        }

        public Aluno AddAluno(string nome, int idade)
        {

            // gerar o numero da matricula randomicamente de 0 a 2000
            string matricula = new Random().Next(0, 2000).ToString();


            var aluno = new Aluno(nome, idade, matricula);

            this.Alunos.Add(aluno);

            return this.Alunos.LastOrDefault();

            


           

        }


        public Endereco EscolaEndereco(string logradouro, string numero, string cidade, string estado, string cep)
        {


                
            this.Endereco.SetDados(logradouro, numero, cidade, estado, cep);

            return this.Endereco;

        }

    }
}
