using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Atendimento
    {
        public Atendimento()
        {
            Procedimentos = new List<Procedimento>();
        }
        public int AtendimentoId { get; set; }      
        public int PacienteID { get; set; }
        public string QueixaPrincipal { get; set; }
        public string Conduta { get; set; }            
        public string PrescricaoMedica { get; set; }
        public string CID { get; set; }
        public string DescricaoCID { get; set; }                
        public DateTime Data { get; set; }       
        public string CNPJClinica { get; set; }
        public Paciente Paciente { get; set; }       
        public int ModeloAnamneseID { get; set; }       
        public List<Procedimento> Procedimentos { get; set; }
        public List<ProntuarioProcedimento> ProcedimentosProntuario { get; set; }
        public ExameFisico ExameFisico { get; set; }
        public Atestado Atestado { get; set; }


    }
}
