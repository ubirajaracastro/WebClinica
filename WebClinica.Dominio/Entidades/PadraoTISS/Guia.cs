using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    public class Guia
    {
        public int ID { get; set; }
        public int TipoGuiaID { get; set; }
        public string NumeroPrestador { get; set; }
        public string NumeroOperadora { get; set; }
        public DateTime DataEmissao { get; set; }
        public int ConvenioID { get; set; }
        public int BeneficiarioID { get; set; }
        public int ContratadoID { get; set; }
        public int ProfissionalID { get; set; }
        public string HipoteseDiagnosticaID { get; set; }
        public int AtendimentoID { get; set; }
        public string Observacao { get; set; }
        
    }
}
