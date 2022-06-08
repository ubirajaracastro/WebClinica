using System.Collections.Generic;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;

namespace WebClinica.Negocio
{
    public class ConfiguracaoClinicaService : IConfiguracaoClinicaService
    {       
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<ConfiguracaoClinica> _repositorio;        
        public ConfiguracaoClinicaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.ConfiguracaoClinicaRepositorio;
        }

        private void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public ConfiguracaoClinica obterConfiguracao()
        {
            ConfiguracaoClinica configuracaoClinica = _repositorio.GetFirst();
            return configuracaoClinica;
        }

        public void SalvarConfiguracao(ConfiguracaoClinica entidade)
        {
            var registro = _repositorio.GetById(entidade.ConfiguracaoClinicaId);

            if (registro == null)
                _repositorio.Add(entidade);
            else {       
                _repositorio.Update(registro,entidade);  
            }

            _unitOfWork.Save();
           
        }
    }
}
