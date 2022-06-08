using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ItemComissaoViewModel
    {
        public string NomeConvenio { get; set; }
        public string NomeProcedimento { get; set; }
        public string NomeProfissional { get; set; }
        public decimal ValorComissao { get; set; }       
        public int ConvenioId { get; set; }
        public int ProfissionalId { get; set; }
        public int ProcedimentoId { get; set; }
        public string Descricao { get; set; }
        
    }
}