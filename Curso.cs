using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Curso
    {
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();

        public void setDisciplinas (Disciplina disciplina)         
        {            
            this.Disciplinas.Add(disciplina);
        }

        public void setDisciplinas(string nomedisciplina)
        {
            Disciplina disciplina = new Disciplina(nomedisciplina);
            
            this.Disciplinas.Add(disciplina);
        }

        // "altereu o codigo "



    }
    

    
}
