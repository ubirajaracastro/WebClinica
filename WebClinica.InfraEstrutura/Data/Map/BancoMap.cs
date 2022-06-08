using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class BancoMap:EntityTypeConfiguration<Banco>
    {
        public BancoMap()
        {
            ToTable("TblBanco");
            HasKey(x => x.BancoId);

            Property(x => x.BancoId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Nome)
             .IsRequired();

            Property(x => x.Numero)
            .IsRequired();

            Property(x => x.CNPJClinica)
           .IsRequired()
            .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));
        }
    }
}
