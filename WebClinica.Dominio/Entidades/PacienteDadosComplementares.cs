using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class PacienteDadosComplementares
    {
        public string CNSSUS { get; set; }
        public string RG { get; set; }
        public int EscolaridadeId { get; set; }
        public int ProfissaoId { get; set; }
        public string FatorSanguineo { get; set; }
        public int EstadoCivilId { get; set; }
        public int EtniaId { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string NomeConjugue { get; set; }
        public string Responsavel { get; set; }
        public string Indicacao { get; set; }
        public string Hobby { get; set; }             
        public int PacienteId { get; set; }
      
    }
}
