using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Entidades
{
    public class ConvenioPlano
    {
        public int ConvenioPlanoID { get; set; }
        public int ConvenioID { get; set; }
        public string DescricaoPlano { get; set; }
        public DateTime DataCadastro { get; set; }
        public Convenio Convenio { get; set; }
        public int? TabelaID { get; set; }

    }
}
