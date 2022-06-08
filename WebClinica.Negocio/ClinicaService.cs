using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;

namespace WebClinica.Negocio
{
    public class ClinicaService : IClinicaService
    {
        //retomando o projeto
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Clinica> _repositorio;
        
        public ClinicaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = unitOfWork.ClinicaRepositorio;
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public Clinica obterClinica()
        {
            return _repositorio.GetFirst();
        }

        public void salvarClinica(Clinica entidade)
        {
            var registro = _repositorio.GetById(entidade.ClinicaId);

            if (registro == null)
                _repositorio.Add(entidade);
            else
            {
                _repositorio.Update(registro, entidade);
            }

            _unitOfWork.Save();

        }
    }
}
