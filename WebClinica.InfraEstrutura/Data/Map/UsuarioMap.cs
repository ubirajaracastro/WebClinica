using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("TblUsuario");
            HasKey(x => x.UsuarioId);

            Property(x => x.UsuarioId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Login)
            .IsRequired();

            Property(x => x.Email)
           .IsRequired();

            Property(x => x.Senha)
                .IsRequired();

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Ativo);
            Property(x => x.Bloqueado);
            Property(x => x.DataCadastro);           
            Property(x => x.PrimeiroAcesso);

            HasRequired(x => x.Perfil);

        }

    }
}
