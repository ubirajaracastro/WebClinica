using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela39Map:EntityTypeConfiguration<Tabela39>
    {
        public Tabela39Map()
        {
            ToTable("TAB_39");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
