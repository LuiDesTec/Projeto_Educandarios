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

        public Matricula Matricula { get; private set; }





        public Escola(string nomedaescola)
        {
            this.Nome = nomedaescola;
            this.Alunos = new List<Aluno>();//Garantir que tenha a lista de alunos.
            this.Endereco = new Endereco(); // Para garantir a criação do endereço.
            
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

        /* Precisar de correções aí mais vê se a idéia é mais ou menos essa. Da uma olhada nas clasees o que 
         precisa ser ajustado. No caso coloquei o metodo só pra ver se conseguia gerá-los dentro da classe 
        escola. Mas vai precisar fazer os parametros receberem as disciplinas. Se não me engano.
        Agora é com meu Senior as analises profissionais. */



        public Matricula  SetMatricular ( Aluno aluno, Curso curso)


        {



            this.Matricula.Alunocursos(aluno, curso);

            return this.Matricula;

        }

        public Matricula SetLecionar (Docentes docentes, Curso curso)

        {



            this.Matricula.DocenteCurso(docentes , curso);

            return this.Matricula;

        }

    }
}
