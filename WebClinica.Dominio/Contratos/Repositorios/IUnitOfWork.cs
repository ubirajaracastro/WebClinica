using System;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.Dominio.Contratos.Repositorios
{
    public interface IUnitOfWork:IDisposable
    {
        #region membros
        IRepositoryBase<ConfiguracaoClinica> ConfiguracaoClinicaRepositorio { get; }
        IRepositoryBase<Clinica> ClinicaRepositorio { get; }
        IRepositoryBase<WEstado> EstadoRepositorio { get; }
        IRepositoryBase<WCidade> CidadeRepositorio { get; }
        IRepositoryBase<Convenio> ConvenioRepositorio { get; }
        IRepositoryBase<Profissional> ProfissionalRepositorio { get; }             
        IRepositoryBase<Procedimento> ProcedimentoRepositorio { get; }
        IRepositoryBase<TipodeConsulta> TipodeConsultaRepositorio { get; }
        IRepositoryBase<TabelaNormativaUSS> TabelaNormativaUSSRepositorio { get; }
        IRepositoryBase<ConvenioProfissional> ConvenioProfissionalRepositorio { get; }
        IRepositoryBase<ProcedimentoCobranca> ProcedimentoCobrancaRepositorio { get; }
        IRepositoryBase<EntidadeComissao> ComissaoRepositorio { get; }
        IRepositoryBase<ModeloAnamnese> AnamneseRepositorio { get; }
        IRepositoryBase<PerguntasAnamnese> PerguntaAnamneseRepositorio { get; }
        IRepositoryBase<RespostaPerguntaAnamnese> RespostaPerguntaAnamneseRepositorio { get; }
        IRepositoryBase<ModeloPergunta> ModeloPerguntaRepositorio { get; }
        IRepositoryBase<FornecedorClinica> FornecedorRepositorio { get; }
        IRepositoryBase<Usuario> UsuarioRepositorio { get; }
        IRepositoryBase<Perfil> PerfilRepositorio { get; }
        IRepositoryBase<FatorSanguineo> FatorSanguineoRepositorio { get; }
        IRepositoryBase<Escolaridade> EscolaridadeRepositorio { get; }
        IRepositoryBase<Paciente> PacienteRepositorio { get; }
        IRepositoryBase<PacienteDadosComplementares> PacienteDadoComplementarRepositorio { get; }
        IRepositoryBase<DescritivoTabelasPlano> TabelasProcedimentoRepositorio { get; }
        IRepositoryBase<ConvenioPlano> PlanoRepositorio { get; }
        IRepositoryBase<TabelaDerivadaCobrancaProcedimentoItem> TabelaDerivadaProcedimentoItemRepositorio { get; }
        IRepositoryBase<TabelaDerivadaCobrancaProcedimento> TabelaDerivadaProcedimentoRepositorio { get; }
        IRepositoryBase<TabelaCBHPM> TabelaCBHPMRepositorio { get; }
        IRepositoryBase<Tabela26> ConselhoProfissionalRepositorio { get; }
        IRepositoryBase<Tabela24> CBORepositorio { get; }
        IRepositoryBase<ExameFisico> ExameFisicoRepositorio { get; }
        IRepositoryBase<Atendimento> ProntuarioRepositorio { get; }
        IRepositoryBase<ProntuarioRespostaAnamnese> ProntuarioRespostaAnamneseRepositorio { get; }
        IRepositoryBase<ProntuarioProcedimento> ProntuarioProcedimentoRepositorio { get; }
        IRepositoryBase<Cid> CidRepositorio { get; }
        IRepositoryBase<Atestado> AtestadoRepositorio { get; }
        IDatabaseTransaction BeginTransaction();
        #endregion
        int Save();
       

    }
}

