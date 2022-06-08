using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 30 - Terminologia de escala de capacidade funcional (ECOG - Escala de Zubrod)*/
    public class Tabela30
    {
        public int ID { get; set; }
        public string CodTermo { get; set; }
        public string Termo { get; set; }
        public string NumeroTabela { get; set; }
    }
}
