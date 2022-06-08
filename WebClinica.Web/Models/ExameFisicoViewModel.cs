using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ExameFisicoViewModel
    {              
        public decimal? Peso { get; set; }

        [Display(Name = "Frequência Respiratória")]
        public decimal? FrequenciaRespiratoria { get; set; }
        public decimal? Altura { get; set; }

        public decimal? IMC { get; set; }

        [Display(Name = "Frequência Cardíaca")]
        public decimal? FrequenciaCardiaca { get; set; }

        [Display(Name = "Pressão aterial sistótica")]
        public decimal? PressãoArterialsistotica { get; set; }
        public decimal? Temperatura { get; set; }

        [Display(Name = "Pressão arterial diastólica")]
        public decimal? PressãoArterialdiastolica { get; set; }
        public decimal? Hemoglucoteste { get; set; }
       
    }
}