using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Parcelamento
    {
        public int ParcelamentoId { get; set; }
        public int TituloId { get; set; }
        public int Parcela { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencto { get; set; }

        

    }
}
