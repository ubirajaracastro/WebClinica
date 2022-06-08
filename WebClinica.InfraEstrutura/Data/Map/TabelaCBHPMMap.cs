using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TabelaCBHPMMap: EntityTypeConfiguration<TabelaCBHPM>
    {
        public TabelaCBHPMMap()
        {
            ToTable("TblTabelaCBHPM");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Procedimento)
                .IsOptional();

            Property(x => x.Porte)
                .IsOptional();

            Property(x => x.ValorPorte)
                .IsOptional();

            Property(x => x.Auxiliares)
                .IsOptional();

            Property(x => x.ValorUCO)
                .IsOptional();

            Property(x => x.PorteAnestesico)
                .IsOptional();

            Property(x => x.QtdeFilme)
                .IsOptional();

            Property(x => x.Incidencia)
                .IsOptional();

            Property(x => x.ValorTotal)
                .IsOptional();

        }

    }
}
