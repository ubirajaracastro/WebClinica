using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ConfiguracaoFinanceiro
    {
        public int ConfiguracaoFinanceiroId { get; set; }
        public string CNPJClinica { get; set; }
        public int ClinicaId { get; set; }
        public int ContaId { get; set; }
        public bool NaoPagarComissao { get; set; }
        public bool GerarComissaonoFaturamentoTitulo { get; set; }
        public bool GerarComissaoLiquidacaoTitulo { get; set; }

        public Clinica Clinica { get; set; }
        public ContaCorrente Conta { get; set; }

    }
}
