using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    //classe só foi criada para nao ter que utilizar a ProfessionalViewModel por ter as suas
    //validações próprias e nao invalidar o fluxo do Controller Convenio
    public class ConvenioProfissionalQueAtendeViewModel
    {
        public int ProfissionalId { get; set; }
        public int ConvenioId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}