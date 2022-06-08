using System;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IConfiguracaoClinicaService
    {
        ConfiguracaoClinica obterConfiguracao();
        void SalvarConfiguracao(ConfiguracaoClinica entidade);


    }
}
