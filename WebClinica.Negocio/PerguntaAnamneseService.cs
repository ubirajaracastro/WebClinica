using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Contratos.Repositorios;

namespace WebClinica.Negocio
{
    public class PerguntaAnamneseService : IPerguntaAnamneseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDatabaseTransaction _transaction;
        private readonly IRepositoryBase<PerguntasAnamnese> _repositorio;
        private readonly IRepositoryBase<RespostaPerguntaAnamnese> _repositorioResposta;

        public PerguntaAnamneseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.PerguntaAnamneseRepositorio;
            _repositorioResposta = _unitOfWork.RespostaPerguntaAnamneseRepositorio;
            //_transaction = unitOfWork.BeginTransaction();
        }
        public IEnumerable<PerguntasAnamnese> obter()
        {
            var lista = _repositorio.GetAll();
            //_unitOfWork.Dispose();
            return lista;
        }

        public void Salvar(PerguntasAnamnese pergunta, List<RespostaPerguntaAnamnese> listaRespostas)
        {
            _repositorio.Add(pergunta);
            _unitOfWork.Save();

            foreach (RespostaPerguntaAnamnese item in listaRespostas)
            {
                item.PerguntasAnamnese = pergunta;
                _repositorioResposta.Add(item);
            }
            _unitOfWork.Save();
        }

        public void Excluir(int id)
        {
            try
            {
                PerguntasAnamnese pergunta = _repositorio.GetAllRelation("Respostas", p => p.PerguntaId == id).FirstOrDefault();

                //if (pergunta != null)
                //{
                //    foreach (RespostaPerguntaAnamnese item in pergunta.Respostas)
                //    {
                //        RespostaPerguntaAnamnese resp = _repositorioResposta.GetFirst(r=>r.RespostaId==id);
                //        if (resp != null)
                //            _repositorioResposta.Remove(resp);

                //    }
                //}
                _repositorio.Remove(pergunta);

                _unitOfWork.Save();
            }

            catch(Exception erro)
            {

            }

        }

       
    }
}
