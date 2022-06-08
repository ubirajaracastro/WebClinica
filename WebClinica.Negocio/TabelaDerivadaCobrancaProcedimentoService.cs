using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Negocio
{
    public class TabelaDerivadaCobrancaProcedimentoService : ITabelaDerivadaCobrancaProcedimentoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<TabelaDerivadaCobrancaProcedimento> _repositorio;
        private readonly IRepositoryBase<TabelaDerivadaCobrancaProcedimentoItem> _repositorioItem;
        private readonly IRepositoryBase<DescritivoTabelasPlano> _repositorioDescritivoTabela;

        public TabelaDerivadaCobrancaProcedimentoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.TabelaDerivadaProcedimentoRepositorio;
            _repositorioItem = _unitOfWork.TabelaDerivadaProcedimentoItemRepositorio;
            _repositorioDescritivoTabela = _unitOfWork.TabelasProcedimentoRepositorio;
        }
        public IEnumerable obter()
        {
            IEnumerable<TabelaDerivadaCobrancaProcedimento>listaTabelas =  _repositorio.GetAll();

            var lista = from p in listaTabelas
                        select new {p.TabelaDerivadaCobrancaProcedimentoID, p.NomeTabela };                                   


            return listaTabelas;
        }

        public string Salvar(TabelaDerivadaCobrancaProcedimento tabela,
            List<TabelaDerivadaCobrancaProcedimentoItem> listaItens)
        {
            string result = string.Empty;
            bool tabelaExiste = false;
            try
            {
                var registro = _repositorio.TWhere(nm => nm.NomeTabela == tabela.NomeTabela).FirstOrDefault();
                if (registro == null)
                {
                    _repositorio.Add(tabela);
                    _unitOfWork.Save();
                }
                else
                    tabelaExiste = true;
                
                foreach (TabelaDerivadaCobrancaProcedimentoItem item in listaItens)
                {
                    if (!tabelaExiste)
                        item.Tabela = tabela;
                    else
                        item.Tabela = registro;

                    var itemExiste = _repositorioItem.TWhere(c => c.CodigoProcedimento == 
                    item.CodigoProcedimento &&
                    c.Tabela.TabelaDerivadaCobrancaProcedimentoID == tabela.TabelaDerivadaCobrancaProcedimentoID).FirstOrDefault();

                    if(itemExiste==null)
                       _repositorioItem.Add(item);
                }

                if (!tabelaExiste)
                {
                    DescritivoTabelasPlano tabelaProcedimento = new DescritivoTabelasPlano();
                    tabelaProcedimento.Descricao = tabela.NomeTabela;
                    _repositorioDescritivoTabela.Add(tabelaProcedimento);
                }

                _unitOfWork.Save();


                result = "Tabela cadastrada com sucesso.";
            }

            catch (Exception erro)
            {

            }

            return result;

        }

        public IEnumerable<TabelaDerivadaCobrancaProcedimentoItem> obterItens(int tabelaID)
        {
           IEnumerable<TabelaDerivadaCobrancaProcedimentoItem> listaTabelas=
                _repositorioItem.TWhere(t => t.Tabela.TabelaDerivadaCobrancaProcedimentoID == tabelaID);                                  
            
            return listaTabelas;
            
        }

        public TabelaDerivadaCobrancaProcedimento obterTabela(int tabelaID)
        {
            return _repositorio.GetById(tabelaID);
        }

        public void RemoverItem(int id)
        {
            var TabelaItem = _repositorioItem.GetById(id);

            if(TabelaItem!=null)
            {
                _repositorioItem.Remove(TabelaItem);
                _unitOfWork.Save();
            }
        }
    }
}
