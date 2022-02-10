using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Funcionario : Pessoa, IPessoa, IFuncao
    {
        public Funcionario(string nome, string sexo, DateTime datanascimento)
    : base(nome, sexo, datanascimento)
        {
            this.Nome = "Funcionario(a) " + nome;
        }

        public string GetFuncao()
        {
            return "Funcionario";
        }
    }
}
