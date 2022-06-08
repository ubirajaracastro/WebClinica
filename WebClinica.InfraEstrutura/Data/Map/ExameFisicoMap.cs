using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ExameFisicoMap:EntityTypeConfiguration<ExameFisico>
    {
        public ExameFisicoMap()
        {
            ToTable("TblExameFisico");

            Property(x => x.ExameId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                HasKey(x => x.ExameId);

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Peso)
                .IsOptional();

            Property(x => x.FrequenciaRespiratoria)
                .IsOptional();

            Property(x => x.Altura)
                .IsOptional();

            Property(x => x.FrequenciaCardiaca)
                .IsOptional();

            Property(x => x.PressãoArterialsistotica)
                .IsOptional();

            Property(x => x.PressãoArterialdiastolica)
                .IsOptional();

            Property(x => x.Temperatura)
                .IsOptional();

            Property(x => x.Hemoglucoteste)
                .IsOptional();

          
        }

    }
}
