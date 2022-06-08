using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;
using System.Collections.Generic;
using System.Linq;
using System;

namespace WebClinica.Negocio
{
    public class ProfissionalService : IProfissionalService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Profissional> _repositorio;


        public ProfissionalService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.ProfissionalRepositorio;
        }       
        public void Excluir(Profissional profissional)
        {
            _repositorio.Remove(profissional);
        }

        public void salvar(Profissional profisional)
        {
            var registro = _repositorio.GetById(profisional.ProfissionalId);
             profisional.DataCadastro = DateTime.Now;

            try
            {
                if (registro == null)
                    _repositorio.Add(profisional);
                else
                {
                    _repositorio.Update(registro, profisional);
                }

                _unitOfWork.Save();
            }
            catch(Exception erro)
            {


            }
        }

        public IEnumerable<Profissional>listarProfissional()
        {

            return _repositorio.GetAll().Where(a => a.Ativo == true);
        }

        public Profissional obterPorId(int ID)
        {
            return _repositorio.GetById(ID);
        }
    }
}
