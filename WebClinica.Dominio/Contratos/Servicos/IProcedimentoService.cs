using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IProcedimentoService
    {
        void salvar(Procedimento procedimento,List<ProcedimentoCobranca> listaConvenioCobranca);
        IEnumerable<Procedimento> obter();
        Procedimento obterPorId(int id);
        IEnumerable obterProcedimentosPorConvenios(int ConvenioId);
        IEnumerable obterProfissionalPorConvenios(int ConvenioId);

    }
}
