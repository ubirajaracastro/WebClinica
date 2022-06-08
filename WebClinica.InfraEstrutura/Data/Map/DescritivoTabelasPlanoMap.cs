using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class DescritivoTabelasPlanoMap: EntityTypeConfiguration<DescritivoTabelasPlano>
    {
        public DescritivoTabelasPlanoMap()
        {
            ToTable("TblTabelasProcedimento");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao);
        }
    }
}
