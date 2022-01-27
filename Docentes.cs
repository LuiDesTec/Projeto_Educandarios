using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    internal class Docentes
    {
        string Nome { get; set; }
        string Materias { get; set; }
        string Turmas { get; set; }
    
    
    
    public Docentes (string nome, string materia, string turma)
        {
            Nome = nome;
            Materias = materia;
            Turmas = turma;
        }
    
    
    
    }
}
//Escola não existe sem professor né. Nem que seja em video aulas.