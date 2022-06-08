using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class GrupoProdutoMap:EntityTypeConfiguration<GrupoProduto>
    {
        public GrupoProdutoMap()
        {
            ToTable("TblGrupoProduto");

            Property(x => x.GrupoId)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasKey(x => x.GrupoId);
            Property(x => x.DescricaoGrupo)
             .IsRequired();

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

        }
    }
}
