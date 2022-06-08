using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ContaCorrente
    {
        public string CNPJClinica { get; set; }
        public int ContaId { get; set; }
        public int Nome { get; set; }
        public int BancoId { get; set; }
        public string Agencia { get; set; }
        public string AgenciaDigito { get; set; }
        public string NumeroConta { get; set; }
        public string NumeroContaDigito { get; set; }
        public decimal SaldoIncial { get; set; }
        public bool HabilitaBoleto { get; set; }

        public Banco Banco { get; set; }
    }
}
