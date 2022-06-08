using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class StatusAgendamentoMap:EntityTypeConfiguration<StatusAgendamento>
    {
        public StatusAgendamentoMap()
        {
            ToTable("TblStatusAgendamento");
            HasKey(x => x.StatusAgendamentoId);

            Property(x => x.Descricao);
            Property(x => x.Ativo);
        }
    }
}
