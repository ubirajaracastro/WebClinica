using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ConvenioProfissional
    {
        public int ConvenioProfissionalId { get; set; }
        public int ConvenioId { get; set; }
        public int ProfissionalId { get; set; }
    }
}
