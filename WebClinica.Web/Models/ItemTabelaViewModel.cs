using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ItemTabelaViewModel
    {
        public int Procedimento { get; set; }
        public string Tabela { get; set; }
        public decimal ValorUCO { get; set; }       
        public decimal NovoValor { get; set; }
        public int TabelaBaseID { get; set; }
    }
}