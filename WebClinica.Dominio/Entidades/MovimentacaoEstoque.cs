using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class MovimentacaoEstoque
    {
        public int MovimentacaoId { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime Data { get; set; }
        public int tipoMovimentoId { get; set; }
        public int ProdutoID { get; set; }
        public int Qtde { get; set; }   
        public decimal ValorUnitario { get; set; }
        public string Observacao { get; set; }
        public string CNPJClinica { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public Produto Produto { get; set; }


    }
}
