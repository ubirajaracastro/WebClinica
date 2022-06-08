using System;
using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;
using System.Collections;

namespace WebClinica.Negocio
{
    public class ModeloAnamneseService : IModeloAnamneseService
    {       
        #region membros
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<ModeloAnamnese> _repositorio;
        private readonly IRepositoryBase<PerguntasAnamnese> _repositorioPergunta;
        private readonly IRepositoryBase<ModeloPergunta> _repositorioModeloPergunta;
        #endregion

        #region Construtor
        public ModeloAnamneseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.AnamneseRepositorio;
            _repositorioPergunta = _unitOfWork.PerguntaAnamneseRepositorio;
            _repositorioModeloPergunta = _unitOfWork.ModeloPerguntaRepositorio;
        }
        #endregion

        #region Metodos
        public void ExcluirModeloAnamnese(int id)
        {
            var modelo = _repositorio.GetById(id);

            if (modelo != null)
            {
                modelo.Ativo = false;
                _repositorio.Update(modelo, modelo);                
                _unitOfWork.Save();
            }

        }

        public IEnumerable<ModeloAnamnese> obter()
        {
            var lista = _repositorio.GetAll().Where(m=>m.Ativo==true);         
            return lista;

        }

        public int obterModeloPadrao()
        {
            int count = _repositorio.GetWhere(m => m.PadraodaClinica == true).Count();

            return count;
        }

        public ModeloAnamnese obterPorId(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Salvar(ModeloAnamnese modelo, List<PerguntasAnamnese> Perguntas)
        {
            #region comentado para analisar depois
            //if (modelo.ModeloId == 0){

            //    _repositorio.Add(modelo);   

            //    foreach (PerguntasAnamnese item in Perguntas)
            //    {
            //       modelo.Perguntas.Add(_repositorioPergunta.GetById(item.PerguntaId));
            //    }                
            //}

            //else
            //{
            //    var registro = _repositorio.GetById(modelo.ModeloId);

            //    IEnumerable<PerguntasAnamnese> lista =
            //         _repositorioPergunta.GetAllRelation("Modelos", p => p.Modelos.Count > 0);

            //    IEnumerable<ModeloAnamnese> listaModelos = _repositorio.GetAllRelation("Perguntas",
            //        m => m.ModeloId == modelo.ModeloId);


            //    //_repositorio.Update(modeloAnamnese.ElementAt(0), modelo);


            #endregion

            try
            {

                var registro = _repositorio.GetById(modelo.ModeloId);
                if (registro == null)
                    _repositorio.Add(modelo);
                else
                    _repositorio.Update(registro, modelo);

                //limpa associacoes anteriores
                ExcluirModeloPergunta(modelo.ModeloId);


                foreach (PerguntasAnamnese item in Perguntas)
                {
                    ModeloPergunta modeloPergunta = new ModeloPergunta();
                    modeloPergunta.PerguntaCodigo = item.PerguntaId;
                    modeloPergunta.ModeloCodigo = modelo.ModeloId;

                    _repositorioModeloPergunta.Add(modeloPergunta);
                }

                _unitOfWork.Save();
            }

            catch (Exception erro)
            {

            }

        }

        public void ExcluirModeloPergunta(int ModeloId)
        {
            IEnumerable<ModeloPergunta> PerguntasAnteriores = obterPerguntasModelo(ModeloId);
                        
            foreach (var item in PerguntasAnteriores)
            {
                ModeloPergunta mp = _repositorioModeloPergunta.
                    GetFirst(m => m.PerguntaCodigo == item.PerguntaCodigo);

                if (mp != null)
                    _repositorioModeloPergunta.Remove(mp);
            }

        }

        public IEnumerable<ModeloPergunta> obterPerguntasModelo(int ModeloId)
        {
            IEnumerable<ModeloPergunta> PerguntasAnteriores =
               _repositorioModeloPergunta.GetWhere(m => m.ModeloCodigo == ModeloId);

            return PerguntasAnteriores;
        }

        public IEnumerable<PerguntasAnamnese> obterPerguntas(int ModeloId)
        {         
            var listaPerguntas = from p in _repositorioPergunta.GetAll()
                                 join pm in _repositorioModeloPergunta.GetAll() on p.PerguntaId equals pm.PerguntaCodigo
                                 join m in _repositorio.GetAll() on pm.ModeloCodigo equals m.ModeloId
                                 where m.ModeloId == ModeloId

                                 select new PerguntasAnamnese
                                 {
                                    PerguntaId =  p.PerguntaId,
                                    Descricao =  p.Descricao
                                 };


            return listaPerguntas;                                       

        }

        public ModeloAnamnese obterModeloPadraoClinica()
        {
            return _repositorio.GetAll().Where(m => m.Ativo == true).FirstOrDefault();
        }

        public string obterDescricaoPergunta(int PerguntaID)
        {
            return _repositorioPergunta.GetById(PerguntaID).Descricao;
        }
        #endregion
    }
}
