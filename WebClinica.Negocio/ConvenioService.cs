using System.Collections.Generic;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;
using System;
using System.Linq;

namespace WebClinica.Negocio
{
    public class ConvenioService : IConvenioService
    {        
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Convenio> _repositorioConvenio;
        private readonly IRepositoryBase<ConvenioProfissional> _repositorioConvenioProfissional;
        private readonly IRepositoryBase<ConvenioPlano> _repositorioPlano;

        public ConvenioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorioConvenio = _unitOfWork.ConvenioRepositorio;
            _repositorioConvenioProfissional = _unitOfWork.ConvenioProfissionalRepositorio;
            _repositorioPlano = _unitOfWork.PlanoRepositorio;
        }
        public IEnumerable<Convenio> Obter()
        {
            return _repositorioConvenio.TWhere(a => a.Ativo == true);
        }

        public int Salvar(Convenio convenio, List<ConvenioProfissional> listaProfissionais)
        {         
            try{

                var registro = _repositorioConvenio.GetById(convenio.ConvenioID);

                if (registro == null)
                    _repositorioConvenio.Add(convenio);
                else
                    _repositorioConvenio.Update(registro, convenio);

                _unitOfWork.Save();

                //apaga sempre e recria a associacao convenio x profissional;
                var lista = _repositorioConvenioProfissional.GetAll().Where(p => p.ConvenioId == convenio.ConvenioID);

                foreach (ConvenioProfissional item in lista)
                {
                    _repositorioConvenioProfissional.Remove(item);
                }

                foreach (ConvenioProfissional item in listaProfissionais)
                {
                    item.ConvenioId = convenio.ConvenioID;
                    _repositorioConvenioProfissional.Add(item);
                }

                _unitOfWork.Save();

            }

            catch (Exception erro)
            {


            }


            return convenio.ConvenioID;
        }

        public void Excluir(Convenio convenio)
        {
            _repositorioConvenio.Remove(convenio);
        }

        public Convenio ObterPorId(int id)
        {
            return _repositorioConvenio.GetById(id);
        }

        public int SalvarPlano(ConvenioPlano plano)
        {
            _repositorioPlano.Add(plano);
            _unitOfWork.Save();

            return plano.ConvenioPlanoID;
        }

        public void ExcluirPlano(int id)
        {
            var Plano = _repositorioPlano.GetById(id);
            _repositorioPlano.Remove(Plano);

            _unitOfWork.Save();
        }

        public IEnumerable<ConvenioPlano> ObterPlanos(int id)
        {
            var listaPlanos = _repositorioPlano.TWhere(p => p.ConvenioID == id);
            return listaPlanos;
        }
    }
}
