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
           






            var EducandarioLuiz = new Escola("Educandário Luíz");
           
            EducandarioLuiz.Endereco.Logradouro = "Rua são Mateus";
            EducandarioLuiz.Endereco.Numero = "2";
            EducandarioLuiz.Endereco.Cidade= "Salvador";
            EducandarioLuiz.Endereco.CEP= "21456465";
            EducandarioLuiz.Endereco.Estado= "Bahia";


            var EducandarioSavastane = new Escola("Educandário Savastane");



            var luiz = EducandarioLuiz.AddAluno("Luiz", 10);
            var savastane = EducandarioLuiz.AddAluno("Savastane", 50);

            


            var portugues = new Disciplina("portugues");
            var matematica = new Disciplina("matematica");
            var ciencias = new Disciplina("ciencias");
            var fisica = new Disciplina("fisica");

            
            
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
            
            
            Console.ReadKey();

        }
    }
}
