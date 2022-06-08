using System.Data.Entity;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.PadraoTISS;
using WebClinica.InfraEstrutura.Data.Map.PadraoTISS;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebClinica.InfraEstrutura.Data.Map;

namespace WebClinica.InfraEstrutura.Data
{
    public class WebClinicaDataContext : DbContext
    {
        public WebClinicaDataContext() : base("webClinicaContexto")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;           
            
        }

        #region DbSets
        public DbSet<Clinica> TblClinica { get; set; }
        public DbSet<Agendamento> TblAgendamento { get; set; }
        public DbSet<ASO> TblASO { get; set; }
        public DbSet<ASOFichaClinica> TblASOFichaClinica { get; set; }
        public DbSet<Atendimento> TblAtendimento { get; set; }
        public DbSet<Atestado> TblAtestado { get; set; }
        //public DbSet<EntidadeComissao> TblComissao { get; set; }
        public DbSet<CentroCusto> TblCentroCusto { get; set; }
        public DbSet<CategoriaCentroCusto> TblCategoriaCentroCusto { get; set; }
        public DbSet<ConfiguracaoClinica> TblConfiguracaoClinica { get; set; }
        public DbSet<ConfiguracaoFinanceiro> TblConfiguracaoFinanceiro { get; set; }
        public DbSet<Convenio> TblConvenio { get; set; }
        public DbSet<ConvenioProfissional> TblConvenioProfissional { get; set; }           
        public DbSet<EscalaAtendimentoProfissional> tblEscalaProfissional { get; set; }
        public DbSet<ExameComplementarPCMSO> TblExameComplementarPCMSO { get; set; }
        public DbSet<EscalaAtendimentoProfissionalDiaSemana> EscalaAtendimentoProfissionalDiaSemana { get; set; }
        public DbSet<ExameFisico> TblExameFisico { get; set; }
        public DbSet<Escolaridade> TblEscolaridade { get; set; }
        public DbSet<Fatura> TblFatura { get; set; }
        public DbSet<FornecedorClinica> TblFornecedor { get; set; }
        public DbSet<FormaPagamento> TblFormaPagamento { get; set; }
        public DbSet<GrupoProduto> TblGrupoProduto { get; set; }       
        public DbSet<ModeloAnamnese> TblModeloAnamnese { get; set; }
        public DbSet<Orcamento> TblOrcamento { get; set; }
        public DbSet<Paciente> TblPaciente { get; set; }      
        public DbSet<PacienteDadosComplementares> tblPacienteDadoComplementar { get; set; }
        public DbSet<ProcedimentoCobranca> TblProcedimentoCobranca { get; set; }
        public DbSet<Titulo> TblTitulo { get; set; }
        public DbSet<Parcelamento> TblParcelamentoTitulo { get; set; }
        public DbSet<Perfil> TblPerfil { get; set; }
        public DbSet<Usuario> TblUsuario { get; set; }
        public DbSet<PerguntasAnamnese> TblPerguntasAnamnese { get; set; }       
        public DbSet<Procedimento> TblProcedimento { get; set; }
        public DbSet<Produto> TblProduto { get; set; }
        public DbSet<Profissional> TblProfissional { get; set; }       
        public DbSet<Pais> TblPais { get; set; }      
        public DbSet<RespostaPerguntaAnamnese> TblRespostaPerguntaAnamnese { get; set; }
        public DbSet<RiscoOcupacional> TblRiscoOcupacional { get; set; }
        public DbSet<SolicitacaoExame> TblSolicitacaoExame { get; set; }
        public DbSet<StatusAgendamento> TblStatusAgendamento { get; set; }
        public DbSet<TipodeConsulta> TblTipodeConsulta { get; set; }
        public DbSet<TipoMovimento> TblTipoMovimento { get; set; }
        public DbSet<MovimentacaoEstoque> TblMovimentacaoEstoque { get; set; }
        public DbSet<UnidadeMedida> TblUnidadeMedida { get; set; }
        public DbSet<Banco> TblBanco { get; set; }
        public DbSet<ContaCorrente> TblContaCorrente { get; set; }
        public DbSet<WEstado> TblEstado { get; set; }
        public DbSet<WCidade> TblCidade { get; set; }
        public DbSet<FatorSanguineo> TblFatorSanguineo { get; set; }
        public DbSet<ProntuarioRespostaAnamnese> TblProntuarioRespostaAnamnese { get; set; }
        public DbSet<ProntuarioProcedimento> TblProntuarioProcedimento{ get; set; }

