using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ProcedimentoCobrancaConvenioViewModel
    {
        public int ProcedimentoId { get; set; }
        public int ConvenioId { get; set; }
        public string NomeConvenio { get; set; }
        public decimal ValorConvenio { get; set; }
        public decimal ValorPaciente { get; set; }
        public bool Ativo { get; set; }

    }
}