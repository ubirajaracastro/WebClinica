using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class TipoMovimento
    {
        public int TipoMovimentoId { get; set; }
        public string Nome { get; set; }
        public int Movimento { get; set; } //entrada ou saida
        public bool Ativo { get; set; }
        public string CNPJClinica { get; set; }
    }
}
