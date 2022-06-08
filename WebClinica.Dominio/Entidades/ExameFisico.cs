using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ExameFisico
    {       
        public int ExameId { get; set; }
        public decimal Peso { get; set; }
        public decimal FrequenciaRespiratoria { get; set; }
        public decimal Altura { get; set; }
        public decimal FrequenciaCardiaca { get; set; }
        public decimal PressãoArterialsistotica { get; set; }
        public decimal Temperatura { get; set; }
        public decimal PressãoArterialdiastolica { get; set; }
        public decimal Hemoglucoteste { get; set; }
        public string CNPJClinica { get; set; }      


    }
}
