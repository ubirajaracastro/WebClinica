using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ConfiguracaoClinicaMap:EntityTypeConfiguration<ConfiguracaoClinica>
    {
        public ConfiguracaoClinicaMap()
        {
            ToTable("TblConfiguracaoClinica");

            Property(x => x.ConfiguracaoClinicaId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasKey(x => x.ConfiguracaoClinicaId);
            Property(x => x.CNPJ)                
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = true }));

            Property(x => x.HabilitarUsoSMS);
            Property(x => x.HabilitarEnvioEmails);
            Property(x => x.TempoMedioAtendimento);
            Property(x => x.HoraInicialAtendimento);
            Property(x => x.HoraFinalAtendimento);
            Property(x => x.HorarioInicialAlmoco);
            Property(x => x.HorarioFinalAlmoco);
            Property(x => x.RestringirAgendamentoscomBaseHorarioAtendimento);
            Property(x => x.EnviarEmaildeAgendamento);
            Property(x => x.EnviarEmailUmDiaAntesConsulta);
            Property(x => x.EnviarSMSdeAgendamento);
            Property(x => x.EnviarSMSUmdiaAntesdaConsulta);
            Property(x => x.EnviarEmailAniversario);
            Property(x => x.FormaPagamentoPadrao);

        }

    }
}
