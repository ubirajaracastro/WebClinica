using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class AtendimentoMap:EntityTypeConfiguration<Atendimento>
    {
        public AtendimentoMap()
        {
            ToTable("TblAtendimento");
            HasKey(x => x.AtendimentoId);

            Property(x => x.AtendimentoId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                      
            Property(x => x.Data)
            .IsRequired();
           
            Property(x => x.QueixaPrincipal)
                 .IsRequired();

            Property(x => x.Conduta)
             .IsRequired();

            Property(x => x.PrescricaoMedica)
                .IsOptional();             
                                                
            Property(x => x.CID);
            Property(x => x.DescricaoCID);

            Property(x => x.ModeloAnamneseID)
                .IsOptional();

            Property(x => x.CNPJClinica)
           .IsRequired()
            .HasColumnAnnotation(
                   IndexAnnotation.AnnotationName,
                   new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

                           
            HasRequired(x => x.Paciente);         
            HasMany(x => x.Procedimentos);
            HasMany(x => x.ProcedimentosProntuario);
            HasOptional(x => x.ExameFisico);
            HasOptional(x => x.Atestado);



        }

    }
}
