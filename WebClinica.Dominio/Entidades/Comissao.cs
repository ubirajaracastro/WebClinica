using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
   public class EntidadeComissao
    {    
        public string CNPJClinica { get; set; }
        public int ComissaoId { get; set; }
        public string DescricaoComissao { get; set; }
        public bool Ativo  { get; set; }
        public int ConvenioId { get; set; }
        public int ProcedimentoId { get; set; }     
        public decimal ValorComissao { get; set; }
        public int ProfissionalId { get; set; }
        public Procedimento Procedimento { get; set; }
        public Convenio Convenio { get; set; }
        public Profissional Profissional { get; set; }

    }
}
