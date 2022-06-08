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
    public class FaturaMap:EntityTypeConfiguration<Fatura>
    {
        public FaturaMap()
        {
            ToTable("TblFatura");
            HasKey(x => x.FaturaId);

            Property(x => x.FaturaId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Data);
            Property(x => x.ValorPaciente);
            Property(x => x.ValorConvenio);
            Property(x => x.StatusId);

            Property(x => x.CNPJClinica)
                .IsRequired()
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


            HasMany(x => x.Procedimentos);
            HasRequired(x => x.Paciente);
            HasRequired(x => x.Profissional);

        }

    }
}
