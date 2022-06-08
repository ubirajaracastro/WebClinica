using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class EscalaAtendimentoProfissionalMap:EntityTypeConfiguration<EscalaAtendimentoProfissional>
    {
        public EscalaAtendimentoProfissionalMap()
        {
            ToTable("TblEscalaAtendimentoProfissional");

            Property(x => x.EscalaId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.EscalaId);

            Property(x => x.DtInicialEscala)
             .IsRequired();

            Property(x => x.DtFinalEscala)
             .IsRequired();

            Property(x => x.CNPJClinica)
           .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Ativo);
            Property(x => x.HoraInicial);
            Property(x => x.HoraFinal);

            HasMany(x => x.DiasEscala);
            //HasRequired(x => x.Profissional);
        }

    }
}
