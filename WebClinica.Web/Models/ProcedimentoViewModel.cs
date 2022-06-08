using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ProcedimentoViewModel
    {
        public ProcedimentoViewModel()
        {
            this.Convenios = new List<ConvenioViewModel>();
        }

        [Key]
        public int ProcedimentoId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Procedimento é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Descrição do Procedimento é obrigatório.")]
        public string Descricao { get; set; }

        [Display(Name = "Tempo Médio (Minutos)")]
        [Required(ErrorMessage = "O campo Tempo Médido do Procedimento é obrigatório.")]
        public string TempMedio { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo Tempo de Procedimento é obrigatório.")]
        public int TipoProcedimentoId { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "O campo Tipo do Procedimento é obrigatório.")]
        public int TipoConsultaId { get; set; }

        [Display(Name = "Especialidade")]
        [Required(ErrorMessage = "O campo Especialidade do Procedimento é obrigatório.")]
        public int EspecialidadeId { get; set; }

        public string CNPJClinica { get; set; }

        [Display(Name = "Vinculado a Procedimento TUSS")]
        public bool VincularAProcedimentoTUSS { get; set; }
        public string ProcedimentoTUSS { get; set; }
        public List<ConvenioViewModel> Convenios { get; set; }
        public IEnumerable<ProcedimentoCobrancaConvenioViewModel> ConvenioCobranca { get; set; }




        // SE SIM CARREGA O COMBO DE DADOS TSUS (VIDE OBJETO SOLICITACAO DE EXAMES)


    }
}