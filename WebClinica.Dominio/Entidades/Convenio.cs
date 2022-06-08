using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Convenio
    {

        public Convenio()
        {
            this.ProfissionaisQueAceitam = new List<Profissional>();
            this.Procedimentos = new List<Procedimento>();
        }

        public int ConvenioID { get; set; }
        public string NomeConvenio { get; set; }
        public string CGC { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public string CNPJClinica { get; set; }
        public bool Ativo { get; set; }
        public string Site { get; set; }
        public string Observacao { get; set; }
        public int TabelaId { get; set; }
        public string NumeroContrato { get; set; }
        public bool CalcularExtraCirurgia { get; set; }
        public string HorarioSemanalHoraExtra { get; set; }
        public string HorarioFinalSemanaHoraExtra { get; set; }
        public bool AtendeRadiologia { get; set; }
        public decimal ValorFilme { get; set; }
        public bool PagamentoAdicionalMedico { get; set; }
        public decimal PercentualSobConsulta { get; set; }
        public decimal PercentualSobProcedimento { get; set; }
        public int NroDigitosCarteira { get; set; }
        public int QteDiasFaturamento { get; set; }
        public string NumeroRegistroANS { get; set; }
        public string NumeroJuntoaoConvenio { get; set; }
        public DateTime DataCadastro { get; set; }

        public ICollection<Profissional> ProfissionaisQueAceitam { get; set; }
        public ICollection<Procedimento> Procedimentos { get; set; }
    }
}
