using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ClinicaMap : EntityTypeConfiguration<Clinica>
    {
        public ClinicaMap()
        {
            ToTable("TblClinica");
            HasKey(x => x.ClinicaId);

            Property(x => x.ClinicaId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJ)
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = true }))       
           .IsRequired();

            Property(x => x.NomeClinica)            
              .IsRequired();

            Property(x => x.Email)           
            .IsRequired();

            Property(x => x.CPFResponsavel)          
           .IsRequired();

            Property(x => x.NomeResponsavel)           
                 .IsRequired();

            Property(x => x.Telefone)
              .IsRequired();

            Property(x => x.Endereco);
            Property(x => x.Numero);
            Property(x => x.Bairro);
            Property(x => x.UtilizaTISS);
            Property(x => x.CNES);
            Property(x => x.IdEstado);
            Property(x => x.IdCidade);           
            
        }

    }
}
