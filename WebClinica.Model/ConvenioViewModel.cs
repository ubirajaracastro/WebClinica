using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Model
{
    public class ConvenioViewModel
    {
        public ConvenioViewModel()
        {
            this.ProfissionaisQueAceitam = new List<Profissional>();
            this.Procedimentos = new List<Procedimento>();
        }
        public int ConvenioID { get; set; }
        public string NomeConvenio { get; set; }
        public string NumeroRegistro { get; set; }
        public DateTime Validade { get; set; }
        public bool Faturar { get; set; }
        public string CNPClinica { get; set; }

        public IList<Profissional> ProfissionaisQueAceitam { get; set; }
        public IEnumerable<Procedimento> Procedimentos { get; set; }

    }
}
