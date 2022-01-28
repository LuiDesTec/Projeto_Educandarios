using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }


        public void SetDados(string logradouro, string numero, string cep, string cidade, string estado)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.CEP = cep;
            this.Cidade = cidade;
            this.Estado = estado;


        }
        public override string ToString()
        {
            return Logradouro + " " + Numero + " " + CEP + " " + Cidade + " " + Estado;
        }

    }


}


