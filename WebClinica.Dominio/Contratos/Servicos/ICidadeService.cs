using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface ICidadeService
    {
        IEnumerable<WCidade> obterCidadesPorEstado(int EstadoID);
        WCidade obterCidade(int CidadeId);

    }
}
