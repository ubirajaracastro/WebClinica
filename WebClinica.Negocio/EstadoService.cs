using System.Collections.Generic;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;
using System.Linq;

namespace WebClinica.Negocio
{
    public class EstadoService : IEstadoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<WEstado> _repositorio;

        public EstadoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.EstadoRepositorio;
        }
        public IEnumerable<WEstado> obterEstados(int PaisId)
        {
            return _repositorio.GetAll().Where(es => es.PaisId == PaisId);
        }
    }
}
