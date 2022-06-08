using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class SolicitacaoExameMap:EntityTypeConfiguration<SolicitacaoExame>
    {
        public SolicitacaoExameMap()
        {
            ToTable("TblSolicitacaoExame");
            HasKey(x => x.SolicitacaoExameId);

            Property(x => x.SolicitacaoExameId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.DataSolicitacao)
            .IsRequired();

            Property(x => x.Nome);
            Property(x => x.TUSSId);
            Property(x => x.TextoSolicitacao);


            HasRequired(x => x.Profissional);
            HasRequired(x => x.Clinica);
            HasRequired(x => x.Paciente);

        }

    }
}
