using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;


namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela44Map:EntityTypeConfiguration<Tabela44>
    {
        public Tabela44Map()
        {
            ToTable("TAB_44");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
