﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Escola
    {
        public string Nome { get; private set; }

        public List<Aluno> Alunos { get; private set; }

        public Endereco Endereco { get; private set; }

        public List<Matricula> Matriculas { get; private set; } = new List<Matricula>();





        public Escola(string nomedaescola)
        {
            this.Nome = nomedaescola;
            this.Alunos = new List<Aluno>();//Garantir que tenha a lista de alunos.
            this.Endereco = new Endereco(); // Para garantir a criação do endereço.

        }

        public Aluno AddAluno(string nome, int idade)
        {

            // gerar o numero da matricula randomicamente de 0 a 2000
            string matricula = new Random().Next(0, 2000).ToString();


            var aluno = new Aluno(nome, idade, matricula);

            this.Alunos.Add(aluno);

            return this.Alunos.LastOrDefault();






        }


        public Endereco EscolaEndereco(string logradouro, string numero, string cidade, string estado, string cep)
        {



            this.Endereco.SetDados(logradouro, numero, cidade, estado, cep);

            return this.Endereco;

        }

        



        public Matricula SetMatricular(Aluno aluno, Curso curso)


        {


            Matricula matricula = new Matricula();
            matricula.Alunocursos(aluno, curso);
            this.Matriculas.Add(matricula);

            return matricula;

        }




    }
}
