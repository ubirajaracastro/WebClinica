using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class AsoMap:EntityTypeConfiguration<ASO>
    {
        public AsoMap()
        {
            ToTable("TblASO");
            HasKey(x => x.ASOId);

            Property(x => x.ASOId)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Empresa)
            .IsRequired();

            Property(x => x.TipoExameMedicoId)
           .IsRequired();

            Property(x => x.PacienteId)
            .IsRequired();

            Property(x => x.ProfissionalId)
           .IsRequired();

            Property(x => x.LaudoNR7);
            Property(x => x.LaudoNR33);
            Property(x => x.LaudoNR35);

            HasRequired(x => x.Profissional);
            HasRequired(x => x.Paciente);


        }
    }
}
