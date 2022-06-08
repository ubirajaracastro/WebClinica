using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class TipodeConsultaViewModel
    {
        [Key]
        public int TipoConsultaId { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Faturar { get; set; }
        public string CNPJClinica { get; set; }
    }
}