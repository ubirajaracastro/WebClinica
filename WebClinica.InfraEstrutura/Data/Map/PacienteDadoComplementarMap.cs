using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PacienteDadoComplementarMap:EntityTypeConfiguration<PacienteDadosComplementares>
    {
        public PacienteDadoComplementarMap()
        {
            ToTable("TblPacienteDadoComplementar");
            HasKey(x => x.PacienteId);

            Property(x => x.PacienteId)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            
            Property(x => x.CNSSUS);
            Property(x => x.FatorSanguineo);
            Property(x => x.EstadoCivilId);
            Property(x => x.EtniaId);
            Property(x => x.NomePai);
            Property(x => x.NomeMae);
            Property(x => x.NomeConjugue);
            Property(x => x.Responsavel);
            Property(x => x.Indicacao);
            Property(x => x.Hobby);
            Property(x => x.PacienteId);

            Property(x => x.EscolaridadeId)
                .IsOptional();

            Property(x => x.ProfissaoId)
                .IsOptional();

          
        }

    }
}
