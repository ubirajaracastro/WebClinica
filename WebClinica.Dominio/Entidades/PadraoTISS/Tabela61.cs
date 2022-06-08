using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 61 - Terminologia de via de acesso*/
    public class Tabela61
    {
        public int ID { get; set; }
        public string CodTermo { get; set; }
        public string Termo { get; set; }
        public string NumeroTabela { get; set; }
    }
}
