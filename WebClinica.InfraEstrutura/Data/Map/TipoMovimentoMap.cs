using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TipoMovimentoMap:EntityTypeConfiguration<TipoMovimento>
    {
        public TipoMovimentoMap()
        {
            ToTable("TblTipodeMovimento");
            HasKey(x => x.TipoMovimentoId);

            Property(x => x.TipoMovimentoId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
             .IsRequired();

            Property(x => x.Movimento)
            .IsRequired();

            Property(x => x.CNPJClinica)
           .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Ativo);
            
        }
    }
}
