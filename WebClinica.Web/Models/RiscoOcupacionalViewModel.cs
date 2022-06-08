using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class RiscoOcupacionalViewModel
    {
        [Display(Name = "Ruído")]
        public bool Ruido { get; set; }
        public bool Calor { get; set; }

        [Display(Name = "Radiação Não Ionizante")]
        public bool RadiacaoNaoIonizante { get; set; }
        public bool Poeiras { get; set; }

        [Display(Name = "Nevoas")]
        public bool Nevoas { get; set; }
        public bool Fumo { get; set; }

        [Display(Name = "Infecções")]
        public bool Infeccoes { get; set; }
        public bool Gripe { get; set; }
        public bool Fungos { get; set; }
        public bool Bacilos { get; set; }

        [Display(Name = "Vírus")]
        public bool Virus { get; set; }

        [Display(Name = "Bactérias")]
        public bool Bacterias { get; set; }
        public bool Postural { get; set; }

        [Display(Name = "Movimentação Contínua")]
        public bool MovimentacaoContinua { get; set; }

        [Display(Name = "Levantamento e Transp Manual de Peso")]
        public bool LevtoTranspManualdePeso { get; set; }
        public bool TrabalhoNoturno { get; set; }
        public bool AcidentePostural { get; set; }
        public bool QuedadeMaterial { get; set; }

        [Display(Name = "Manuseio de Peças PerfuroCortantes")]
        public bool ManuseioPerfuroCortantes { get; set; }

        [Display(Name = "Ataque de Animais Peçonhentos")]
        public bool AtaqueAnimaisPeconhentos { get; set; }

        [Display(Name = "Esmagamento/Luxações")]
        public bool EsmagamentoLuxacao { get; set; }

        [Display(Name = "Equip. e Ferramenta de uso manual")]
        public bool EquipFerramentaUsoManual { get; set; }

        public bool Outros { get; set; }

    }
}