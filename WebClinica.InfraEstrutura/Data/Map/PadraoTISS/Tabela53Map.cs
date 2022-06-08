using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;


namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela53Map:EntityTypeConfiguration<Tabela53>
    {
        public Tabela53Map()
        {
            ToTable("TAB_53");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
