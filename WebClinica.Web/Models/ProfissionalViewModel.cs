using System;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class ProfissionalViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProfissionalId { get; set; }

        [Required(ErrorMessage = "O Campo Email é obrigatório.")]
        public string Email { get; set; }
        
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        [Display(Name = "Profissao")]
        [Required(ErrorMessage = "O Campo Profissão é obrigatório.")]
        public string CodigoCBOOcupacao { get; set; }

        [Required(ErrorMessage = "O Campo Registro Profissional é obrigatório.")]
        public string CodigoUFConselhoProfisional { get; set; }

        [Required(ErrorMessage = "O Campo Nome do Profissional é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo CPF é obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O Campo Telefone é obrigatório.")]
        public string Telefone { get; set; }

        public string Endereco { get; set; }

        [Required(ErrorMessage = "O Campo Número do Registro Profissional é obrigatório.")]
        public string Registro { get; set; }
               
        public string Numero { get; set; }

        [Display(Name = "Orgão")]
        [Required(ErrorMessage = "O campo Orgão de Registro Profissional é obrigatório.")]
        public string CodigoConselhoProfissional { get; set; }

        public string Bairro { get; set; }
        public string Cep { get; set; }

        [Display(Name = "Estado")]      
        public int EstadoID { get; set; }

        [Required(ErrorMessage = "O Campo Telefone é obrigatório.")]

        [Display(Name = "Cidade")]
        public int CidadeId { get; set; }
        public string Login { get; set; }        
        public string Senha { get; set; }
        public string CNPJClinica { get; set; }            

        
    }
}