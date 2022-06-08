using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class TipodeConsulta
    {     
        public int TipoConsultaId { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public bool Faturar { get; set; }
        public string CNPJClinica { get; set; }

        /*Cirurgia
         * Encaixe
         * Encaminhamento
         * Exame
         * Pré-Natal
         * Retorno         
         */
    }
}
