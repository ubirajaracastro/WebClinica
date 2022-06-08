using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public int UnidadeMedidaId { get; set; }
        public string Descricao { get; set; }
        public string CodigodeBarras { get; set; }
        public int EstoqueMinimo { get; set; }
        public int GrupoId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataEntrada { get; set; }
        public string  CNPJClinica { get; set; }

        public UnidadeMedida UnidadeMedida { get; set; }
        public GrupoProduto GrupoProduto { get; set; }

    }
}
