using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TipodeConsultaMap: EntityTypeConfiguration<TipodeConsulta>
    {

        public TipodeConsultaMap()
        {
            ToTable("TblTipodeConsulta");
            this.HasKey(x => x.TipoConsultaId);

            Property(x => x.TipoConsultaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           

            Property(x => x.Descricao)                
             .IsRequired();

            Property(x => x.CNPJClinica)
                .IsRequired()
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Ativo);
            Property(x => x.Faturar);
            
        }
    }
}
