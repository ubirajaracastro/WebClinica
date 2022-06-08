using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Paciente
    {
        #region Ctor
       
        public Paciente()
        {                     
            Agendamentos = new List<Agendamento>();           
            Procedimentos = new List<Procedimento>();
            Orcamentos = new List<Orcamento>();                      
        }
        #endregion

        #region Properties
        public int PacienteId { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime ValidadeCarteira { get; set; }
        public string Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int EstadoID { get; set; }
        public int CidadeID { get; set; }
        public string Cep { get; set; }
        public string UrlFoto { get; set; }
        public string Email { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string NumeroCarteira { get; set; }
        public string UrlImagemCartaoSaudePaciente { get; set; }
        public string Skype { get; set; }
        public List<Atestado> Atestados { get; set; }
        public List<Agendamento> Agendamentos { get; set; }        
        public List<Procedimento> Procedimentos { get; set; }
        public List<Orcamento>Orcamentos { get; set; }       
        public List<SolicitacaoExame> SolicitacoesExame { get; set; }    
        public string CNPJClinica { get; set; }       
        public int TipoConvenioId { get; set; }
        public int? ConvenioPlanoId { get; set; }
        public int ConvenioId { get; set; }

        #endregion
    }
}

