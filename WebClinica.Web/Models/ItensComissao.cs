using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ItensComissao
    {
        public List<ItemComissaoViewModel> ItemComissaoViewModel { get; set; }
        public int count { get; set; }
    }
}