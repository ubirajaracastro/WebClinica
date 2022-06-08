using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using Newtonsoft.Json;
using System.Collections;
using System.Linq;
using System.Linq.Dynamic;
using AutoMapper;

namespace WebClinica.Web.Controllers
{
    public class TabelaDerivadaController : Controller
    {
        #region membros
        private readonly ITabelaDerivadaCobrancaProcedimentoService _servico;
        private readonly ITabelaCBHPMService _servicoCBHPM;
        #endregion

        #region constutores
        public TabelaDerivadaController(ITabelaDerivadaCobrancaProcedimentoService servico,
            ITabelaCBHPMService servicoCBHPM)
        {
            _servico = servico;
            _servicoCBHPM = servicoCBHPM;
        }
        #endregion

        #region actions
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult removerItem(int id)
        {
            _servico.RemoverItem(id);

            var resultado = new
            {
                Msg = "Item de procedimento excluído com sucesso."
            };

           return Json(resultado, JsonRequestBehavior.AllowGet);
    }

    public JsonResult obterItensTabelaProcedimento(int id)
    {
        var listaTabelas = _servico.obterItens(id);
        return Json(listaTabelas, JsonRequestBehavior.AllowGet);
    }

    public ActionResult Alterar(int id)
    {
        TabelaDerivadaCobrancaProcedimento tabela = _servico.obterTabela(id);

        Mapper.Initialize(config =>
        {
            config.CreateMap<TabelaDerivadaCobrancaProcedimento, TabelaDerivadaCobrancaProcedimentoViewModel>();
        });

        var model =
            Mapper.Map<TabelaDerivadaCobrancaProcedimento, TabelaDerivadaCobrancaProcedimentoViewModel>(tabela);

        return View("Novo", model);
    }

    public ActionResult Novo()
    {
        TabelaDerivadaCobrancaProcedimentoViewModel model =
            new TabelaDerivadaCobrancaProcedimentoViewModel();

        return View(model);
    }


    public JsonResult obterProcedimentosCBHPM(string parametro)
    {
        var listaProcedimentos = _servicoCBHPM.obter(parametro);
        return Json(listaProcedimentos, JsonRequestBehavior.AllowGet);
    }

    public JsonResult Listar(string searchPhrase)
    {
        IEnumerable listaTabelas = _servico.obter();

        var lista = listaTabelas.AsQueryable();
        int total = lista.Count();

        if (!String.IsNullOrWhiteSpace(searchPhrase))
        {
            lista = lista.Where("NomeTabela.Contains(@0)", searchPhrase);
        }

        return Json(new
        {
            current = 1,
            rowCount = lista.Count(),
            rows = lista,
            total = lista.Count(),
        }, JsonRequestBehavior.AllowGet);
    }


    public JsonResult Salvar(string Items)
    {
        string msg = string.Empty;

        var lista = JsonConvert.DeserializeObject<ItensTabela>(Items);

        TabelaDerivadaCobrancaProcedimento tabela = new TabelaDerivadaCobrancaProcedimento();
        tabela.DtCadastro = DateTime.Now;
        tabela.NomeTabela = lista.ItemTabelaViewModel[0].Tabela;
        tabela.TabelaBaseID = 1;

        List<TabelaDerivadaCobrancaProcedimentoItem> listaTabelaItens = new List<TabelaDerivadaCobrancaProcedimentoItem>();

        foreach (var item in lista.ItemTabelaViewModel)
        {

            TabelaDerivadaCobrancaProcedimentoItem tabelaItem = new TabelaDerivadaCobrancaProcedimentoItem();
            tabelaItem.CodigoProcedimento = item.Procedimento;
            tabelaItem.NovoValor = item.NovoValor;
            tabelaItem.ValorUCO = item.ValorUCO;

            listaTabelaItens.Add(tabelaItem);

        }

        msg = _servico.Salvar(tabela, listaTabelaItens);

        var resultado = new
        {
            Msg = msg
        };

        return Json(resultado, JsonRequestBehavior.AllowGet);
    }
    #endregion
}
}