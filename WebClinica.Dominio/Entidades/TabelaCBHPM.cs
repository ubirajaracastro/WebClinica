using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class TabelaCBHPM
    {
        public long Codigo { get; set; }
        public string Procedimento { get; set; }
        public string Porte { get; set; }
        public decimal ValorPorte { get; set; }
        public int Auxiliares { get; set; }
        public decimal ValorUCO { get; set; }
        public int PorteAnestesico { get; set; }
        public int QtdeFilme { get; set; }
        public int Incidencia { get; set; }
        public decimal ValorTotal { get; set; }

    }
}
