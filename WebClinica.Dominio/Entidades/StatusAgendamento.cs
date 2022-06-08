using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class StatusAgendamento
    {
        public int StatusAgendamentoId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
