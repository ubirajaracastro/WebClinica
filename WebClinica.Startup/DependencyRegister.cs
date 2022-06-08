using Microsoft.Practices.Unity;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.PadraoTISS;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.InfraEstrutura.Data;
using WebClinica.InfraEstrutura.Data.Repositorios;
using WebClinica.Negocio;

namespace Weblinica.Startup
{
    public static class DependencyRegister
    {
        //teste 05/02
        public static void Resolve(IUnityContainer container)
        {
            #region Container IOC
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());         
            container.RegisterType<WebClinicaDataContext, WebClinicaDataContext>(new HierarchicalLifetimeManager());

            container.RegisterType<IConfiguracaoClinicaService, ConfiguracaoClinicaService>(new HierarchicalLifetimeManager());
            container.RegisterType<ConfiguracaoClinica, ConfiguracaoClinica>(new HierarchicalLifetimeManager());
                                   
            container.RegisterType<IClinicaService,ClinicaService>(new HierarchicalLifetimeManager());
            container.RegisterType<Clinica, Clinica>(new HierarchicalLifetimeManager());

            container.RegisterType<IEspecialidadeService, EspecialidadeService>(new HierarchicalLifetimeManager());
            container.RegisterType<Tabela24, Tabela24>(new HierarchicalLifetimeManager());

            container.RegisterType<IEstadoService, EstadoService>(new HierarchicalLifetimeManager());
            container.RegisterType<WEstado, WEstado>(new HierarchicalLifetimeManager());
           
            container.RegisterType<ICidadeService, CidadeService>(new HierarchicalLifetimeManager());
            container.RegisterType<WCidade, WCidade>(new HierarchicalLifetimeManager());
                       
            container.RegisterType<IConvenioService, ConvenioService>(new HierarchicalLifetimeManager());
            container.RegisterType<Convenio, Convenio>(new HierarchicalLifetimeManager());
          
            container.RegisterType<IProfissionalService, ProfissionalService>(new HierarchicalLifetimeManager());
            container.RegisterType<Profissional, Profissional>(new HierarchicalLifetimeManager());          
                                         
            container.RegisterType<IProcedimentoService, ProcedimentoService>(new HierarchicalLifetimeManager());
            container.RegisterType<Procedimento, Procedimento>(new HierarchicalLifetimeManager());
           
            container.RegisterType<ITipodeConsultaService, TipodeConsultaService>(new HierarchicalLifetimeManager());
            container.RegisterType<TipodeConsulta, TipodeConsulta>(new HierarchicalLifetimeManager());
          
            container.RegisterType<ITabelaNormativaUSSService, TabelaNormativaUSSService>(new HierarchicalLifetimeManager());
            container.RegisterType<TabelaNormativaUSS, TabelaNormativaUSS>(new HierarchicalLifetimeManager());
                        
            container.RegisterType<IProcedimentoCobrancaService, ProcedimentoCobrancaService>(new HierarchicalLifetimeManager());
            container.RegisterType<ProcedimentoCobranca, ProcedimentoCobranca>(new HierarchicalLifetimeManager());

            container.RegisterType<IComissaoService, ComissaoService>(new HierarchicalLifetimeManager());
            container.RegisterType<EntidadeComissao, EntidadeComissao>(new HierarchicalLifetimeManager());

            container.RegisterType<IModeloAnamneseService, ModeloAnamneseService>(new HierarchicalLifetimeManager());
            container.RegisterType<ModeloAnamnese, ModeloAnamnese>(new HierarchicalLifetimeManager());

            container.RegisterType<IPerguntaAnamneseService, PerguntaAnamneseService>(new HierarchicalLifetimeManager());
            container.RegisterType<PerguntaAnamneseService, PerguntaAnamneseService>(new HierarchicalLifetimeManager());

            container.RegisterType<IRespostaPerguntaAnamneseService, RespostaPerguntaAnamneseService>(new HierarchicalLifetimeManager());
            container.RegisterType<RespostaPerguntaAnamnese, RespostaPerguntaAnamnese>(new HierarchicalLifetimeManager());

            container.RegisterType<IFornecedorService, FornecedorService>(new HierarchicalLifetimeManager());
            container.RegisterType<FornecedorClinica, FornecedorClinica>(new HierarchicalLifetimeManager());

            container.RegisterType<IUsuarioService, UsuarioService>(new HierarchicalLifetimeManager());
            container.RegisterType<Usuario, Usuario>(new HierarchicalLifetimeManager());

            container.RegisterType<IPerfilService, PerfilService>(new HierarchicalLifetimeManager());
            container.RegisterType<Perfil, Perfil>(new HierarchicalLifetimeManager());

            container.RegisterType<IFatorSanguineoService, FatorSanguineoService>(new HierarchicalLifetimeManager());
            container.RegisterType<FatorSanguineo, FatorSanguineo>(new HierarchicalLifetimeManager());

            container.RegisterType<IEscolaridadeService, EscolaridadeService>(new HierarchicalLifetimeManager());
            container.RegisterType<Escolaridade, Escolaridade>(new HierarchicalLifetimeManager());

            container.RegisterType<IPacienteService, PacienteService>(new HierarchicalLifetimeManager());
            container.RegisterType<Paciente, Paciente>(new HierarchicalLifetimeManager());

            container.RegisterType<IDescritivoTabelasPlanoService, DescritivoTabelasPlanoService>(new HierarchicalLifetimeManager());
            container.RegisterType<DescritivoTabelasPlano, DescritivoTabelasPlano>(new HierarchicalLifetimeManager());

            container.RegisterType<ITabelaDerivadaCobrancaProcedimentoService, TabelaDerivadaCobrancaProcedimentoService>(new HierarchicalLifetimeManager());
            container.RegisterType<TabelaDerivadaCobrancaProcedimentoItem, TabelaDerivadaCobrancaProcedimentoItem>(new HierarchicalLifetimeManager());

            container.RegisterType<ITabelaCBHPMService, TabelaCBHPMService>(new HierarchicalLifetimeManager());
            container.RegisterType<TabelaCBHPM, TabelaCBHPM>(new HierarchicalLifetimeManager());

            container.RegisterType<IConselhoProfissionalService, ConselhoProfissionalService>(new HierarchicalLifetimeManager());
            container.RegisterType<Tabela26, Tabela26>(new HierarchicalLifetimeManager());

            container.RegisterType<IAtendimentoService, AtendimentoService>(new HierarchicalLifetimeManager());
            container.RegisterType<Atendimento, Atendimento>(new HierarchicalLifetimeManager());

            #endregion
        }
    }
}
