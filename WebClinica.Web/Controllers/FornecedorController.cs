using AutoMapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;

namespace WebClinica.Web.Controllers
{
    public class FornecedorController : Controller
    {
        #region Membros
        private readonly IEstadoService _servicoUf;
        private readonly IFornecedorService _servicoFornecedor;
        private readonly ICidadeService _serviceCidade;
        const string CNPJ = "45543915003954";
        #endregion

        #region Construtor
        public FornecedorController(IEstadoService servicoUf,IFornecedorService servicoFornecedor,
            ICidadeService serviceCIdade)
        {
            _servicoUf = servicoUf;
            _servicoFornecedor = servicoFornecedor;
            _serviceCidade = serviceCIdade;
        }
        #endregion

        #region actions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            carregaCombosTela();
            FornecedorViewModel fornecedor = new FornecedorViewModel();
            fornecedor.Ativo = true;
            return View(fornecedor);
        }

        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<FornecedorClinica> listaFornecedor = _servicoFornecedor.obter();
            var lista = listaFornecedor.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("RazaoSocial.Contains(@0)", searchPhrase);
            }
            
            int total = lista.Count();

            return Json(new
            {
                current = 1,
                rowCount = listaFornecedor.Count(),
                rows = lista,
                total = total,
            }, JsonRequestBehavior.AllowGet);
        }

        private void carregaCombosTela()
        {
            int codPais = int.Parse(ConfigurationManager.AppSettings["codigoPaisPadrao"].ToString());

            var listaUf = _servicoUf.obterEstados(codPais);       
            ViewBag.UF = new SelectList(listaUf, "EstadoId", "Nome");
                      
        }
        public ActionResult Salvar(FornecedorViewModel model)
        {
            if (ModelState.IsValid)
            {
                Mapper.Initialize(config =>
                {
                    config.CreateMap<FornecedorViewModel, FornecedorClinica>();
                });

                model.CidadeId = int.Parse(Request.Form["Cidade"]);
                model.CNPJClinica = CNPJ;
                
                FornecedorClinica fornecedorDominio = Mapper.Map<FornecedorViewModel, FornecedorClinica>(model);              
                _servicoFornecedor.Salvar(fornecedorDominio);
                                
                return PartialView("~/Views/Shared/_Modal.cshtml");
            }

            else{

                return View();
            }
        }


        public ActionResult Alterar(int ID)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<FornecedorClinica, FornecedorViewModel>();
            });

            carregaCombosTela();
            FornecedorClinica fornecedor = _servicoFornecedor.obterPorId(ID);

            if(fornecedor!=null)
            {
                var nomeCidadeAtual = _serviceCidade.obterCidade(fornecedor.CidadeId);
                ViewBag.CidadeAtual = nomeCidadeAtual.Nome;
                ViewBag.CodigoCidadeAtual = nomeCidadeAtual.Id;

            }

            FornecedorViewModel model = Mapper.Map<FornecedorClinica, FornecedorViewModel>(fornecedor);
            return View("Novo", model);

        }

        public JsonResult Excluir(int ID)
        {
            _servicoFornecedor.Excluir(ID);
            var resultado = new
            {
                OK = true
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
        #endregion
    }
}