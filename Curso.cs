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

        public void setDisciplinas (Disciplina disciplinas) 
        
        {   
             
            
            this.Disciplinas.Add( disciplinas);
        }
    
    
    
    
    
    
    }
    

    
}
