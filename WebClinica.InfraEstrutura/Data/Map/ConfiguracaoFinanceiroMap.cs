using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ConfiguracaoFinanceiroMap:EntityTypeConfiguration<ConfiguracaoFinanceiro>
    {
        public ConfiguracaoFinanceiroMap()
        {
            ToTable("TblConfiguracaoFinanceiro");
            HasKey(x => x.ConfiguracaoFinanceiroId);

            Property(x => x.ConfiguracaoFinanceiroId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJClinica);
            Property(x => x.ClinicaId);
            Property(x => x.ContaId);
            Property(x => x.NaoPagarComissao);
            Property(x => x.GerarComissaoLiquidacaoTitulo);
            Property(x => x.GerarComissaonoFaturamentoTitulo);

            HasRequired(x => x.Clinica);
            HasRequired(x => x.Conta);

        }

    }
}
