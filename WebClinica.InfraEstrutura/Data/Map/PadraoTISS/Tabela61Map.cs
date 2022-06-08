using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;

namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela61Map:EntityTypeConfiguration<Tabela61>
    {
        public Tabela61Map()
        {
            ToTable("TAB_61");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
