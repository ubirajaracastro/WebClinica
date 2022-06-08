using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class RiscoOcupacionalMap:EntityTypeConfiguration<RiscoOcupacional>
    {
        public RiscoOcupacionalMap()
        {
            ToTable("TblRiscoOcupacional");
            HasKey(x => x.Id);

            Property(x => x.Id)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Tipo)
            .IsRequired();

            Property(x => x.PacienteId);

            
        }
    }
}
