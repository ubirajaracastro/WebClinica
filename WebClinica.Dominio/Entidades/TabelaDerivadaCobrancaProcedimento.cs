using System;

namespace WebClinica.Dominio.Entidades
{
    public class TabelaDerivadaCobrancaProcedimento
    {
        public int TabelaDerivadaCobrancaProcedimentoID { get; set; }
        public string NomeTabela { get; set; }
        public int TabelaBaseID { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}
