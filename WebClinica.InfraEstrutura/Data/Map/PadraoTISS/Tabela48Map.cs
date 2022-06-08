using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela48Map:EntityTypeConfiguration<Tabela48>
    {
        public Tabela48Map()
        {
            ToTable("TAB_48");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
