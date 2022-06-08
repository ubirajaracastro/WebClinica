using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class CentroCusto
    {
        public int CentroCustoId { get; set; }
        public string DescricaoConta { get; set; }
        public bool Ativo { get; set; }
        public string CNPJClinica { get; set; }

    }
}
