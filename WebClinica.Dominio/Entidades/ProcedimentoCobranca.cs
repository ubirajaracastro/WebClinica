using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ProcedimentoCobranca
    {
        public int ProcedimentoCobrancaId { get; set; }
        public int ProcedimentoId { get; set; }
        public int ConvenioId { get; set; }
        public decimal ValorPaciente { get; set; }
        public decimal ValorConvenio { get; set; }


    }
}
