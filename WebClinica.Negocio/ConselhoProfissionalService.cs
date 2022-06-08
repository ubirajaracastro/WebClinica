using System.Collections;
using System.Linq;
using WebClinica.Dominio.Entidades.PadraoTISS;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;

namespace WebClinica.Negocio
{
    public class ConselhoProfissionalService : IConselhoProfissionalService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Tabela26> _repositorio;
        public ConselhoProfissionalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.ConselhoProfissionalRepositorio;
        }
        
        public IEnumerable obter()
        {
            var lista = from db in _repositorio.GetAll()
                        select new
                        {
                            db.CodTermo,
                            db.Termo

                        };
            return  lista;
        }
    }
}
