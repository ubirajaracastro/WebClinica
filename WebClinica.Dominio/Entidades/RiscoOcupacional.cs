using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class RiscoOcupacional
    {
        public int Id { get; set; } 
        public string Tipo { get; set; }
        public bool Ruido { get; set; }
        public bool Calor { get; set; }
        public bool RadiacaoNaoIonizante { get; set; }
        public bool Poeira { get; set; }
        public bool Nevoas { get; set; }
        public bool Fumo { get; set; }
        public bool Infeccoes { get; set; }
        public bool Gripe { get; set; }
        public bool Fungos { get; set; }
        public bool Bacilos { get; set; }
        public bool Virus { get; set; }
        public bool Bacterias { get; set; }
        public bool Postural { get; set; }
        public bool MovimentacaoContinua { get; set; }
        public bool LevtoTranspManualdePeso { get; set; }
        public bool TrabalhoNoturno { get; set; }
        public bool AcidentePostural { get; set; }
        public bool QuedadeMaterial { get; set; }
        public bool ManuseioPerfuroCortantes { get; set; }
        public bool AtaqueAnimaisPeconhentos { get; set; }
        public bool EsmagamentoLuxacao { get; set; }
        public bool EquipFerramentaUsoManual { get; set; }
        public bool Outros { get; set; }
        public int PacienteId { get; set; }

    }
}
