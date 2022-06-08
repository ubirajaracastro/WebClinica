using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class PacienteViewModel
    {
        public PacienteViewModel()
        {
            DadosComplementares = new PacienteDadosComplementaresViewModel();
            Agendamentos = new List<AgendamentoViewModel>();
        }

        #region properties
        [ScaffoldColumn(false)]
        public int? PacienteId { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O campo Nome Completo é obrigatório.")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Validade")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ValidadeCarteira { get; set; }

        public string Password { get; set; }

        [Required(ErrorMessage = "O campo Sexo é obrigatório.")]
        public Sexo Sexo { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string CPF { get; set; }
        public string RG { get; set; }

        [Display(Name = "Número Carteira")]
        [Required(ErrorMessage = "O campo número da carteira do paciente é obrigatório.")]
        public string NumeroCarteira { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Estado de origem do paciente é obrigatório.")]
        [Display(Name = "Estado")]
        public int EstadoID { get; set; }

        //[Required(ErrorMessage = "O campo cidade do paciente é obrigatório.")]
        [Display(Name = "Cidade")]
        [ScaffoldColumn(false)]
        public int? CidadeID { get; set; }

        [Display(Name = "Selecione um Plano")]
        public int? ConvenioPlanoId { get; set; }
        public string Cep { get; set; }
        public string UrlFoto { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone Celular é obrigatório.")]
        [Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }

        [Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "Telefone Comercial")]
        public string TelefoneComercial { get; set; }

        [Display(Name = "Ramal")]
        public string TelefoneComercialRamal { get; set; }
        public string UrlImagemCartaoSaudePaciente { get; set; }
        public int TipoConvenioId { get; set; }
        public string Skype { get; set; }
        public PacienteDadosComplementaresViewModel DadosComplementares { get; set; }
        public List<AgendamentoViewModel> Agendamentos { get; set; }
        public List<OrcamentoViewModel> Orcamentos { get; set; }
        public List<ProntuarioViewModel> Prontuarios { get; set; }
        public List<SolicitacaoExameViewModel> SolicitacoesExame { get; set; }

        [ScaffoldColumn(false)]
        public int AtestadoID { get; set; }

        public string CNPJClinica { get; set; }

        [Display(Name = "Convênio")]
        [Required(ErrorMessage = "O campo Convênio é obrigatório.")]
        public int ConvenioId { get; set; }
       
        #endregion
    }

        #region Enums
    public enum Sexo
    {
        Masculino,
        Feminino
    }

    public enum EstadoCivil
    {
        Casado = 1,
        Divorciado = 2,
        Solteiro = 3,
        Separado = 4,
        Viuvo = 5,
        UniaoEstavel = 6,
        NaoInformado = 7
    }

    public enum Etnia
    {
        Branca = 1,
        Parada = 2,
        Negra = 3,
        Oriental = 5,
        Asiatica = 6,
        Indigena = 7,
        NaoDeclarada = 8

    }

    public enum TipoConvenio
    {
        Empresarial = 1,
        Individual = 2,       

    }
    #endregion
}