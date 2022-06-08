using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IClinicaService:IDisposable

    {
        void salvarClinica(Clinica clinica);
        Clinica obterClinica();

    }
}
