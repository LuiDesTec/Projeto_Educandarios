using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante
{
    public class BoletimNotas
    {
        public BoletimNotas()
        {
            Disciplinas = new List<Disciplina>();
        }
        public List<Disciplina> Disciplinas { get; set; }
        
        public string getListaDisciplinas()
        {
            string relatorio = "";
            foreach (var disciplina in this.Disciplinas)
            {
                relatorio = relatorio + disciplina.Nome + ";";
            }
            return relatorio;
        
        }
    }
}
