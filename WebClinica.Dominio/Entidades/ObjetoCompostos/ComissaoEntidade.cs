using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades.ObjetoCompostos
{
    public class ComissaoEntidade
    {
        public int ComissaoId { get; set; }
        public string Descricao { get; set; }
        public string NomeConvenio { get; set; }
        public string NomeProcedimento { get; set; }
        public string NomeProfissional { get; set; }
        public decimal ValorComissao { get; set; }
    }
}
