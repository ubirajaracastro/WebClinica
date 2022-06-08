using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;


namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela41Map:EntityTypeConfiguration<Tabela41>
    {
        public Tabela41Map()
        {
            ToTable("TAB_41");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
