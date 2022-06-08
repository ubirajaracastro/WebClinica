using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class PerguntasAnamneseViewModel
    {      
        public bool Marcado { get; set; }
        public int? PerguntaId { get; set; }
        public int? RespostaId { get; set; }
        public string Descricao { get; set; }
        public bool Selecionada { get; set; }
    }
}