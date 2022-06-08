using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela54Map:EntityTypeConfiguration<Tabela54>
    {
        public Tabela54Map()
        {
            ToTable("TAB_54");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
