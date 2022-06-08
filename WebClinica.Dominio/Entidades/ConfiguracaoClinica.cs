using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
   public class ConfiguracaoClinica
    {
        public int ConfiguracaoClinicaId { get; set; }
        public string CNPJ { get; set; }
        public bool HabilitarUsoSMS { get; set; }
        public bool HabilitarEnvioEmails { get; set; }
        public string TempoMedioAtendimento { get; set; }
        public string HoraInicialAtendimento { get; set; }
        public string HoraFinalAtendimento { get; set; }
        public string HorarioInicialAlmoco { get; set; }
        public string HorarioFinalAlmoco { get; set; }
        public bool RestringirAgendamentoscomBaseHorarioAtendimento { get; set; }
        public bool EnviarEmaildeAgendamento { get; set; }
        public bool EnviarEmailUmDiaAntesConsulta { get; set; }
        public bool EnviarEmailAniversario { get; set; }
        public bool EnviarSMSdeAgendamento { get; set; }
        public bool EnviarSMSUmdiaAntesdaConsulta { get; set; }
        public bool EnviarNotificacaoaoProfissionalSaude { get; set; }
        public int FormaPagamentoPadrao { get; set; }

    }
}
