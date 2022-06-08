using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class ConvenioViewModel
    {
        public ConvenioViewModel()
        {
            this.ProfissionaisQueAceitam = new List<ProfissionalViewModel>();
            this.Procedimentos = new List<ProcedimentoViewModel>();
        }
        public int ConvenioID { get; set; }

        [Required(ErrorMessage = "O campo Nome do Convênio é obrigatório.")]
        [Display(Name = "Convênio")]
        public string NomeConvenio { get; set; }

        [Display(Name = "Número do Registro ANS")]
        [Required(ErrorMessage = "O campo Número do Registro na ANS é obrigatório.")]
        public string NumeroRegistroANS { get; set; }

        public string CGC { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Contato é obrigatório.")]
        [Display(Name = "Contato")]
        public string Contato { get; set; }
        public string CNPJClinica { get; set; }

        [Display(Name = "Deixar Convênio Inativo")]
        public bool Ativo { get; set; }
        public string Site { get; set; }

        [DataType(DataType.MultilineText)]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "O campo Tabela do Convênio é obrigatório.")]
        public int TabelaId { get; set; }
        public string NumeroContrato { get; set; }
        public bool CalcularExtraCirurgia { get; set; }
        public string HorarioSemanalHoraExtra { get; set; }
        public string HorarioFinalSemanaHoraExtra { get; set; }
        public bool AtendeRadiologia { get; set; }
      
        [Range(0, double.MaxValue, ErrorMessage = "Entre com um número no formato moeda correto.")]
        public decimal? ValorFilme { get; set; }

        public bool PagamentoAdicionalMedico { get; set; }
        public decimal PercentualSobConsulta { get; set; }
        public decimal PercentualSobProcedimento { get; set; }

        [Range(4,15, ErrorMessage ="A quantidade miníma de digítos da carteira é 5 e máxima 15")]
        [Required(ErrorMessage = "O campo Dígitos da Carteira do Convênio é obrigatório.")]
        public int NroDigitosCarteira { get; set; }

        [Required(ErrorMessage = "O campo Prazo de Pagamento do Convênio é obrigatório.")]
        public int QteDiasFaturamento { get; set; }
                
        public string NumeroJuntoaoConvenio { get; set; }
        public DateTime DataCadastro { get; set; }
        public string CNPClinica { get; set; }
        public PlanoViewModel Plano { get; set; }

        public IEnumerable<ProfissionalViewModel> ProfissionaisQueAceitam { get; set; }
        public IEnumerable<ProcedimentoViewModel> Procedimentos { get; set; }
        public IEnumerable<ConvenioProfissionalQueAtendeViewModel> ProfissionaisQueAtendem { get; set; }
      

    }
}
