using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class TabelaCBHPMService : ITabelaCBHPMService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<TabelaCBHPM> _repositorio;

        public TabelaCBHPMService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.TabelaCBHPMRepositorio;
        }
        public IEnumerable obter(string parametro)
        {
            IEnumerable listaProcedimentos = null;
            try
            {
                listaProcedimentos = from p in
                                    _repositorio.TWhere(c => c.Procedimento.Contains(parametro))

                                        select new
                                        {
                                            p.Codigo,
                                            p.Procedimento,
                                            p.ValorUCO
                                        };

           }

            catch (Exception err)
            {

            }

            return listaProcedimentos;

        }
    }
}
