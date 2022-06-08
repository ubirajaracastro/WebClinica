using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.PadraoTISS;
using System.Linq;
using System.Collections;

namespace WebClinica.Negocio
{
    public class EspecialidadeService : IEspecialidadeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Tabela24> _repositorio;

        public EspecialidadeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.CBORepositorio;
        }
        public IEnumerable obter()
        {
            var listaCBO = from db in _repositorio.GetAll()
                           select new
                           {
                               db.CodTermo,
                               db.Termo

                           };

            return listaCBO;
        }
    }
}
