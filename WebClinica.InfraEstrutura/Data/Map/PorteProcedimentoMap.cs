using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PorteProcedimentoMap : EntityTypeConfiguration<PorteProcedimento>
    {
        public PorteProcedimentoMap()
        {
            ToTable("TblPorteProcedimentoMedico");
            HasKey(x => x.PorteProcedimentoId);

            Property(x => x.PorteProcedimentoId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Codigo);
            Property(x => x.Valor);

        }
    }
}
