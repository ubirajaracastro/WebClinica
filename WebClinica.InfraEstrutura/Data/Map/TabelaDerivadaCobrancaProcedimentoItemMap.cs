using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TabelaDerivadaCobrancaProcedimentoItemMap: 
        EntityTypeConfiguration<TabelaDerivadaCobrancaProcedimentoItem>
    {
        public TabelaDerivadaCobrancaProcedimentoItemMap()
        {
            ToTable("TblTabelaDerivadaProcedimentoItem");

            HasKey(x => x.TabelaDerivadaCobrancaProcedimentoItemID);

            Property(x => x.TabelaDerivadaCobrancaProcedimentoItemID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodigoProcedimento)
                .IsRequired();

            Property(x => x.ValorUCO)
                .IsOptional();          

            Property(x => x.NovoValor)
                .IsRequired();

            HasRequired(x => x.Tabela);
          
        }

    }
}
