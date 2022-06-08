using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TituloMap:EntityTypeConfiguration<Titulo>
    {
        public TituloMap()
        {
            ToTable("TblTitulo");
            HasKey(x => x.TituloId);

            Property(x => x.TituloId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                            

            Property(x => x.Data)
            .IsRequired();

            Property(x => x.Descricao)
             .IsRequired();

            Property(x => x.DataVencto)
           .IsRequired();

            Property(x => x.Valor)
           .IsRequired();

            Property(x => x.DocumentoId)
          .IsRequired();

            Property(x => x.PagarNoAto);
            Property(x => x.DataPagto);
            Property(x => x.ValorDesconto);
            Property(x => x.ValorAcrescimo);
            Property(x => x.Valor);

            //se pagamento parcelado
            Property(x => x.ContaParcelada);
            Property(x => x.ValorParcela);
                                  

            HasRequired(x => x.CategoriaCentroCusto);
            HasRequired(x => x.Profissional);
            HasRequired(x => x.Fornecedor);
            HasRequired(x => x.Conta);

            HasMany(x => x.Parcelas);              

            Property(x => x.CNPJClinica)
          .IsRequired()
           .HasColumnAnnotation(
                  IndexAnnotation.AnnotationName,
                  new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

        }
    }
}
