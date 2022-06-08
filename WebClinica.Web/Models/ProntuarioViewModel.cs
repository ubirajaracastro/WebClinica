using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ProntuarioViewModel
    {
        public ProntuarioViewModel()
        {
            Perguntas = new List<PerguntasAnamneseViewModel>();
            Procedimentos = new List<ProntuarioProcedimentoViewModel>();
        }
        public int AtendimentoId { get; set; }
        public AtestadoViewModel Atestado { get; set; }
        public int PacienteID { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Preencha o campo Queixa Principal.")]
        public string QueixaPrincipal { get; set; }

        [Required(ErrorMessage = "Preencha o campo Conduta.")]
        public string Conduta { get; set; }
        public string tipoConsultaCodigo { get; set; }       
        public int ExameFisicoId { get; set; }
        public int AtestadoId { get; set; }       
        public string CID { get; set; }

        [Display(Name = "CID")]
        [Required(ErrorMessage = "Preencha o campo CID.")]
        public string DescricaoCID { get; set; }

        [Display(Name = "Prescrição")]
        public string PrescricaoMedica { get; set; }
        public string CodigoProcedimento { get; set; }
        public decimal ValorProcedimento { get; set; }
        public bool RecemNascido { get; set; }
        public DateTime Data { get; set; }
        public string CNPJClinica { get; set; }       
        public int ModeloAnamneseID { get; set; }
        public ExameFisicoViewModel ExameFisico { get; set; }
        public List<ProntuarioProcedimentoViewModel> Procedimentos { get; set; }
        public List<PerguntasAnamneseViewModel> Perguntas { get; set; }
        

    }
}