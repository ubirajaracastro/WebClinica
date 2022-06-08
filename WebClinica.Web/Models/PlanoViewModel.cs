using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class PlanoViewModel
    {       
        [Display(Name = "Nome do Plano")]
        public string NomePlano { get; set; }

        public int? CodigoTabela { get; set; }
    }
}