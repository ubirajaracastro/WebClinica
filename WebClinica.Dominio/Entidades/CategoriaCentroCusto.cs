﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class CategoriaCentroCusto
    {
        public int CategoriaCentroCustoId { get; set; }
        public string Descricao { get; set; }
        public int CentroCustoId { get; set; }
        public CentroCusto CentroCusto { get; set; }

        public string CNPJ { get; set; }

    }
}
