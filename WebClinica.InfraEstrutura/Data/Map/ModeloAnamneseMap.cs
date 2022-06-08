using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ModeloAnamneseMap:EntityTypeConfiguration<ModeloAnamnese>
    {
        public ModeloAnamneseMap()
        {
            ToTable("TblModeloAnamnese");

            Property(x => x.ModeloId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.ModeloId);

            Property(x => x.Nome)
                .IsRequired();

            Property(x => x.CNPJClinica)
               .IsRequired()
                .HasColumnAnnotation(
                            IndexAnnotation.AnnotationName,
                            new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.PadraodaClinica);
            Property(x => x.Ativo);


        }

    }
}
