﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{ 
    public class ExameComplementarPCMSO
    {
        public ExameComplementarPCMSO()
        {
            this.Descricao = "Exames complementares PCMSO";
        }

        public int Id { get; set; }
        public int PacienteId { get; set; }
        public string Descricao { get; set; }
        public bool ExameClinico { get; set; }
        public bool TGOTGP { get; set; } 
        public bool AudiometriaTonal { get; set; }
        public bool AcuidadeVisual { get; set; }
        public bool Oftalmologico { get; set; }
        public bool ECG { get; set; }
        public bool Espirometria { get; set; }
        public bool EEG { get; set; }
        public bool RXColunaLombar { get; set; }
        public bool AvaliacooPsicologica { get; set; }
        public bool RXColunaCervical { get; set; }
        public bool Otoneurológico { get; set; }
        public bool RXColunaDorsal { get; set; }
        public bool Parecerodontológico { get; set; }
        public bool Ureia { get; set; }
        public bool Glicose { get; set; }
        public bool Creatinina { get; set; }
        public bool Reticulocitos { get; set; }
        public bool RXdasMaos { get; set; }
        public bool GamaGT { get; set; }
        public bool VDRL { get; set; }       
        public string Observacao { get; set; }

       }




    
}
