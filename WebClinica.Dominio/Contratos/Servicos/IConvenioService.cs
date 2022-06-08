using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IConvenioService
    {
        int Salvar(Convenio convenio,List<ConvenioProfissional> listaProfissionais);
        IEnumerable<Convenio> Obter();
        IEnumerable<ConvenioPlano> ObterPlanos(int id);
        void Excluir(Convenio convenio);
        void ExcluirPlano(int id);
        int SalvarPlano(ConvenioPlano plano);
        Convenio ObterPorId(int id);
               
    }
}
