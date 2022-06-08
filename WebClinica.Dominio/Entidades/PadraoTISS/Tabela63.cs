using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 63 - Grupos de procedimentos e itens assistenciais para envio de dados para ANS*/
    public class Tabela63
    {
        public int ID { get; set; }
        public string CodTermo { get; set; }
        public string Grupo { get; set; }
        public string NumeroTabela { get; set; }
    }
}
