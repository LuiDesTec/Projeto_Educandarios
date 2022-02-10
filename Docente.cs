﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Docente: Pessoa, IPessoa, IFuncao
    {
        
        
        public Curso Curso { get; set; }
        
        
        public Docente(string nome, string sexo, DateTime datanascimento) 
            : base(nome, sexo, datanascimento)    
        {
            this.Nome = "Professor(a) " + nome;
        }

        public string GetFuncao()
        {
            return "Professor(a) ";
        }
    }
}



    