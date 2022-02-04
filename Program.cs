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


            Aluno idadealuno = new Aluno("",0,"");
            idadealuno.DataDeNascimento = new DateTime(2018, 2, 3);
            Console.WriteLine(idadealuno.GetIdade());

            var EducandarioLuiz = new Escola("Endereco");

            EducandarioLuiz.EscolaEndereco("Rua sao Mateus", "1", "salvador", "ba", "41334140");           


            var EducandarioSavastane = new Escola("Educandário Savastane");            
            EducandarioSavastane.EscolaEndereco("Rua D. Aline ", "2", "salvador", "ba", "41400001");



            
           
            
            
            var luiz = EducandarioLuiz.AddAluno("Luiz", 10);
            var savastane = EducandarioLuiz.AddAluno("Savastane", 50);

            


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

            
            
            Console.WriteLine(luiz.Nome + ": " + luiz.boletim.getListaDisciplinas());
            Console.WriteLine(savastane.Nome + ": " + savastane.boletim.getListaDisciplinas());
            Console.WriteLine( "Escreva o Endereço das Escolas: ");
            Console.WriteLine(EducandarioLuiz.Endereco.ToString());
            Console.WriteLine(EducandarioSavastane.Endereco.ToString());
            Console.ReadKey();

        }
    }
}
