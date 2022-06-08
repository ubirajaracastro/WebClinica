using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IFornecedorService
    {
        void Salvar(FornecedorClinica fornecedor);
        void Excluir(int fornecedorID);
        IEnumerable<FornecedorClinica> obter();
        FornecedorClinica obterPorId(int ID);
    }
}
