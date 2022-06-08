using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using System.Linq;
using System;

namespace WebClinica.Negocio
{
    public class TipodeConsultaService : ITipodeConsultaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<TipodeConsulta> _repositorio;

        public TipodeConsultaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.TipodeConsultaRepositorio;
        }

        public IEnumerable<TipodeConsulta> obter()
        {
            return _repositorio.GetAll().Where(tp => tp.Ativo == true);
        }

        public void Salvar(TipodeConsulta tipoConsulta)
        {
            var registro = _repositorio.GetById(tipoConsulta.TipoConsultaId);

            if (registro == null)
                _repositorio.Add(tipoConsulta);
            else
                _repositorio.Update(registro,tipoConsulta);

            _unitOfWork.Save();
        }

        public void Excluir(int tipoConsultaId)
        {
            var tipoConsulta = _repositorio.GetById(tipoConsultaId);

            if (tipoConsulta != null)
            {
                tipoConsulta.Ativo = false;
                _repositorio.Update(tipoConsulta, tipoConsulta);                
                _unitOfWork.Save();
            }

        
        }
    }
}
