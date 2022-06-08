using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ASOFichaClinica
    {

        public int AsoFichaClinicaId { get; set; }       
        public int ProfissionalId { get; set; }
        public int TipoExameMedicoId { get; set; }
        public int PacienteId { get; set; }
        public string PA { get; set; }
        public string Peso { get; set; }
        public string Pulso { get; set; }
        public string Altura { get; set; }
        public string Asma { get; set; }
        public string ObsAsma { get; set; }
        public string Bronquite { get; set; }
        public string ObsBronquite { get; set; }
        public string FumaRegularmente { get; set; }
        public string ObsFumaRegularmente { get; set; }

        public string Diabetes { get; set; }
        public string ObsDiabetes{ get; set; }

        public string DoencanoEstomago { get; set; }
        public string ObsDoencanoEstomago { get; set; }

        public string DorCabecaFrequente { get; set; }
        public string ObsDorCabecaFrequente { get; set; }

        public string Epilepsia { get; set; }
        public string ObsEpilepsia { get; set; }

        public string FazExercicioRegularmente { get; set; }
        public string ObsFazExercicioRegularmente { get; set; }

        public string FazUsoBebidaAlcoolica { get; set; }
        public string ObsFazUsoBebidaAlcoolica { get; set; }

        public string FazUsoRegularRemedio { get; set; }
        public string ObsFazUsoRegularRemedio { get; set; }

        public string FoiHospitalizado { get; set; }
        public string ObsFoiHospitalizado { get; set; }

        public string Hepatite { get; set; }
        public string ObsHepatite { get; set; }

        public string Hernia { get; set; }
        public string ObsHernia { get; set; }
        public string PneuMonia { get; set; }
        public string ObsPneuMonia { get; set; }

        public string Sinusite { get; set; }
        public string ObsSinusite { get; set; }

        public string Varizes { get; set; }
        public string ObsVarizes { get; set; }

        public string VertigensOuDesmaios { get; set; }
        public string ObsVertigensOuDesmaios { get; set; }

        public string Hipertenso { get; set; }
        public string ObsHipertenso { get; set; }
        public int LaudoNR07Id { get; set; }

        public string ACV { get; set; }
        public string AR { get; set; }
        public string SD { get; set; }
        public string SN{ get; set; }
        public string SOA { get; set; }
        public string ORL { get; set; }

        public Profissional Profissional { get; set; }
        public Paciente Paciente { get; set; }

    }
}
