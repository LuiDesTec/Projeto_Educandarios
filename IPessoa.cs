using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public interface IPessoa
    {
        void SetPessoa(string nome, string sexo, DateTime datanascimento);
        string GetNome();
        string GetIdade();
        string GetSexo();







    }
}
