using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebClinica.Comum.Enum;

namespace WebClinica.Web.Models
{
    public class PacienteDadosComplementaresViewModel
    {
        [Display(Name = "CNS(SUS)")]
        public string CNSSUS { get; set; }

        [Display(Name = "Escolaridade")]
        public int? EscolaridadeId { get; set; }

        [Display(Name = "Profissão")]
        
        public int? ProfissaoId { get; set; }

        [Display(Name = "Fator Sanguíneo")]
        public int? FatorSanguineo { get; set; }

        [Display(Name = "Estado Civil")]
        public int EstadoCivilId { get; set; }

        [Display(Name = "Etnia")]
        public int EtniaId { get; set; }

        [Display(Name = "Tipo de Convênio")]
        [Required(ErrorMessage = "O campo Tipo do Convênio é obrigatório.")]
        public int TipoConvenioID { get; set; }

        [Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }

        [Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Nome do Cônjugue")]
        public string NomeConjugue { get; set; }
        public string Responsavel { get; set; }

        [Display(Name = "Indicado Por")]
        public string Indicacao { get; set; }
        public string Hobby { get; set; }
        public int PacienteId { get; set; }
        public string RG { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Etnia Etnia { get; set; }
        public TipoConvenio TipoConvenio { get; set; }


    }
}