        //entidades teminologia TISS
        public DbSet<DescricaoTabelasTUSS> TblDescricaoTabela { get; set; }
        public DbSet<Tabela18> TblTabela18 { get; set; }
        public DbSet<Tabela19> TblTabela19 { get; set; }
        public DbSet<Tabela20> TblTabela20 { get; set; }
        public DbSet<Tabela22> TblTabela22 { get; set; }
        public DbSet<Tabela23> TblTabela23 { get; set; }
        public DbSet<Tabela24> TblTabela24 { get; set; }
        public DbSet<Tabela25> TblTabela25 { get; set; }
        public DbSet<Tabela26> TblTabela26 { get; set; }
        public DbSet<Tabela27> TblTabela27 { get; set; }
        public DbSet<Tabela28> TblTabela28 { get; set; }
        public DbSet<Tabela29> TblTabela29 { get; set; }
        public DbSet<Tabela30> TblTabela30 { get; set; }
        public DbSet<Tabela31> TblTabela31 { get; set; }
        public DbSet<Tabela32> TblTabela32 { get; set; }
        public DbSet<Tabela33> TblTabela33 { get; set; }
        public DbSet<Tabela34> TblTabela34 { get; set; }
        public DbSet<Tabela35> TblTabela35 { get; set; }
        public DbSet<Tabela36> TblTabela36 { get; set; }
        public DbSet<Tabela37> TblTabela37 { get; set; }
        public DbSet<Tabela38> TblTabela38{ get; set; }
        public DbSet<Tabela39> TblTabela39 { get; set; }
        public DbSet<Tabela40> TblTabela40 { get; set; }
        public DbSet<Tabela41> TblTabela41 { get; set; }
        public DbSet<Tabela42> TblTabela42 { get; set; }
        public DbSet<Tabela43> TblTabela43 { get; set; }
        public DbSet<Tabela44> TblTabela44 { get; set; }
        public DbSet<Tabela45> TblTabela45 { get; set; }
        public DbSet<Tabela46> TblTabela46 { get; set; }
        public DbSet<Tabela47> TblTabela47 { get; set; }
        public DbSet<Tabela48> TblTabela48 { get; set; }
        public DbSet<Tabela49> TblTabela49 { get; set; }
        public DbSet<Tabela50> TblTabela50 { get; set; }
        public DbSet<Tabela51> TblTabela51 { get; set; }
        public DbSet<Tabela52> TblTabela52 { get; set; }
        public DbSet<Tabela53> TblTabela53 { get; set; }
        public DbSet<Tabela54> TblTabela54 { get; set; }
        public DbSet<Tabela55> TblTabela55 { get; set; }
        public DbSet<Tabela56> TblTabela56 { get; set; }
        public DbSet<Tabela57> TblTabela57 { get; set; }
        public DbSet<Tabela58> TblTabela58 { get; set; }
        public DbSet<Tabela59> TblTabela59 { get; set; }
        public DbSet<Tabela60> TblTabela60 { get; set; }
        public DbSet<Tabela61> TblTabela61 { get; set; }
        public DbSet<Tabela62> TblTabela62 { get; set; }
        public DbSet<Tabela63> TblTabela63 { get; set; }
        public DbSet<Tabela64> TblTabela64 { get; set; }
        // FIM entidades teminologia TISS
        #endregion

        #region Metodos
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
               .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Entity<Atendimento>()
                .Property(p => p.PrescricaoMedica)
                 .HasMaxLength(400);
                       
