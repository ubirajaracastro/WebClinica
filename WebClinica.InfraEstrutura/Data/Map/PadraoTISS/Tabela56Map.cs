using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using WebClinica.Dominio.Entidades.PadraoTISS;


namespace WebClinica.InfraEstrutura.Data.Map.PadraoTISS
{
    public class Tabela56Map:EntityTypeConfiguration<Tabela56>
    {
        public Tabela56Map()
        {
            ToTable("TAB_56");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}
