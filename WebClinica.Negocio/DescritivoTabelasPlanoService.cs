using System;
using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class DescritivoTabelasPlanoService : IDescritivoTabelasPlanoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<DescritivoTabelasPlano> _repositorio;

        public DescritivoTabelasPlanoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.TabelasProcedimentoRepositorio;

        }

        public IEnumerable<DescritivoTabelasPlano> obter()
        {
            return _repositorio.GetAll();
        }

        public DescritivoTabelasPlano obter(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Salvar(DescritivoTabelasPlano descricao)
        {
            _repositorio.Add(descricao);
            _unitOfWork.Save();
        }
    }
}
