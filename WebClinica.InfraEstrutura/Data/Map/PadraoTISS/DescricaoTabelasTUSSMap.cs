using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class DescricaoTabelasTUSSMap:EntityTypeConfiguration<DescricaoTabelasTUSS>
    {
        public DescricaoTabelasTUSSMap()
        {
            ToTable("DescricaoTabelas");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NumeroTabela);
            Property(x => x.DescricaoTabela);

        }
    }
}
