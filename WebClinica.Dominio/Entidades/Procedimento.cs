using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Procedimento
    {
        public Procedimento()
        {
            this.Comissoes = new List<EntidadeComissao>();
            this.Convenios = new List<Convenio>();

        }
        public int ProcedimentoId{ get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string TempMedio { get; set; }
        public bool Ativo { get; set; }
        public int TipoProcedimentoId { get; set; }
        public int EspecialidadeId { get; set; }
        public string CNPJClinica { get; set; }
        //public Especialidade Especialidade { get; set; }
        public bool VincularAProcedimentoTUSS { get; set; }
        public TipodeConsulta TipoProcedimento { get; set; }
        public string CodigoTSUS { get; set; }
        // SE SIM CARREGA O COMBO DE DADOS TSUS (VIDE OBJETO SOLICITACAO DE EXAMES)       

        public List<EntidadeComissao> Comissoes { get; set; }
        public List<Convenio> Convenios { get; set; }

        
    }
}
