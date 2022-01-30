using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Matricula
    {
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Docentes Docente { get; set; }


        public void Alunocursos (Aluno aluno, Curso curso)
        {
            this.Aluno = aluno;
            this.Curso = curso;
        }
        
        public void DocenteCurso (Docentes docente, Curso curso)
        {
           
            {
                this.Docente = docente;
                this.Curso = curso;
            }
        }
    
    }
}
