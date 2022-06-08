using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Comum.dto
{
    public class ResumoPaciente
    {
        public string CPF { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Responsável { get; set; }
        public string Indicacao { get; set; }
        public string Convenio { get; set; }
        public TimeSpan TempoParaAniversario { get; set; }
        public int QtdeAtendimentosRealizados { get; set; }
    }
}
