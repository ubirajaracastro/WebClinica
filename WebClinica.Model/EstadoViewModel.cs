using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Model
{
    public class EstadoViewModel
    {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public int PaisId { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
