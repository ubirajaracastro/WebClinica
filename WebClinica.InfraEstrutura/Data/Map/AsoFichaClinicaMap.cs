using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class AsoFichaClinicaMap:EntityTypeConfiguration<ASOFichaClinica>
    {
        public AsoFichaClinicaMap()
        {
            ToTable("TblASOFichaClinica");
            HasKey(x => x.AsoFichaClinicaId);

            Property(x => x.AsoFichaClinicaId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.TipoExameMedicoId)
             .IsRequired();

            Property(x => x.ProfissionalId)
             .IsRequired();

            Property(x => x.PacienteId)
            .IsRequired();

            Property(x => x.PA);
            Property(x => x.Peso);
            Property(x => x.Pulso);
            Property(x => x.Altura);
            Property(x => x.Asma);
            Property(x => x.ObsAsma);
            Property(x => x.Bronquite);
            Property(x => x.ObsBronquite);
            Property(x => x.FumaRegularmente);
            Property(x => x.ObsFumaRegularmente);
            Property(x => x.DoencanoEstomago);
            Property(x => x.ObsDoencanoEstomago);
            Property(x => x.DorCabecaFrequente);
            Property(x => x.ObsDorCabecaFrequente);
            Property(x => x.Epilepsia);
            Property(x => x.ObsEpilepsia);
            Property(x => x.FazExercicioRegularmente);
            Property(x => x.ObsFazExercicioRegularmente);
            Property(x => x.FazUsoBebidaAlcoolica);
            Property(x => x.ObsFazUsoBebidaAlcoolica);
            Property(x => x.FazUsoRegularRemedio);
            Property(x => x.ObsFazUsoRegularRemedio);
            Property(x => x.FoiHospitalizado);
            Property(x => x.ObsFoiHospitalizado);
            Property(x => x.Hepatite);
            Property(x => x.ObsHepatite);
            Property(x => x.Hernia);
            Property(x => x.ObsHernia);
            Property(x => x.PneuMonia);
            Property(x => x.ObsPneuMonia);
            Property(x => x.Varizes);
            Property(x => x.ObsVarizes);
            Property(x => x.VertigensOuDesmaios);
            Property(x => x.ObsVertigensOuDesmaios);
            Property(x => x.Hipertenso);
            Property(x => x.ObsHipertenso);
            Property(x => x.LaudoNR07Id);
            Property(x => x.ACV);
            Property(x => x.AR);
            Property(x => x.SD);
            Property(x => x.SN);
            Property(x => x.SOA);
            Property(x => x.ORL);
            
            HasRequired(x => x.Profissional);
            HasRequired(x => x.Paciente);
        }

    }
}
