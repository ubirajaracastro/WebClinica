using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class ProcedimentoService : IProcedimentoService
    {
        const string CNPJ = "45543915003954";

        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Procedimento> _repositorio;
        private readonly IRepositoryBase<ProcedimentoCobranca> _procedimentoCobrancaRepositorio;
        private readonly IRepositoryBase<TipodeConsulta> _tipoConsultaRepositorio;
        private readonly IRepositoryBase<Convenio> _convenioRepositorio;
        private readonly IRepositoryBase<Profissional> _profissionalRepositorio;
        private readonly IRepositoryBase<ConvenioProfissional> _convenioprofissionalRepositorio;


        public ProcedimentoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.ProcedimentoRepositorio;
            _procedimentoCobrancaRepositorio = _unitOfWork.ProcedimentoCobrancaRepositorio;
            _tipoConsultaRepositorio = _unitOfWork.TipodeConsultaRepositorio;
            _convenioRepositorio = _unitOfWork.ConvenioRepositorio;
            _profissionalRepositorio = _unitOfWork.ProfissionalRepositorio;
            _convenioprofissionalRepositorio = _unitOfWork.ConvenioProfissionalRepositorio;
        }
        public IEnumerable<Procedimento> obter()
        {
            return _repositorio.GetAll().Where(a => a.Ativo == true);
        }

        public Procedimento obterPorId(int id)
        {
            return _repositorio.GetById(id);

        }

        public void salvar(Procedimento entidade, List<ProcedimentoCobranca> listaConvenioCobranca)
        {
            var registro = _repositorio.GetById(entidade.ProcedimentoId);
            entidade.CNPJClinica = CNPJ;

            TipodeConsulta tipo = _tipoConsultaRepositorio.GetById(entidade.TipoProcedimentoId);
          
            if (registro == null)
                _repositorio.Add(entidade);
            else           
                _repositorio.Update(registro, entidade);                                   

            _unitOfWork.Save();

            //apaga sempre e recria a associacao procedimento e convenio;
            var listaCobrancaConvenios = _procedimentoCobrancaRepositorio.GetAll()
                .Where(c => c.ProcedimentoId == entidade.ProcedimentoId);

            foreach (var item in listaCobrancaConvenios)
            {
                _procedimentoCobrancaRepositorio.Remove(item);
            }

            foreach (var item in listaConvenioCobranca)
            {
                item.ProcedimentoId = entidade.ProcedimentoId;
                _procedimentoCobrancaRepositorio.Add(item);

            }

            _unitOfWork.Save();
            
        }

        public IEnumerable obterProcedimentosPorConvenios(int ConvenioId)
        {         
            var resultado = from p in _repositorio.GetAll()
                            join pc in _procedimentoCobrancaRepositorio.GetAll() on p.ProcedimentoId equals pc.ProcedimentoId
                                join cv in _convenioRepositorio.GetAll() on pc.ConvenioId equals cv.ConvenioID
                                     where cv.ConvenioID == ConvenioId                                                    

                            select new
                            {
                               p.ProcedimentoId,
                               p.Descricao
                            };           

            return resultado;
        }

        public IEnumerable obterProfissionalPorConvenios(int ConvenioId)
        {
            var resultado = from p in _profissionalRepositorio.GetAll()
                            join cp in _convenioprofissionalRepositorio.GetAll() on p.ProfissionalId equals cp.ProfissionalId
                               join c in _convenioRepositorio.GetAll() on cp.ConvenioId equals c.ConvenioID
                                  where c.ConvenioID==ConvenioId

                            select new
                            {
                                p.ProfissionalId,
                                p.Nome

                            };
         
            return resultado;
        }
    }
}
