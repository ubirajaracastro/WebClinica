using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Agendamento
    {
        public Agendamento()
        {
            this.Procedimentos = new List<Procedimento>();
        }

        public int AgendamentoId { get; set; }
        public int ProfissionalID { get; set; }
        public int PacienteID { get; set; }
        public int ConvenioID { get; set; }
        public int TipoConsultaId { get; set; }
        public int StatusID { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
        public List<Procedimento> Procedimentos { get; set; }
        public string EncaminhadoPor { get; set; }
        public string IndicadoPor { get; set; }
        public int CNPJClinica { get; set; }
        public Profissional Profissional { get; set; }
        public Convenio Convenio { get; set; }
        public Paciente Paciente { get; set; }
        public TipodeConsulta TipodeConsulta { get; set; }

    }
}
