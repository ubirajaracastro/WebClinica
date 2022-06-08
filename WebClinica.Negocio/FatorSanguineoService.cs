using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class FatorSanguineoService : IFatorSanguineoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<FatorSanguineo> _repositorio;

        public FatorSanguineoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.FatorSanguineoRepositorio;

        }
        public IEnumerable<FatorSanguineo> obter()
        {
            return _repositorio.GetAll();
        }
    }
}
