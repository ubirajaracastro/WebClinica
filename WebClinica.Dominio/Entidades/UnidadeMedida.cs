using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class UnidadeMedida
    {
        public int UnidadeId { get; set; }
        public string Nome { get; set; }
        public string Abreviatura { get; set; }

        public string CNPJClinica { get; set; }

    }
}
