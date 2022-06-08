using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 52 - Terminologia de tipo de consulta*/
    public class Tabela52
    {
        public int ID { get; set; }
        public string CodTermo { get; set; }
        public string Termo { get; set; }
        public string NumeroTabela { get; set; }

    }
}
