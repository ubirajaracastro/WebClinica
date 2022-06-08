using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ProfissionalMap : EntityTypeConfiguration<Profissional>
    {
        public ProfissionalMap()
        {
            ToTable("TblProfissional");
            HasKey(x => x.ProfissionalId);

            Property(x => x.ProfissionalId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
            .IsRequired();

            Property(x => x.CPF)
             .IsRequired();

            Property(x => x.DataCadastro)
               .IsRequired();

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Registro)
                .IsRequired();                       
            
            Property(x => x.CodigoConselhoProfissional)
              .IsRequired();

            Property(x => x.CodigoUFConselhoProfisional)
             .IsRequired();

            Property(x => x.CodigoCBOOcupacao)
             .IsRequired();

            Property(x => x.CNPJClinica)
                 .IsRequired()
          .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Telefone);
            Property(x => x.Endereco);
            Property(x => x.Numero);
            Property(x => x.Bairro);
            Property(x => x.Cep);
            Property(x => x.Login);
            Property(x => x.Senha);
            Property(x => x.Ativo);


        }

    }
}
