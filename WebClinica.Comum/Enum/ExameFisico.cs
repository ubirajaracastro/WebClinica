using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Comum.Enum
{
    public class ExameFisico
    {
        public enum Tipo
        {
            Admissional = 1,
            Periodico = 2,
            RetornoaoTrabalho = 3,
            MudancadeFuncao = 4,
            Demissional = 5,

        }
    }
}
