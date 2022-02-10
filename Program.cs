using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Pessoa pessoalqualquer = new Pessoa("Savastane", "masculino",  new DateTime(1973, 07, 24));

            Console.WriteLine(pessoalqualquer.Nome);
            Console.WriteLine(pessoalqualquer.GetIdade());
            


            Aluno idadealuno = new Aluno("","", new DateTime(2018, 2, 3));
            
            Console.WriteLine(idadealuno.GetIdade());

            var EducandarioLuiz = new Escola("Endereco");

            EducandarioLuiz.EscolaEndereco("Rua sao Mateus", "1", "salvador", "ba", "41334140");           


            var EducandarioSavastane = new Escola("Educandário Savastane");            
            EducandarioSavastane.EscolaEndereco("Rua D. Aline ", "2", "salvador", "ba", "41400001");






            
            Aluno luiz = EducandarioLuiz.AddAluno("Luiz", "masculino", new DateTime(1976, 12, 13));
            var savastane = EducandarioLuiz.AddAluno("Savastane", "masculino" , new DateTime(1973, 7, 24));

            Console.WriteLine("luiz");
            Console.WriteLine(luiz.GetIdade());


            var portugues = new Disciplina("portugues");
            var matematica = new Disciplina("matematica");
            var ciencias = new Disciplina("ciencias");
            var fisica = new Disciplina("fisica");

            Curso Serie5 = new Curso();
            Serie5.setDisciplinas(portugues);
            Serie5.setDisciplinas(ciencias);
            Serie5.setDisciplinas(matematica);
            Serie5.setDisciplinas(fisica);

            Curso Serie4 = new Curso();
            Serie4.setDisciplinas("Redação");
            Serie4.setDisciplinas("Ingles");

            EducandarioLuiz.SetMatricular(luiz, Serie5);
            EducandarioLuiz.SetMatricular(savastane, Serie4);

            






            luiz.boletim = new BoletimNotas();
            luiz.boletim.Disciplinas.Add(portugues);
            luiz.boletim.Disciplinas.Add(matematica);
            luiz.boletim.Disciplinas.Add(ciencias);
            
            
            savastane.boletim = new BoletimNotas();
            savastane.boletim.Disciplinas.Add(portugues);
            savastane.boletim.Disciplinas.Add(matematica);
            savastane.boletim.Disciplinas.Add(ciencias);
            savastane.boletim.Disciplinas.Add(fisica);


            Docente professor = new Docente("Savastane", "masculino", new DateTime(1973, 07, 24));
            
            //Console.WriteLine(professor.GetNome());
            //Console.WriteLine(professor.GetIdade());
            //Console.WriteLine(professor.GetFuncao());

            Funcionario funcionario = new Funcionario("Savastane", "masculino", new DateTime(1973, 07, 24));

            //Console.WriteLine(funcionario.GetNome());
            //Console.WriteLine(funcionario.GetIdade());
            //Console.WriteLine(funcionario.GetFuncao());


            Aluno alunoluiz = EducandarioLuiz.AddAluno("Luiz", "masculino", new DateTime(1976, 12, 13));


            var Tipoclasse = EducandarioLuiz.AddPessoa(alunoluiz);
            Console.WriteLine(Tipoclasse);

            var Tipoclasse1 = EducandarioLuiz.AddPessoa(funcionario);
            Console.WriteLine(Tipoclasse1);



            IPessoa pessoalqualquer1 = new Aluno("Savastane", "masculino", new DateTime(1973, 07, 24));


            //Console.WriteLine(luiz.Nome + ": " + luiz.boletim.getListaDisciplinas());
            //Console.WriteLine(savastane.Nome + ": " + savastane.boletim.getListaDisciplinas());
            //Console.WriteLine( "Escreva o Endereço das Escolas: ");
            //Console.WriteLine(EducandarioLuiz.Endereco.ToString());
            //Console.WriteLine(EducandarioSavastane.Endereco.ToString());
            Console.ReadKey();

        }
    }
}
