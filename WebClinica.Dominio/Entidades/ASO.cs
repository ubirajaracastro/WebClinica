using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ASO
    {
        public int ASOId { get; set; }
        public string Empresa { get; set; }
        public int ProfissionalId { get; set; }
        public int TipoExameMedicoId { get; set; }
        public int PacienteId { get; set; }
        public ExameComplementarPCMSO ExameComplementarPCMSO { get; set; }
        public RiscoOcupacional RiscoOcupacional { get; set; }
        public Paciente Paciente { get; set; }
        public Profissional Profissional { get; set; }

        public int LaudoNR7 { get; set; }
        public int LaudoNR33 { get; set; }
        public int LaudoNR35 { get; set; }
    }
}
