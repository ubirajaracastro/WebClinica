using System.Collections;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface ITabelaNormativaUSSService
    {
        IEnumerable obter(string parametro);
    }
}
