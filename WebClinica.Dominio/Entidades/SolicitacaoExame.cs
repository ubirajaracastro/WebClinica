using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class SolicitacaoExame
    {
        public int SolicitacaoExameId { get; set; }
        public int ClinicaId { get; set; }

        public DateTime DataSolicitacao { get; set; }
        public int ProfissionalId { get; set; }
        public string Nome { get; set; }

        public int TUSSId { get; set; }
        // verificar onde obter essa lista ex 4030515 hidroxivitamina D
        public string TextoSolicitacao { get; set; }
        public string CNPJClinica { get; set; }

        public Profissional Profissional { get; set; }
        public Clinica Clinica { get; set; }
        public Paciente Paciente { get; set; }

    }
}
