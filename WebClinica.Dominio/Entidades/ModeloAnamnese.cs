using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class ModeloAnamnese
    {
        public ModeloAnamnese()
        {
           
        }
        public int ModeloId { get; set; }
        public string Nome { get; set; }
        public bool PadraodaClinica { get; set; }
        public string CNPJClinica { get; set; }
        public bool Ativo { get; set; }




    }
}
