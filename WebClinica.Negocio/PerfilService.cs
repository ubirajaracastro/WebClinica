using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class PerfilService : IPerfilService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Perfil> _repositorio;

        public PerfilService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.PerfilRepositorio;

        }

        public IEnumerable<Perfil> obterPerfil()
        {
            return _repositorio.GetAll().Where(a => a.Ativo == true);
        }
    }
}
