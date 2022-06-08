using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class GrupoProduto
    {
        public int GrupoId { get; set; }
        public int DescricaoGrupo { get; set; }
        public string CNPJClinica { get; set; }
    }
}
