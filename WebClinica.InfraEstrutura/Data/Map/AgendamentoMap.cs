using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class AgendamentoMap:EntityTypeConfiguration<Agendamento>
    {
        public AgendamentoMap()
        {
            ToTable("TblAgendamento");
            HasKey(x => x.AgendamentoId);

            Property(x => x.AgendamentoId)


               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.Data)
            .IsRequired();

            Property(x => x.StatusID);
            Property(x => x.Observacao);
            Property(x => x.EncaminhadoPor);
            Property(x => x.IndicadoPor);
            
            HasRequired(x => x.Profissional);
            HasRequired(x => x.Convenio);
            HasRequired(x => x.Paciente);
            HasRequired(x => x.TipodeConsulta);
            HasMany(x => x.Procedimentos);




        }


    }
}
