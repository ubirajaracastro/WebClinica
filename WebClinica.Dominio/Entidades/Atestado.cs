using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Atestado
    {
        public int AtestadoId { get; set; }
        public string TituloImpressao { get; set; }
        public string Texto { get; set; }       
        public string CNPJClinica { get; set; }       
        
    }
}

