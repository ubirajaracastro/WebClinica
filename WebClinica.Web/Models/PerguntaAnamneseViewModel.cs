using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class PerguntaAnamneseViewModel
    {
        public PerguntaAnamneseViewModel()
        {
            Modelos = new List<ModeloAnamneseViewModel>();

        }
        [Key]
        public int PerguntaId { get; set; }

        [Required(ErrorMessage = "O campo Descrição da Pergunta é obrigatório.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Tipo da Pergunta é obrigatório.")]
        [Display(Name = "Tipo de Pergunta")]
        public int TipoPergunta { get; set; }
        public List<ModeloAnamneseViewModel> Modelos { get; set; }
        public bool Selecionada { get; set; }


    }
}