using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 60 - Terminologia de unidade de medida*/
    public class Tabela60
    {
        public int ID { get; set; }
        public string CodTermo { get; set; }
        public string Termo { get; set; }
        public string DescricaoDetalhada { get; set; }
        public string NumeroTabela { get; set; }
    }
}
