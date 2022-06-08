using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Comum.Enum
{
    public class PerguntaAnamnese
    {
        public enum Pergunta
        {
            DATA=1,
            DESCRITIVACURTA=2,
            DESCRITIVALONGA=3,
            MULTIPLAESCOLHA=4,
            OBJETIVA=5,
            NUMERICA=6
            

        }
    }
}
