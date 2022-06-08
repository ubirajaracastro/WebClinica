using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class EscalaAtendimentoProfissional
    {
        public EscalaAtendimentoProfissional()
        {
            this.DiasEscala = new List<EscalaAtendimentoProfissionalDiaSemana>();
        }
        public int EscalaId { get; set; }
        public int ProfisionalId { get; set; }
        public DateTime DtInicialEscala { get; set; }
        public DateTime DtFinalEscala { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        //public Profissao Profissional { get; set; }
        public bool Ativo { get; set; }
        public int DiaSemana { get; set; }
        public string CNPJClinica { get; set; }

        public IList<EscalaAtendimentoProfissionalDiaSemana>DiasEscala { get; set; }

    }
}
