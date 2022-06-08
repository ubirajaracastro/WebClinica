using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.PadraoTISS
{
    /*TUSS - Tabela 64 - Forma de envio para ANS de procedimentos e itens assistenciais.*/
    public class Tabela64
    {
        public int ID { get; set; }
        public string Terminologia { get; set; }
        public string CodigoTUSS { get; set; }
        public string FormaEnvio { get; set; }
        public string CodigoGrupo { get; set; }
        public string DescricaoGrupo { get; set; }
        public string NumeroTabela { get; set; }
    }
}
