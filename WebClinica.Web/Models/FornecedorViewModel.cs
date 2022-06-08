using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class FornecedorViewModel
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "O campo CNPJ do fornecedor é obrigatório.")]         
        public string CNPJ { get; set; }

        [Display(Name = "Nome Fantasia")]
        [Required(ErrorMessage = "O campo Nome Fantasia do fornecedor é obrigatório.")]       
        public string Nome { get; set; }

        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "O campo Razão Social do fornecedor é obrigatório.")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome de Contato")]
        [Required(ErrorMessage = "O campo Nome de Contato do fornecedor é obrigatório.")]
        public string NomeContato { get; set; }

        [Required(ErrorMessage = "O campo Email do fornecedor é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone do fornecedor é obrigatório.")]
        public string Telefone { get; set; }

        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        public int EstadoId { get; set; }

        public int CidadeId { get; set; }
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public string CNPJClinica { get; set; }
      

    }
}