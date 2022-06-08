using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.ObjetoCompostos;

namespace WebClinica.Negocio
{
    public class ComissaoService : IComissaoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<EntidadeComissao> _repositorio;

        public ComissaoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.ComissaoRepositorio;

        }
        public List<ComissaoEntidade> obterComissao()    
        {
            var lista =
                _repositorio.GetAllRelation("Convenio", "Procedimento", "Profissional", c => c.Ativo == true);
            List<ComissaoEntidade> listaComissao = new List<ComissaoEntidade>();

            foreach (var item in lista)
            {
                ComissaoEntidade c = new ComissaoEntidade();
                c.ComissaoId = item.ComissaoId;
                c.Descricao = item.DescricaoComissao;
                c.NomeConvenio = item.Convenio.NomeConvenio;
                c.NomeProcedimento = item.Procedimento.Nome;
                c.NomeProfissional = item.Profissional.Nome;
                c.ValorComissao = item.ValorComissao;

                listaComissao.Add(c);
            }


            return listaComissao;            
        }               

        public void Salvar(EntidadeComissao comissao)
        {
            var registro = _repositorio.GetById(comissao.ComissaoId);

            if (registro == null)
                _repositorio.Add(comissao);
            else
                _repositorio.Update(registro, comissao);


            _unitOfWork.Save();

        }

        public EntidadeComissao obterComissao(int ConvenioId, int ProcedimentoId, int ProfissionalID)
        {
            return _repositorio.GetAll().Where(c => c.ConvenioId == ConvenioId && c.ProcedimentoId == ProcedimentoId &&
            c.ProfissionalId == ProfissionalID).FirstOrDefault();
        }
    }
}
