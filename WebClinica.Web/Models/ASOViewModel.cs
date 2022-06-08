using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ASOViewModel
    {
        public string Empresa { get; set; }

        [Display(Name = "Profissional")]
        public int ProfissionalId { get; set; }

        [Display(Name = "Profissão")]
        public int ProfissaoId { get; set; }

        [Display(Name = "Exame Médico")]
        public int TipoExameMedicoId { get; set; }

        [Display(Name = "Exame Fisíco")]
        public int ExameFisicoId { get; set; }
        public ExameComplementarPCMSOViewModel ExameComplementarPCMSO { get; set; }
        public RiscoOcupacionalViewModel RiscoOcupacional { get; set; }

        [Display(Name = "Laudo segundo a NR 07")]
        public int LaudoNR7 { get; set; }

        [Display(Name = "Laudo segundo a NR 33")]
        public int LaudoNR33 { get; set; }

        [Display(Name = "Laudo segundo a NR 35")]
        public int LaudoNR35 { get; set; }
    }

}