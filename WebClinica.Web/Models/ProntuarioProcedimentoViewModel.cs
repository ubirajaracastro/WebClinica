using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class ProntuarioProcedimentoViewModel
    {     
        [Display(Name = "Código")]
        public string CodigoProcedimento { get; set; }

        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
    }
}