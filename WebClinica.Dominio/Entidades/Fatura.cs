using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Fatura
    {
        public Fatura()
        {
            this.Procedimentos = new List<Procedimento>();
        }

        public int FaturaId { get; set; }
        public int PacienteId { get; set; }
        public int Data { get; set; }
        public int ProfissionalId { get; set; }
        public List<Procedimento> Procedimentos { get; set; }
        public decimal ValorPaciente { get; set; }
        public decimal ValorConvenio{ get; set; }
        //opçoes do grid faturar e nao cobrar
        public int StatusId { get; set; }
        public string CNPJClinica { get; set; }


        public Paciente Paciente { get; set; }
        public Profissional Profissional { get; set; }



    }
}
