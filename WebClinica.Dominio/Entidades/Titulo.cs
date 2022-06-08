using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Titulo
    {
        public Titulo()
        {
            this.Parcelas = new List<Parcelamento>();
        }
        public int TituloId { get; set; }
        public int FaturaId { get; set; }
        public DateTime Data { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaId { get; set; }
        public int ContaId { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencto { get; set; }
        public decimal Valor { get; set; }
        public int DocumentoId { get; set; }
        public string Descricao { get; set; }
        public bool ContaParcelada { get; set; }
        public int NroParcelas { get; set; }
        public decimal ValorParcela { get; set; }
        public int ProfissionalId { get; set; }
        public string TipoLancamento { get; set; }
        public string CNPJClinica { get; set; }

        public bool PagarNoAto { get; set; }
        public DateTime DataPagto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorAcrescimo { get; set; }

        public Profissional Profissional { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public CategoriaCentroCusto CategoriaCentroCusto { get; set; }
        public Fatura Fatura { get; set; }
        public ContaCorrente Conta { get; set; }
        public List<Parcelamento> Parcelas { get; set; }




    }
}
