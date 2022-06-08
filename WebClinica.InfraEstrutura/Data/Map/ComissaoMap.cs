using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ComissaoMap:EntityTypeConfiguration<EntidadeComissao>
    {
        public ComissaoMap()
        {
            ToTable("TblComissao");

            HasKey(x => x.ComissaoId);

            Property(x => x.ComissaoId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DescricaoComissao)
            .IsRequired();         

            Property(x => x.Ativo);
            Property(x => x.ValorComissao);
                      
            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            HasRequired(x => x.Profissional);
            HasRequired(x => x.Convenio);
            HasRequired(x => x.Procedimento);

        }

    }
}
