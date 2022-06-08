using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ProntuarioProcedimento
    {
        public int ProntuarioProcedimentoID { get; set; }
        public int AtendimentoID { get; set; }
        public string CodigoProcedimento { get; set; }        
    }
}
