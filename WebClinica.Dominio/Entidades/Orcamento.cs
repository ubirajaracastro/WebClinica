using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Orcamento
    {
        public Orcamento()
        {
            this.Procedimentos = new List<Procedimento>();
        }

        public DateTime DataSolicitacao { get; set; }
        public int OrcamentoId { get; set; }
        public int PacienteId { get; set; }
        public string DescricaoOrcamento { get; set; }
        public DateTime ValidoAte { get; set; }
        public List<Procedimento> Procedimentos { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public int qtdeParcelas { get; set; }
        public bool Aprovado { get; set; }
        public int ClinicaId { get; set; }
        public string CNPJClinica { get; set; }

        public Paciente Paciente { get; set; }
        public Clinica Clinica { get; set; }

    }
}