            modelBuilder.Properties<string>()
               .Configure(p => p.HasMaxLength(200));

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                       
            modelBuilder.Configurations.Add(new AgendamentoMap());
            modelBuilder.Configurations.Add(new AsoFichaClinicaMap());
            modelBuilder.Configurations.Add(new AsoMap());
            modelBuilder.Configurations.Add(new AtendimentoMap());
            modelBuilder.Configurations.Add(new AtestadoMap());
            modelBuilder.Configurations.Add(new BancoMap());
            modelBuilder.Configurations.Add(new CategoriaCentroCustoMap());
            modelBuilder.Configurations.Add(new CentroCustoMap());
            modelBuilder.Configurations.Add(new ClinicaMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            //modelBuilder.Configurations.Add(new ComissaoMap());
            modelBuilder.Configurations.Add(new ConfiguracaoClinicaMap());
            modelBuilder.Configurations.Add(new ConfiguracaoFinanceiroMap());
            modelBuilder.Configurations.Add(new ContaCorrenteMap());
            modelBuilder.Configurations.Add(new ConvenioMap());
            modelBuilder.Configurations.Add(new ConvenioProfissionalMap());
            modelBuilder.Configurations.Add(new EscalaAtendimentoProfissionalDiaSemanaMap());
            modelBuilder.Configurations.Add(new EscalaAtendimentoProfissionalMap());
            modelBuilder.Configurations.Add(new EscolaridadeMap());
            modelBuilder.Configurations.Add(new ExameComplementarPCMSOMap());
            modelBuilder.Configurations.Add(new ExameFisicoMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new FatorSanguineoMap());
            modelBuilder.Configurations.Add(new FaturaMap());
            modelBuilder.Configurations.Add(new FormaPagamentoMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
            modelBuilder.Configurations.Add(new GrupoProdutoMap());
            modelBuilder.Configurations.Add(new ModeloAnamneseMap());
            modelBuilder.Configurations.Add(new MovimentacaoEstoqueMap());
            modelBuilder.Configurations.Add(new OrcamentoMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new ParcelamentoTituloMap());
            modelBuilder.Configurations.Add(new PerfilMap());           
            modelBuilder.Configurations.Add(new ProcedimentoMap());
            modelBuilder.Configurations.Add(new ProcedimentoCobrancaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());            
            modelBuilder.Configurations.Add(new ProfissionalMap());
            modelBuilder.Configurations.Add(new RiscoOcupacionalMap());
            modelBuilder.Configurations.Add(new SolicitacaoExameMap());
            modelBuilder.Configurations.Add(new StatusAgendamentoMap());
            modelBuilder.Configurations.Add(new TabelaNormativaUSSMap());
            modelBuilder.Configurations.Add(new TipodeConsultaMap());
            modelBuilder.Configurations.Add(new TipoMovimentoMap());
            modelBuilder.Configurations.Add(new TituloMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new PacienteDadoComplementarMap());           
            modelBuilder.Configurations.Add(new PerguntasAnamneseMap());
            modelBuilder.Configurations.Add(new RespostaPerguntaAnamneseMap());
            modelBuilder.Configurations.Add(new ModeloPerguntaMap());
            modelBuilder.Configurations.Add(new ConvenioPlanoMap());
            modelBuilder.Configurations.Add(new TabelaDerivadaCobrancaProcedimentoMap());
            modelBuilder.Configurations.Add(new TabelaDerivadaCobrancaProcedimentoItemMap());
            modelBuilder.Configurations.Add(new TabelaCBHPMMap());
            modelBuilder.Configurations.Add(new PorteAnestesicoMap());
            modelBuilder.Configurations.Add(new PorteProcedimentoMap());
            modelBuilder.Configurations.Add(new DescritivoTabelasPlanoMap());
            modelBuilder.Configurations.Add(new DescricaoTabelasTUSSMap());
            modelBuilder.Configurations.Add(new Tabela18Map());
            modelBuilder.Configurations.Add(new Tabela19Map());
            modelBuilder.Configurations.Add(new Tabela20Map());
            modelBuilder.Configurations.Add(new Tabela22Map());
            modelBuilder.Configurations.Add(new Tabela23Map());
            modelBuilder.Configurations.Add(new Tabela24Map());
            modelBuilder.Configurations.Add(new Tabela25Map());
            modelBuilder.Configurations.Add(new Tabela26Map());
            modelBuilder.Configurations.Add(new Tabela27Map());
            modelBuilder.Configurations.Add(new Tabela28Map());
            modelBuilder.Configurations.Add(new Tabela29Map());
            modelBuilder.Configurations.Add(new Tabela30Map());
            modelBuilder.Configurations.Add(new Tabela31Map());
            modelBuilder.Configurations.Add(new Tabela32Map());
            modelBuilder.Configurations.Add(new Tabela33Map());
            modelBuilder.Configurations.Add(new Tabela34Map());
            modelBuilder.Configurations.Add(new Tabela35Map());
            modelBuilder.Configurations.Add(new Tabela36Map());
            modelBuilder.Configurations.Add(new Tabela37Map());
            modelBuilder.Configurations.Add(new Tabela38Map());
            modelBuilder.Configurations.Add(new Tabela39Map());
            modelBuilder.Configurations.Add(new Tabela40Map());
            modelBuilder.Configurations.Add(new Tabela41Map());
            modelBuilder.Configurations.Add(new Tabela42Map());
            modelBuilder.Configurations.Add(new Tabela43Map());
            modelBuilder.Configurations.Add(new Tabela44Map());
            modelBuilder.Configurations.Add(new Tabela45Map());
            modelBuilder.Configurations.Add(new Tabela46Map());
            modelBuilder.Configurations.Add(new Tabela47Map());
            modelBuilder.Configurations.Add(new Tabela48Map());
            modelBuilder.Configurations.Add(new Tabela49Map());
            modelBuilder.Configurations.Add(new Tabela50Map());
            modelBuilder.Configurations.Add(new Tabela51Map());
            modelBuilder.Configurations.Add(new Tabela52Map());
            modelBuilder.Configurations.Add(new Tabela53Map());
            modelBuilder.Configurations.Add(new Tabela54Map());
            modelBuilder.Configurations.Add(new Tabela55Map());
            modelBuilder.Configurations.Add(new Tabela56Map());
            modelBuilder.Configurations.Add(new Tabela57Map());
            modelBuilder.Configurations.Add(new Tabela58Map());
            modelBuilder.Configurations.Add(new Tabela59Map());
            modelBuilder.Configurations.Add(new Tabela60Map());
            modelBuilder.Configurations.Add(new Tabela61Map());
            modelBuilder.Configurations.Add(new Tabela62Map());
            modelBuilder.Configurations.Add(new Tabela63Map());
            modelBuilder.Configurations.Add(new Tabela64Map());
            modelBuilder.Configurations.Add(new ProntuarioRespostaAnamneseMap());
            modelBuilder.Configurations.Add(new ProntuarioProcedimentoMap());
            modelBuilder.Configurations.Add(new CIDMap());

        }
        #endregion
    }
}
