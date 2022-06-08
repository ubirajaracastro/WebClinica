using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class OrcamentoMap:EntityTypeConfiguration<Orcamento>
    {
        public OrcamentoMap()
        {
            ToTable("TblOrcamento");
            HasKey(x => x.OrcamentoId);

            Property(x => x.OrcamentoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DataSolicitacao)
            .IsRequired();

            Property(x => x.DescricaoOrcamento)
            .IsRequired();

            Property(x => x.ValidoAte)
            .IsRequired();

            Property(x => x.Desconto);
            Property(x => x.Acrescimo);

            Property(x => x.qtdeParcelas);                

            Property(x => x.Aprovado)
             .IsRequired();

            Property(x => x.CNPJClinica)
               .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            HasRequired(x => x.Paciente);
            HasRequired(x => x.Clinica);
            HasMany(x => x.Procedimentos);
        }

    }
}
