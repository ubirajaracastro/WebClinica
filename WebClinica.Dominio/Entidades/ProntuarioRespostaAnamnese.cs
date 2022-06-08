using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ProntuarioRespostaAnamnese
    {
        public int ID { get; set; }
        public int AtendimentoID { get; set; }
        public int PerguntaID { get; set; }
        public int RespostaID { get; set; }

    }
}
