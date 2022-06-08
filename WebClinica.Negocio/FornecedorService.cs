using System;
using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<FornecedorClinica> _repositorio;

        public FornecedorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.FornecedorRepositorio;
        }
        public void Excluir(int fornecedorID)
        {
            FornecedorClinica fornecedor = _repositorio.GetById(fornecedorID);
            if (fornecedor != null)
            {
                fornecedor.Ativo = false;
                _repositorio.Update(fornecedor, fornecedor);
                _unitOfWork.Save();
            }
        }

        public IEnumerable<FornecedorClinica> obter()
        {
            return _repositorio.GetAll().Where(a => a.Ativo == true);
        }

        public void Salvar(FornecedorClinica fornecedor)
        {
            var registro = _repositorio.GetById(fornecedor.Id);

            if (registro == null)
                _repositorio.Add(fornecedor);
            else
                _repositorio.Update(registro, fornecedor);

            _unitOfWork.Save();
        }

        public FornecedorClinica obterPorId(int ID)
        {
            FornecedorClinica fornecedor = _repositorio.GetById(ID);
            return fornecedor;
        }
    }
}
