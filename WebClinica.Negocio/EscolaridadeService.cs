using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.InfraEstrutura.Data.Repositorios;

namespace WebClinica.Negocio
{
    public class EscolaridadeService : IEscolaridadeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Escolaridade> _repositorio;

        public EscolaridadeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.EscolaridadeRepositorio;

        }
        public IEnumerable<Escolaridade> obter()
        {
            return _repositorio.GetAll();
        }
    }
}
