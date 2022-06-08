using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class UnidadeMedidaMap:EntityTypeConfiguration<UnidadeMedida>
    {
        public UnidadeMedidaMap()
        {
            ToTable("TblUnidadeMedida");
            this.HasKey(x => x.UnidadeId);

            Property(x => x.UnidadeId)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

           
            Property(x => x.Nome)
             .IsRequired();

            Property(x => x.Abreviatura)
             .IsRequired();

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


        }

    }
}
