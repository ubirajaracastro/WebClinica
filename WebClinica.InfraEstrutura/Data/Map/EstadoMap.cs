using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class EstadoMap:EntityTypeConfiguration<WEstado>
    {
        public EstadoMap()
        {
            ToTable("Estado");

            Property(x => x.Id);
            HasKey(x => x.Id);

            Property(x => x.EstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("cod_estado");

            Property(x => x.PaisId)
                .HasColumnName("cod_pais");

            Property(x => x.Sigla)
              .HasColumnName("sgl_estado");
            
           
            Property(x => x.Nome)
                 .HasColumnName("nom_estado");
        }
        


    }
}
