using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela47Map:EntityTypeConfiguration<Tabela47>
    {
        public Tabela47Map()
        {
            ToTable("TAB_47");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
