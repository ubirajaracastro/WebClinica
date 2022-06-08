using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClinica.Web.Models
{
    public class ItensTabela
    {
        public List<ItemTabelaViewModel> ItemTabelaViewModel { get; set; }
        public int count { get; set; }
    }
}