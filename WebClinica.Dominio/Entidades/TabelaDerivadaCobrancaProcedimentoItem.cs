using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class TabelaDerivadaCobrancaProcedimentoItem
    {
        public int TabelaDerivadaCobrancaProcedimentoItemID { get; set; }              
        public int CodigoProcedimento { get; set; }       
        public decimal ValorUCO { get; set; }        
        public decimal NovoValor { get; set; }
        public TabelaDerivadaCobrancaProcedimento Tabela { get; set; }
       


    }
}
