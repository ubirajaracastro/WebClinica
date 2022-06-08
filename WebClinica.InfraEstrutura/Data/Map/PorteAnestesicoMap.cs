using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PorteAnestesicoMap: EntityTypeConfiguration<PorteAnestesico>
    {
        public PorteAnestesicoMap()
        {
            ToTable("TblPorteAnestesico");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Descricao);
        }
    }
}
