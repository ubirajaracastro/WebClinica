using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ProdutoMap:EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("TblProduto");
            HasKey(x => x.ProdutoId);

            Property(x => x.ProdutoId)
          .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DataEntrada)
            .IsRequired();

            Property(x => x.Descricao)
             .IsRequired();

            Property(x => x.CodigodeBarras);

            Property(x => x.EstoqueMinimo)
            .IsRequired();

            Property(x => x.CNPJClinica)
                .IsRequired()
           .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Ativo);

         
            HasRequired(x => x.UnidadeMedida);
            HasRequired(x => x.GrupoProduto);
        }


    }
}
