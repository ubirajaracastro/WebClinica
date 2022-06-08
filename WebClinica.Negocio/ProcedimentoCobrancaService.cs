using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;

namespace WebClinica.Negocio
{
    public class ProcedimentoCobrancaService : IProcedimentoCobrancaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<ProcedimentoCobranca> _repositorioProcedimentoCobranca;

        public ProcedimentoCobrancaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorioProcedimentoCobranca = _unitOfWork.ProcedimentoCobrancaRepositorio;
        }
        public IEnumerable<ProcedimentoCobranca> obter(int procedimentoID)
        {
            var listaProcedimentoCobranca = 
                _repositorioProcedimentoCobranca.GetAll().Where(p => p.ProcedimentoId == procedimentoID);

            return listaProcedimentoCobranca;
        }
    }
}
