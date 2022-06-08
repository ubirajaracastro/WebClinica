using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class RespostaPerguntaViewModel
    {
        public string DescricaoPergunta { get; set; }
        public int TipoPergunta { get; set; }
        public int RespostaId { get; set; }
        public string DescricaoResposta { get; set; }        
        public string Ativo { get; set; }
    }
}