using System;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class UsuarioViewModel
    {
        [ScaffoldColumn(false)]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O campo Login é obrigatório.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(12,ErrorMessage ="O comprimento da senha deverá ser entre 6 e 11 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Confirmação de Senha é obrigatório.")]
        [Compare("Senha",ErrorMessage ="A senha e confirmação da senha devem ser iguais.")]
        [Display(Name = "Confirmação de Senha")]
        [DataType(DataType.Password)]

        public string ConfirmacaoSenha { get; set; }

        [Required(ErrorMessage = "O campo Perfil é obrigatório.")]
        [Display(Name = "Perfil")]
        public int PerfilId { get; set; }

        [ScaffoldColumn(false)]
        public bool PrimeiroAcesso { get; set; }
    }
}