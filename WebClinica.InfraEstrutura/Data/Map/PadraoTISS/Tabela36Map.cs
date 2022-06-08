using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;


namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela36Map:EntityTypeConfiguration<Tabela36>
    {
        public Tabela36Map()
        {
            ToTable("TAB_36");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
