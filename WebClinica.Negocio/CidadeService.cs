using System.Collections.Generic;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;
using System;
using System.Linq;

namespace WebClinica.Negocio
{
    public class CidadeService : ICidadeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<WCidade> _repositorio;

        public CidadeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = unitOfWork.CidadeRepositorio;
        }

        public WCidade obterCidade(int CidadeId)
        {
            return _repositorio.GetById(CidadeId);
        }

        public IEnumerable<WCidade> obterCidadesPorEstado(int EstadoID)
        {
            return _repositorio.GetAll().Where(es=>es.EstadoId==EstadoID);
        }
    }
}
