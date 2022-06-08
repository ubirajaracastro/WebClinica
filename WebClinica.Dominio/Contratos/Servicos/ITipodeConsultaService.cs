using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface ITipodeConsultaService
    {
        IEnumerable<TipodeConsulta> obter();
        void Salvar(TipodeConsulta tipoConsulta);
        void Excluir(int tipoConsultaId);
    }
}
