using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;


namespace WebClinica.Model
{
    public class ClinicaViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ClinicaId { get; set; }
       
        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O Campo Nome da Clínica é obrigatório.")]
        [Display(Name = "Nome da Clínica")]
        public string NomeClinica { get; set; }

        [Required(ErrorMessage = "O Campo Email é obrigatório.")]
        public string Email { get; set; }

        [Display(Name = "CPF do Responsável")]       
        [Required(ErrorMessage = "O Campo CPF do Responsável é obrigatório.")]
        public string CPFResponsavel { get; set; }

        [Display(Name = "Nome do Responsável")]
        [Required(ErrorMessage = "O Campo Responsável é obrigatório.")]
        public string NomeResponsavel { get; set; }

        [Required(ErrorMessage = "O Campo Telefone é obrigatório.")]
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        [Display(Name = "Estado")]
        public int IdEstado { get; set; }

        [Display(Name = "Cidade")]
        public int IdCidade { get; set; }
        //public WEstado Estado { get; set; }
        //public WCidade Cidade { get; set; }
        public bool UtilizaTISS { get; set; }
        public string CNES { get; set; }

    }
}
