using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ModeloAnamneseViewModel
    {
        public ModeloAnamneseViewModel()
        {
            this.Perguntas = new List<PerguntasAnamneseViewModel>();
        }

        [Key]
        [ScaffoldColumn(false)]
        public int ModeloId { get; set; }

        [Required(ErrorMessage = "O campo nome do modelo é obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Padrão da Clínica")]
        public bool PadraodaClinica { get; set; }
        public string CNPJClinica { get; set; }        
        public IEnumerable<PerguntasAnamneseViewModel> Perguntas { get; set; }
        public bool Marcado { get; set; }

    }
}