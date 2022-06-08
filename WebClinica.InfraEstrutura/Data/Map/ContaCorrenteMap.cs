using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ContaCorrenteMap:EntityTypeConfiguration<ContaCorrente>
    {
        public ContaCorrenteMap()
        {
            ToTable("TblContaCorrente");
            HasKey(x => x.ContaId);

            Property(x => x.ContaId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.ContaId);

            Property(x => x.Nome)
             .IsRequired();

            Property(x => x.Agencia)
            .IsRequired();

            Property(x => x.AgenciaDigito)
            .IsRequired();

            Property(x => x.NumeroConta)
            .IsRequired();

            Property(x => x.NumeroContaDigito)
            .IsRequired();

            Property(x => x.SaldoIncial)
            .IsRequired();

            Property(x => x.HabilitaBoleto)
            .IsRequired();

            Property(x => x.CNPJClinica)
           .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


            HasRequired(x => x.Banco);
        }

    }
}
