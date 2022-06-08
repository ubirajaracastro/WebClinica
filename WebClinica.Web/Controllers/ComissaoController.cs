using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;

namespace WebClinica.Web.Controllers
{
    public class ComissaoController : Controller
    {
        //teste 05/02
        private readonly IComissaoService _servicoComissao;
        private readonly IProfissionalService _servicoProfissional;
        private readonly IConvenioService _servicoConvenio;
        private readonly IProcedimentoService _servicoProc;

        public ComissaoController(IComissaoService servicoComissao, IProfissionalService servicoProfissional,
            IConvenioService servicoConvenio, IProcedimentoService servicoProc)
        {
            _servicoComissao = servicoComissao;
            _servicoProfissional = servicoProfissional;
            _servicoConvenio = servicoConvenio;
            _servicoProc = servicoProc;

        }
        // GET: Comissao
        public ActionResult Index()
        {
         
            return View();
        }

        public ActionResult Novo()
        {
            CarregaCombosTela();
            ComissaoViewModel comissao = new ComissaoViewModel();
            return View(comissao);
        }
        private void CarregaCombosTela(){
            
            var listaConvenios = _servicoConvenio.Obter();       
            ViewBag.Convenios = new SelectList(listaConvenios, "ConvenioID", "NomeConvenio");
                      
        }

        public JsonResult obterProcedimentoPorConvenio(int ConvenioID)
        {
            var listaProcedimentos = _servicoProc.obterProcedimentosPorConvenios(ConvenioID);
            
            return Json(listaProcedimentos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult obterProfissionalPorConvenio(int ConvenioID)
        {
            var listaProfissional = _servicoProc.obterProfissionalPorConvenios(ConvenioID);
            return Json(listaProfissional, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Salvar(string Items)
        {
            string msg = string.Empty;
            
            var lista = JsonConvert.DeserializeObject<ItensComissao>(Items);

            foreach (var item in lista.ItemComissaoViewModel)
            {
                var itemExistente = _servicoComissao.obterComissao(item.ConvenioId, item.ProcedimentoId, item.ProfissionalId);

                if (itemExistente!=null && itemExistente.ComissaoId > 0)
                {
                    msg = "Comissão já cadastrada para esse Convênio/Procedimento/Profissional.";
                }
                else
                {
                    EntidadeComissao comissao = new EntidadeComissao();
                    comissao.Ativo = true;
                    comissao.CNPJClinica = "45543915003954";

                    Convenio conv = _servicoConvenio.ObterPorId(item.ConvenioId);
                    comissao.Convenio = conv;

                    comissao.DescricaoComissao = item.Descricao;
                    Procedimento procedimento = _servicoProc.obterPorId(item.ProcedimentoId);
                    comissao.Procedimento = procedimento;
                                       
                    Profissional prof = _servicoProfissional.obterPorId(item.ProfissionalId);
                    comissao.Profissional = prof;
                    comissao.ValorComissao = item.ValorComissao;

                    _servicoComissao.Salvar(comissao);
                    msg = "OK";
                }
                                
            }
            var resultado = new
            {
                Msg = msg
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        
      
         public JsonResult Listar(string searchPhrase)
            {
               var listaComissao = _servicoComissao.obterComissao();            
                var lista = listaComissao.AsQueryable();

                //generos.ForEach(g => contexto.Generos.Add(g));           

                if (!String.IsNullOrWhiteSpace(searchPhrase)){
              
                    lista = lista.Where("DescricaoComissao.Contains(@0)", searchPhrase);
                }

                int total = lista.Count();

                return Json(new
                {
                    current = 1,
                    rowCount = total,
                    rows = lista,
                    total = total,
                }, JsonRequestBehavior.AllowGet);
            }
    }
}