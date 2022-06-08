using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class MovimentacaoEstoqueMap:EntityTypeConfiguration<MovimentacaoEstoque>
    {

        public MovimentacaoEstoqueMap()
        {
            ToTable("TblMovimentacaoEstoque");

            Property(x => x.MovimentacaoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.MovimentacaoId);
            Property(x => x.Data)
            .IsRequired();

            Property(x => x.CNPJClinica)
                .IsRequired()
           .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.CodigoBarras);
            Property(x => x.Qtde);

            Property(x => x.ValorUnitario)
                .IsRequired();

            Property(x => x.Observacao);

            HasRequired(x => x.TipoMovimento);
            HasRequired(x => x.Produto);
            

        }
    }
}
