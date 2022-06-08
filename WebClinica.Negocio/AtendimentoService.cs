using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class AtendimentoService : IAtendimentoService
    {
        #region membros
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<ModeloAnamnese> _repositorioModelo;
        private readonly IRepositoryBase<ModeloPergunta> _repositorioModeloPergunta;
        private readonly IRepositoryBase<Atendimento> _repositorioProntuario;
        private readonly IRepositoryBase<PerguntasAnamnese> _repositorioPergunta;
        private readonly IRepositoryBase<ExameFisico> _repositorioExameFisico;
        private readonly IRepositoryBase<ProntuarioRespostaAnamnese> _repositorioProntuarioRespostaAnamnese;
        private readonly IRepositoryBase<ProntuarioProcedimento> _repositorioProntuarioProcedimento;
        private readonly IRepositoryBase<Paciente> _repositorioPaciente;
        private readonly IRepositoryBase<Atestado> _repositorioAtestado;
        #endregion

        #region construtor
        public AtendimentoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorioModelo = unitOfWork.AnamneseRepositorio;
            _repositorioModeloPergunta = unitOfWork.ModeloPerguntaRepositorio;
            _repositorioProntuario = unitOfWork.ProntuarioRepositorio;
            _repositorioExameFisico = unitOfWork.ExameFisicoRepositorio;
            _repositorioPaciente = unitOfWork.PacienteRepositorio;
            _repositorioProntuarioRespostaAnamnese = unitOfWork.ProntuarioRespostaAnamneseRepositorio;
            _repositorioProntuarioProcedimento = _unitOfWork.ProntuarioProcedimentoRepositorio;
            _repositorioAtestado = _unitOfWork.AtestadoRepositorio;
            _repositorioPergunta = _unitOfWork.PerguntaAnamneseRepositorio;
        }
        #endregion

        #region metodos
        public IEnumerable obterModeloAnamnese(string CNPJClinica)
        {
            var listaModelos = from db in _repositorioModelo.TWhere(c => c.CNPJClinica == CNPJClinica && c.Ativo == true)
                               select new
                               {
                                   db.ModeloId,
                                   db.Nome
                               };

            return listaModelos;
        }

        public IEnumerable obterPerguntasModelo(int ModeloID)
        {
            var resultado = from p in _repositorioPergunta.GetAll()
                            join mp in _repositorioModeloPergunta.GetAll() on p.PerguntaId equals mp.PerguntaCodigo
                            join modelo in _repositorioModelo.GetAll() on mp.ModeloCodigo equals modelo.ModeloId
                            where mp.ModeloCodigo == ModeloID

                            select new
                            {
                                p.PerguntaId,
                                p.Descricao

                            };

            return resultado;
        }

        public Atendimento obterAtendimento(int ID)
        {
            Atendimento prontuario = _repositorioProntuario.GetAllRelation("Atestado",
                "ExameFisico", "ProcedimentosProntuario","Paciente",
                           paciente => paciente.AtendimentoId == ID).FirstOrDefault();


            return prontuario;
        }

        public int Salvar(Atendimento atendimento, List<ProntuarioRespostaAnamnese> prontuarioRespostas)
           
        {
            int idAtendimento=0;
            using (var transacao = _unitOfWork.BeginTransaction())
            {
                try
                {
                    Paciente paciente = _repositorioPaciente.GetById(atendimento.PacienteID);
                    atendimento.Paciente = paciente;
                    _repositorioProntuario.Add(atendimento);

                    _unitOfWork.Save();
                    idAtendimento = atendimento.AtendimentoId;
                                    
                    foreach (ProntuarioRespostaAnamnese item in prontuarioRespostas)
                    {
                        item.AtendimentoID = atendimento.AtendimentoId;
                        _repositorioProntuarioRespostaAnamnese.Add(item);
                    }

                    _unitOfWork.Save();                   

                    transacao.Commit();
                }

                catch (Exception erro)
                {
                    transacao.Rollback();
                }

            }

            return idAtendimento;
        }

        public ExameFisico obterExameFisico(int atendimentoID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProntuarioRespostaAnamnese> ObterRespostasAnamnese(int atendimentoID)
        {
            return _repositorioProntuarioRespostaAnamnese.GetWhere(p => p.AtendimentoID == atendimentoID);
        }

        public Atestado obterAtestado(int atendimentoID)
        {
            throw new NotImplementedException();
        }




        #endregion


    }
}
