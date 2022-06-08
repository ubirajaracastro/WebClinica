using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using System.Linq;
using System.Collections;

namespace WebClinica.Negocio
{
    public class TabelaNormativaUSSService : ITabelaNormativaUSSService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<TabelaNormativaUSS> _repositorio;
        private readonly IRepositoryBase<TabelaCBHPM> _repositorioCBHPM;


        public TabelaNormativaUSSService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = unitOfWork.TabelaNormativaUSSRepositorio;
            _repositorioCBHPM = _unitOfWork.TabelaCBHPMRepositorio;
        }

        //essa consulta já traz procedimentos relacionados com a tabela cbhpm 5 edicao
        public IEnumerable obter(string parametro)
        {
            var listaProcedimentos = from tuss in _repositorio.GetAll()
                                     join cbhm in _repositorioCBHPM.GetAll()
                                     on tuss.CodigoTUSS equals cbhm.Codigo
                                     where cbhm.Procedimento.Contains(parametro)
                                     orderby cbhm.Procedimento

                                     select new
                                     {
                                         cbhm.Codigo,
                                         cbhm.Procedimento
                                     };

            return listaProcedimentos;           

        }
    }
}
