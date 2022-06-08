﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Contratos.Repositorios
{
    public interface IDatabaseTransaction:IDisposable
    {
        void Commit();
        void Rollback();


    }
}
