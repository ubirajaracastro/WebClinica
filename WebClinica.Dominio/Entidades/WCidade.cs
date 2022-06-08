using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class WCidade
    {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }

    }
}
