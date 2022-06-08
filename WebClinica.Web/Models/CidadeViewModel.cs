using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebClinica.Web.Models
{
    public class CidadeViewModel {
        public int Id { get; set; }
        public int CidadeId { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }
    }
}
