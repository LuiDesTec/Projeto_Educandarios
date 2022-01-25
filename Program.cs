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

            
            var nada = new Disciplina("portugues");
            var matematica = new Disciplina("matematica");
            var ciencias = new Disciplina("ciencias");
            var fisica = new Disciplina("fisica");

            nada.Nome = "PORTUGUES1";

            Console.WriteLine(nada.Nome);


            Aluno luiz = new Aluno("Luiz", 50);
            luiz.boletim = new BoletimNotas();
            new Disciplina("joao");


            luiz.boletim.Disciplinas.Add(nada);
            luiz.boletim.Disciplinas.Add(matematica);
            luiz.boletim.Disciplinas.Add(ciencias);
            luiz.boletim.Disciplinas.Add(new Disciplina("História"));


            var savastane = new Aluno("Savastane", 50);



            savastane.boletim = new BoletimNotas();

            savastane.boletim.Disciplinas.Add(nada);
            savastane.boletim.Disciplinas.Add(matematica);
            savastane.boletim.Disciplinas.Add(ciencias);
            savastane.boletim.Disciplinas.Add(fisica);

            Console.WriteLine(luiz.Nome + ": " + luiz.boletim.getListaDisciplinas());
            Console.WriteLine(savastane.Nome + ": " + savastane.boletim.getListaDisciplinas());

        }
    }
}
