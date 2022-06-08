using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class TabelaDerivadaCobrancaProcedimentoViewModel
    {
        [ScaffoldColumn(false)]
        public int TabelaDerivadaCobrancaProcedimentoID { get; set; }

        [Display(Name = "Código do Procedimento")]
        [Required(ErrorMessage = "O Campo Código do Procedimento é obrigatório.")]
        public int CodigoProcedimento { get; set; }


        [Display(Name = "Nome da Tabela")]
        [Required(ErrorMessage = "O Campo Nome da Tabela é obrigatório.")]
        public string NomeTabela { get; set; }       

        [Display(Name = "Novo Valor")]
        [Required(ErrorMessage = "O Campo Valor do Procedimento é obrigatório.")]
        public decimal NovoValorAcordado { get; set; }

        [Display(Name = "Valor do Custo Operacional")]
        public decimal? ValorUCO { get; set; }
        public int? TabelaBaseID { get; set; }
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Procedimento")]
        public string NomeProcedimento { get; set; }
    }
}