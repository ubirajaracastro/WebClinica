using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Clinica
    {
        public int ClinicaId { get; set; }
        public string CNPJ { get; set; }
        public string NomeClinica { get; set; }
        public string Email { get; set; }
        public string CPFResponsavel { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public int IdEstado { get; set; }
        public int IdCidade { get; set; }     
        public bool UtilizaTISS { get; set; }
        public string CNES { get; set; }
       
               
    }

}
