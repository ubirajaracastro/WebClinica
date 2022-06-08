using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using AutoMapper;
using WebClinica.Comum.Enum;

namespace WebClinica.Web.Controllers
{
    public class ProfissionalController : BaseController
    {
        private readonly IProfissionalService _servico;
        private readonly IEstadoService _servicoUf;
        private readonly IEspecialidadeService _serviceEspecialidade;
        private readonly ICidadeService _serviceCidade;
        private readonly IConselhoProfissionalService _conselho;

        public ProfissionalController(IProfissionalService servico, IEstadoService servicoUf,
            IEspecialidadeService serviceEspecialidade, ICidadeService serviceCidade,
            IConselhoProfissionalService conselho)
        {
            _servico = servico;
            _servicoUf = servicoUf;
            _serviceEspecialidade = serviceEspecialidade;
            _serviceCidade = serviceCidade;
            _conselho = conselho;
        }


        public ActionResult Index()
        {
            return View();
        }


        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<Profissional> listaProfissionalModel = _servico.listarProfissional();
            var lista = listaProfissionalModel.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("Nome.Contains(@0)", searchPhrase);
            }



            int totalProfissionais = lista.Count();

            return Json(new
            {
                current = 1,
                rowCount = listaProfissionalModel.Count(),
                rows = lista,
                total = listaProfissionalModel.Count(),
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult obterCidadePorEstado(int estadoID)
        {
            var listaCidade = _serviceCidade.obterCidadesPorEstado(estadoID);
            return Json(listaCidade, JsonRequestBehavior.AllowGet);
        }


        private void carregaCombosTela()
        {
            int codPais = int.Parse(ConfigurationManager.AppSettings["codigoPaisPadrao"].ToString());

            var listaProfissao = _serviceEspecialidade.obter();
            var listaUf = _servicoUf.obterEstados(codPais);
            var listaConselho = _conselho.obter();

            ViewBag.listaProfissao = new SelectList(listaProfissao, "CodTermo", "Termo");
            ViewBag.UF = new SelectList(listaUf, "EstadoId", "Nome");
            ViewBag.Conselho = new SelectList(listaConselho, "codTermo", "Termo");


        }
        public ActionResult Novo()
        {
            carregaCombosTela();
            ProfissionalViewModel novoProfissional = new ProfissionalViewModel();
            return View(novoProfissional);
        }

        // GET: Profissional/Create
        public JsonResult Salvar(ProfissionalViewModel model)
        {
            string msg = string.Empty;
                     
            if (ModelState.IsValid)
            {
                Mapper.Initialize(config =>
                {
                    config.CreateMap<ProfissionalViewModel, Profissional>();
                });

                model.CidadeId = int.Parse(Request.Form["Cidade"]);
                model.CNPJClinica = CNPJClinica;
                Profissional profissionalModel = Mapper.Map<ProfissionalViewModel, Profissional>(model);
                _servico.salvar(profissionalModel);

                var resultado = new
                {
                    msg = "Profissional cadastrado com sucesso."
                };

                return Json(resultado, JsonRequestBehavior.AllowGet);
            }

            else
            {
                var resultado = new
                {
                    msg = "Ocorreu um erro no preenchimento do cadastro. Verifique os campos obrigatórios."
                };

                return Json(resultado, JsonRequestBehavior.AllowGet);
            }            

        }

        public ActionResult AlteraProfissional(int id)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Profissional, ProfissionalViewModel>();
            });

            carregaCombosTela();
            Profissional profissional = _servico.obterPorId(id);

            if (profissional.ProfissionalId > 0)
            {
                var nomeCidadeAtual = _serviceCidade.obterCidade(profissional.CidadeId);
                ViewBag.CidadeAtual = nomeCidadeAtual.Nome;
                ViewBag.CodigoCidadeAtual = nomeCidadeAtual.Id;

            }

            ProfissionalViewModel model = Mapper.Map<Profissional, ProfissionalViewModel>(profissional);

            return View("Novo", "", model);



        }

        // POST: Profissional/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
