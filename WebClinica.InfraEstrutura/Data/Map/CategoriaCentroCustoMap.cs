using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class CategoriaCentroCustoMap:EntityTypeConfiguration<CategoriaCentroCusto>
    {
        public CategoriaCentroCustoMap()
        {
            ToTable("TblCategoriaCentroCusto");
            HasKey(x => x.CategoriaCentroCustoId);

            Property(x => x.CategoriaCentroCustoId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
             .IsRequired();

            Property(x => x.CentroCustoId);

            Property(x => x.CNPJ)
           .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


            HasRequired(x => x.CentroCusto);

        }
    }
}
