using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class EscalaAtendimentoProfissionalDiaSemanaMap:EntityTypeConfiguration<EscalaAtendimentoProfissionalDiaSemana>
    {
        public EscalaAtendimentoProfissionalDiaSemanaMap()
        {
            ToTable("TblEscalaAtendimentoProfissionalDiadaSemana");
            HasKey(x => x.DiaId);

            Property(x => x.DiaId)           
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            

            Property(x => x.DescricaoDia)
            .IsRequired();
        }
    }
}
