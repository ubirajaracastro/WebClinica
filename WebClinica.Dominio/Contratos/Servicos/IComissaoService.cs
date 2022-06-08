using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.ObjetoCompostos;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IComissaoService
    {
        void Salvar(EntidadeComissao comissao);
        List<ComissaoEntidade> obterComissao();      
        EntidadeComissao obterComissao(int ConvenioId, int ProcedimentoId, int ProfissionalID);

    }
}
