using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class ComissaoViewModel
    {
        public ComissaoViewModel()
        {         
            this.Ativo = true;

        }

        [ScaffoldColumn(false)]
        public string CNPJClinica { get; set; }

        [Key]
        [ScaffoldColumn(false)]
        public int ComissaoId { get; set; }

        [Display(Name = "Descrição da Comissão")]
        [Required(ErrorMessage = "O campo Descrição da Comissão é obrigatório.")]
        public string DescricaoComissao { get; set; }
        public bool Ativo { get; set; }

        [Display(Name = "Convênio")]
        [Required(ErrorMessage = "Selecione um Convênio.")]
        public int ConvenioId { get; set; }

        [Display(Name = "Procedimento")]
        [Required(ErrorMessage = "Selecione um Procedimento do Convênio para aplicar a comissão.")]
        public int ProcedimentoId { get; set; }

        [Display(Name = "Valor Comissão Por Procedimento Efetuado")]
        [Required(ErrorMessage = "Digite o valor da comissão.")]
        public decimal ValorComissao { get; set; }

        [Display(Name = "Profissional")]
        [Required(ErrorMessage = "Selecione um Profissonal.")]
        public int ProfissionalId { get; set; }

        public string NomeProfissional { get; set; }
        public string NomeProcedimento { get; set; }
        public string NomeConvenio { get; set; }

        

    }
}