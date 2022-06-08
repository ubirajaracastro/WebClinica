using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class RespostaPerguntaAnamnese
    {
        public int RespostaId { get; set; }
        public string DescricaoResposta { get; set; }
        public int TipoPerguntaID { get; set; }
        public PerguntasAnamnese PerguntasAnamnese { get; set; }


    }
}
