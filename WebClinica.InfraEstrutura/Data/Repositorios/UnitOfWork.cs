using System;
using WebClinica.Dominio;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Membros
        private bool _disposed;
        private readonly WebClinicaDataContext _db;
        private IRepositoryBase<ConfiguracaoClinica> _configuracaoClinicaRepositorio;
        private IRepositoryBase<Clinica> _clinicaRepositorio;
        private IRepositoryBase<WEstado> _ufRepositorio;
        private IRepositoryBase<WCidade> _cidadeRepositorio;
        private IRepositoryBase<Profissional> _profissionalRepositorio;
        private IRepositoryBase<Procedimento> _procedimentoRepositorio;
        private IRepositoryBase<TipodeConsulta> _tipoConsultaRepositorio;
        private IRepositoryBase<TabelaNormativaUSS> _tabelaNormativaRepositorio;
        private IRepositoryBase<Convenio> _convenioRepositorio;
        private IRepositoryBase<ConvenioProfissional> _convenioProfissionalRepositorio;
        private IRepositoryBase<ProcedimentoCobranca> _procedimentoCobrancaRepositorio;
        private IRepositoryBase<EntidadeComissao> _comissaoRepositorio;
        private IRepositoryBase<ModeloAnamnese> _anaMneseRepositorio;
        private IRepositoryBase<PerguntasAnamnese> _perguntaAnamneseRepositorio;
        private IRepositoryBase<RespostaPerguntaAnamnese> _respostaPerguntaAnamneseRepositorio;
        private IRepositoryBase<ModeloPergunta> _modeloPerguntaRepositorio;
        private IRepositoryBase<FornecedorClinica> _fornecedorRepositorio;
        private IRepositoryBase<Usuario> _usuarioRepositorio;
        private IRepositoryBase<Perfil> _perfilRepositorio;
        private IRepositoryBase<FatorSanguineo> _fatorSanguineoRepositorio;
        private IRepositoryBase<Escolaridade> _escolaridadeRepositorio;
        private IRepositoryBase<Paciente> _pacienteRepositorio;
        private IRepositoryBase<PacienteDadosComplementares> _pacienteDadoComplementarRepositorio;
        private IRepositoryBase<DescritivoTabelasPlano> _tabelasDescritivoRepositorio;
        private IRepositoryBase<ConvenioPlano> _planoRepositorio;
        private IRepositoryBase<TabelaDerivadaCobrancaProcedimento> _tabelaDerivadaProcedimentoRepositorio;
        private IRepositoryBase<TabelaDerivadaCobrancaProcedimentoItem> _tabelaDerivadaProcedimentoItemRepositorio;
        private IRepositoryBase<TabelaCBHPM> _tabelaTabelaCBHPMRepositorio;
        private IRepositoryBase<Tabela26> _conselhoProfissionalRepositorio;
        private IRepositoryBase<Tabela24> _cboRepositorio;
        private IRepositoryBase<ExameFisico> _exameFisicoRepositorio;
        private IRepositoryBase<Atendimento> _prontuarioRepositorio;
        private IRepositoryBase<ProntuarioRespostaAnamnese> _prontuarioRespostaAnamneseRepositorio;
        private IRepositoryBase<ProntuarioProcedimento> _prontuarioProcedimentoRepositorio;
        private IRepositoryBase<Cid> _cidRepositorio;
        private IRepositoryBase<Atestado> _atestadoRepositorio;



        #endregion

        #region Construtores
        public UnitOfWork()
        {
            _db = new WebClinicaDataContext();
        }

        public UnitOfWork(WebClinicaDataContext db)
        {

            _db = db;

        }
        #endregion

        #region Properties da Interface
        public IRepositoryBase<ConfiguracaoClinica> ConfiguracaoClinicaRepositorio
        {
            get
            {
                if (_configuracaoClinicaRepositorio == null)
                {
                    _configuracaoClinicaRepositorio = new RepositorioBase<ConfiguracaoClinica>(_db);
                }

                return _configuracaoClinicaRepositorio;
            }
        }

        public IRepositoryBase<Clinica> ClinicaRepositorio
        {
            get
            {
                if (_clinicaRepositorio == null)
                {
                    _clinicaRepositorio = new RepositorioBase<Clinica>(_db);
                }

                return _clinicaRepositorio;
            }
        }

        public IRepositoryBase<WEstado> EstadoRepositorio
        {
            get
            {
                if (_ufRepositorio == null)
                {
                    _ufRepositorio = new RepositorioBase<WEstado>(_db);
                }

                return _ufRepositorio;
            }
        }

        public IRepositoryBase<WCidade> CidadeRepositorio
        {
            get
            {
                if (_cidadeRepositorio == null)
                {
                    _cidadeRepositorio = new RepositorioBase<WCidade>(_db);
                }

                return _cidadeRepositorio;

            }

        }
        public IRepositoryBase<Convenio> ConvenioRepositorio
        {
            get
            {
                if (_convenioRepositorio == null)
                {
                    _convenioRepositorio = new RepositorioBase<Convenio>(_db);
                }

                return _convenioRepositorio;
            }
        }

        public IRepositoryBase<Profissional> ProfissionalRepositorio
        {
            get
            {
                if (_profissionalRepositorio == null)
                {
                    _profissionalRepositorio = new RepositorioBase<Profissional>(_db);
                }

                return _profissionalRepositorio;
            }
        }


        public IRepositoryBase<Procedimento> ProcedimentoRepositorio
        {
            get
            {
                if (_procedimentoRepositorio == null)
                {
                    _procedimentoRepositorio = new RepositorioBase<Procedimento>(_db);
                }

                return _procedimentoRepositorio;
            }
        }

        public IRepositoryBase<TipodeConsulta> TipodeConsultaRepositorio
        {
            get
            {
                if (_tipoConsultaRepositorio == null)
                {
                    _tipoConsultaRepositorio = new RepositorioBase<TipodeConsulta>(_db);
                }

                return _tipoConsultaRepositorio;
            }
        }

        public IRepositoryBase<TabelaNormativaUSS> TabelaNormativaUSSRepositorio
        {
            get
            {
                if (_tabelaNormativaRepositorio == null)
                {
                    _tabelaNormativaRepositorio = new RepositorioBase<TabelaNormativaUSS>(_db);
                }

                return _tabelaNormativaRepositorio;
            }
        }

        public IRepositoryBase<ConvenioProfissional> ConvenioProfissionalRepositorio
        {
            get
            {
                if (_convenioProfissionalRepositorio == null)
                {
                    _convenioProfissionalRepositorio = new RepositorioBase<ConvenioProfissional>(_db);
                }

                return _convenioProfissionalRepositorio;
            }
        }

        public IRepositoryBase<ProcedimentoCobranca> ProcedimentoCobrancaRepositorio
        {
            get
            {
                if (_procedimentoCobrancaRepositorio == null)
                {
                    _procedimentoCobrancaRepositorio = new RepositorioBase<ProcedimentoCobranca>(_db);
                }

                return _procedimentoCobrancaRepositorio;

            }
        }

        public IRepositoryBase<EntidadeComissao> ComissaoRepositorio
        {
            get
            {
                if (_comissaoRepositorio == null)
                {
                    _comissaoRepositorio = new RepositorioBase<EntidadeComissao>(_db);
                }

                return _comissaoRepositorio;
            }
        }

        public IRepositoryBase<ModeloAnamnese> AnamneseRepositorio
        {
            get
            {
                if (_anaMneseRepositorio == null)
                {
                    _anaMneseRepositorio = new RepositorioBase<ModeloAnamnese>(_db);
                }

                return _anaMneseRepositorio;
            }
        }

        public IRepositoryBase<PerguntasAnamnese> PerguntaAnamneseRepositorio
        {
            get
            {
                if (_perguntaAnamneseRepositorio == null)
                {
                    _perguntaAnamneseRepositorio = new RepositorioBase<PerguntasAnamnese>(_db);
                }

                return _perguntaAnamneseRepositorio;
            }
        }

        public IRepositoryBase<RespostaPerguntaAnamnese> RespostaPerguntaAnamneseRepositorio
        {
            get
            {
                if (_respostaPerguntaAnamneseRepositorio == null)
                {
                    _respostaPerguntaAnamneseRepositorio = new RepositorioBase<RespostaPerguntaAnamnese>(_db);
                }

                return _respostaPerguntaAnamneseRepositorio;
            }
        }

        public IRepositoryBase<ModeloPergunta> ModeloPerguntaRepositorio
        {
            get
            {
                if (_modeloPerguntaRepositorio == null)
                {
                    _modeloPerguntaRepositorio = new RepositorioBase<ModeloPergunta>(_db);
                }

                return _modeloPerguntaRepositorio;
            }
        }

        public IRepositoryBase<FornecedorClinica> FornecedorRepositorio
        {
            get
            {
                if (_fornecedorRepositorio == null)
                {
                    _fornecedorRepositorio = new RepositorioBase<FornecedorClinica>(_db);
                }

                return _fornecedorRepositorio;
            }
        }

        public IRepositoryBase<Usuario> UsuarioRepositorio
        {
            get
            {
                if (_usuarioRepositorio == null)
                {
                    _usuarioRepositorio = new RepositorioBase<Usuario>(_db);
                }

                return _usuarioRepositorio;
            }
        }

        public IRepositoryBase<Perfil> PerfilRepositorio
        {
            get
            {
                if (_perfilRepositorio == null)
                {
                    _perfilRepositorio = new RepositorioBase<Perfil>(_db);
                }

                return _perfilRepositorio;
            }
        }

        public IRepositoryBase<FatorSanguineo> FatorSanguineoRepositorio
        {
            get
            {
                if (_fatorSanguineoRepositorio == null)
                {
                    _fatorSanguineoRepositorio = new RepositorioBase<FatorSanguineo>(_db);
                }

                return _fatorSanguineoRepositorio;
            }
        }

        public IRepositoryBase<Escolaridade> EscolaridadeRepositorio
        {
            get
            {
                if (_escolaridadeRepositorio == null)
                {
                    _escolaridadeRepositorio = new RepositorioBase<Escolaridade>(_db);
                }

                return _escolaridadeRepositorio;
            }
        }

        public IRepositoryBase<Paciente> PacienteRepositorio
        {
            get
            {
                if (_pacienteRepositorio == null)
                {
                    _pacienteRepositorio = new RepositorioBase<Paciente>(_db);
                }

                return _pacienteRepositorio;
            }
        }

        public IRepositoryBase<PacienteDadosComplementares> PacienteDadoComplementarRepositorio
        {
            get
            {
                if (_pacienteDadoComplementarRepositorio == null)
                {
                    _pacienteDadoComplementarRepositorio = new RepositorioBase<PacienteDadosComplementares>(_db);
                }

                return _pacienteDadoComplementarRepositorio;
            }
        }

        public IRepositoryBase<DescritivoTabelasPlano> TabelasProcedimentoRepositorio
        {
            get
            {
                if (_tabelasDescritivoRepositorio == null)
                {
                    _tabelasDescritivoRepositorio = new RepositorioBase<DescritivoTabelasPlano>(_db);
                }

                return _tabelasDescritivoRepositorio;
            }
        }

        public IRepositoryBase<ConvenioPlano> PlanoRepositorio
        {
            get
            {
                if (_planoRepositorio == null)
                {
                    _planoRepositorio = new RepositorioBase<ConvenioPlano>(_db);
                }

                return _planoRepositorio;
            }
        }

        public IRepositoryBase<TabelaDerivadaCobrancaProcedimentoItem> TabelaDerivadaProcedimentoItemRepositorio
        {
            get
            {
                if (_tabelaDerivadaProcedimentoItemRepositorio == null)
                {
                    _tabelaDerivadaProcedimentoItemRepositorio = new RepositorioBase<TabelaDerivadaCobrancaProcedimentoItem>(_db);
                }

                return _tabelaDerivadaProcedimentoItemRepositorio;
            }
        }

        public IRepositoryBase<TabelaDerivadaCobrancaProcedimento> TabelaDerivadaProcedimentoRepositorio
        {
            get
            {
                if (_tabelaDerivadaProcedimentoRepositorio == null)
                {
                    _tabelaDerivadaProcedimentoRepositorio = new RepositorioBase<TabelaDerivadaCobrancaProcedimento>(_db);
                }

                return _tabelaDerivadaProcedimentoRepositorio;
            }
        }

        public IRepositoryBase<TabelaCBHPM> TabelaCBHPMRepositorio
        {
            get
            {
                if (_tabelaTabelaCBHPMRepositorio == null)
                {
                    _tabelaTabelaCBHPMRepositorio = new RepositorioBase<TabelaCBHPM>(_db);
                }

                return _tabelaTabelaCBHPMRepositorio;
            }
        }

        public IRepositoryBase<Tabela26> ConselhoProfissionalRepositorio
        {
            get
            {
                if (_conselhoProfissionalRepositorio == null)
                {
                    _conselhoProfissionalRepositorio = new RepositorioBase<Tabela26>(_db);
                }

                return _conselhoProfissionalRepositorio;
            }
        }

        public IRepositoryBase<Tabela24> CBORepositorio
        {
            get
            {
                if (_cboRepositorio == null)
                {
                    _cboRepositorio = new RepositorioBase<Tabela24>(_db);
                }

                return _cboRepositorio;
            }
        }

        public IRepositoryBase<ExameFisico> ExameFisicoRepositorio
        {
            get
            {
                if (_exameFisicoRepositorio == null)
                {
                    _exameFisicoRepositorio = new RepositorioBase<ExameFisico>(_db);
                }

                return _exameFisicoRepositorio;
            }
        }

        public IRepositoryBase<Atendimento> ProntuarioRepositorio
        {
            get
            {
                if (_prontuarioRepositorio == null)
                {
                    _prontuarioRepositorio = new RepositorioBase<Atendimento>(_db);
                }

                return _prontuarioRepositorio;
            }
        }

        public IRepositoryBase<ProntuarioRespostaAnamnese> ProntuarioRespostaAnamneseRepositorio
        {
            get
            {
                if (_prontuarioRespostaAnamneseRepositorio == null)
                {
                    _prontuarioRespostaAnamneseRepositorio = new RepositorioBase<ProntuarioRespostaAnamnese>(_db);
                }

                return _prontuarioRespostaAnamneseRepositorio;
            }
        }

        public IRepositoryBase<ProntuarioProcedimento> ProntuarioProcedimentoRepositorio
        {
            get
            {
                if (_prontuarioProcedimentoRepositorio == null)
                {
                    _prontuarioProcedimentoRepositorio = new RepositorioBase<ProntuarioProcedimento>(_db);
                }

                return _prontuarioProcedimentoRepositorio;
            }
        }

        public IRepositoryBase<Cid> CidRepositorio
        {
            get
            {
                if (_cidRepositorio == null)
                {
                    _cidRepositorio = new RepositorioBase<Cid>(_db);
                }

                return _cidRepositorio;
            }
        }

        public IRepositoryBase<Atestado> AtestadoRepositorio
        {
            get
            {
                if (_atestadoRepositorio == null)
                {
                    _atestadoRepositorio = new RepositorioBase<Atestado>(_db);
                }

                return _atestadoRepositorio;
            }
        }

        #endregion

        #region Metodos
        public int Save()
        {
            return _db.SaveChanges();

        }

        public IDatabaseTransaction BeginTransaction()
        {
            return new EntityDatabaseTransaction(_db);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        #endregion
    }
}
