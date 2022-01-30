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



        public void Alunocursos(Aluno aluno, Curso curso)
        {
            this.Aluno = aluno;
            this.Curso = curso;
        }

    }