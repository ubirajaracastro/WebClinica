using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class PerguntasAnamnese
    {
        public PerguntasAnamnese()
        {         
            Respostas = new List<RespostaPerguntaAnamnese>();           
        }

        public int PerguntaId { get; set; }
        public string Descricao { get; set; }
        public int TipoPergunta { get; set; }
        public List<RespostaPerguntaAnamnese> Respostas { get; set; }
        
    }
}
