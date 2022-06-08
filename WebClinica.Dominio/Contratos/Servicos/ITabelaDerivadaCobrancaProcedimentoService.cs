using System.Collections;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface ITabelaDerivadaCobrancaProcedimentoService
    {       
        string Salvar(TabelaDerivadaCobrancaProcedimento tabela,
            List<TabelaDerivadaCobrancaProcedimentoItem> listaItens);
        IEnumerable obter();
        TabelaDerivadaCobrancaProcedimento obterTabela(int tabelaID);
        IEnumerable<TabelaDerivadaCobrancaProcedimentoItem> obterItens(int tabelaID);
        void RemoverItem(int id);

    }
}
