using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using System.Linq.Dynamic;
using WebClinica.Web.Models;
using AutoMapper;
using WebClinica.Comum.Validacao;

namespace WebClinica.Web.Controllers
{
    public class ModeloAnamneseController : Controller
    {
        #region membros
        private readonly IModeloAnamneseService _servico;
        private readonly IPerguntaAnamneseService _servicoPergunta;
        #endregion

        #region construtor
        public ModeloAnamneseController(IModeloAnamneseService servico, IPerguntaAnamneseService servicoPergunta)
        {
            _servico = servico;
            _servicoPergunta = servicoPergunta;
        }

        #endregion

        #region actions
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Salvar(ModeloAnamneseViewModel model)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ModeloAnamneseViewModel, ModeloAnamnese>();

            });

            if (ModelState.IsValid)
            {
                ModeloAnamnese modelo = new ModeloAnamnese();
                modelo.Nome = model.Nome;
                modelo.CNPJClinica = "45543915003954";
                modelo.PadraodaClinica = model.PadraodaClinica;
                modelo.ModeloId = model.ModeloId;

                List<PerguntasAnamnese> listaPerguntas = new List<PerguntasAnamnese>();

                foreach (PerguntasAnamneseViewModel item in model.Perguntas)
                {
                    if (item.Marcado)
                    {
                        PerguntasAnamnese pergunta = new PerguntasAnamnese();
                        pergunta.PerguntaId = item.PerguntaId.Value;
                        pergunta.Descricao = item.Descricao;
                        pergunta.TipoPergunta = 5;
                        listaPerguntas.Add(pergunta);

                    }
                }

                _servico.Salvar(modelo, listaPerguntas);

            }


            return PartialView("~/Views/Shared/_Modal.cshtml");
        }

        public ActionResult Alterar(int id)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ModeloAnamnese, ModeloAnamneseViewModel>();
                config.CreateMap<PerguntasAnamnese, PerguntasAnamneseViewModel>();
            });

            ModeloAnamnese modeloAnamnese = _servico.obterPorId(id);
            IEnumerable<PerguntasAnamnese> listaPerguntas = _servicoPergunta.obter();

            //mapping de colecoes
            IEnumerable<PerguntasAnamneseViewModel> listaPerguntasView =
              Mapper.Map<IEnumerable<PerguntasAnamnese>,
              IEnumerable<PerguntasAnamneseViewModel>>(listaPerguntas);

            ModeloAnamneseViewModel view = Mapper.Map<ModeloAnamnese, ModeloAnamneseViewModel>(modeloAnamnese);
            view.Perguntas = listaPerguntasView;
            view.ModeloId = modeloAnamnese.ModeloId;

            IEnumerable<ModeloPergunta> PerguntasdoModelo = _servico.obterPerguntasModelo(id);

            foreach (var item in view.Perguntas)
            {
                foreach (var itemModelo in PerguntasdoModelo)
                {
                    if (item.PerguntaId == itemModelo.PerguntaCodigo)
                        item.Marcado = true;

                }
            }

            return View("Novo", view);

        }


        public ActionResult Novo()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ModeloAnamnese, ModeloAnamneseViewModel>();
                config.CreateMap<PerguntasAnamnese, PerguntasAnamneseViewModel>();
            });

            ModeloAnamnese modeloAnamnese = new ModeloAnamnese();

            IEnumerable<PerguntasAnamnese> listaPerguntas =
                _servicoPergunta.obter();

            ////mapping de colecoes
            IEnumerable<PerguntasAnamneseViewModel> listaPerguntasView =
              Mapper.Map<IEnumerable<PerguntasAnamnese>,
              IEnumerable<PerguntasAnamneseViewModel>>(listaPerguntas);

            ModeloAnamneseViewModel view = Mapper.Map<ModeloAnamnese, ModeloAnamneseViewModel>(modeloAnamnese);
            view.Perguntas = listaPerguntasView;

            return View(view);

        }


        public JsonResult Excluir(int modeloID)
        {
            _servico.ExcluirModeloAnamnese(modeloID);
            var resultado = new
            {
                OK = true
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
        public JsonResult TemModeloPadrao()
        {
            var count = _servico.obterModeloPadrao();

            var resultado = new
            {
                count = count
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        public JsonResult ListarPerguntas(string searchPhrase)
        {
            var listaPerguntas = _servicoPergunta.obter();
            var lista = listaPerguntas.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {

                lista = lista.Where("Descricao.Contains(@0)", searchPhrase);
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
        public JsonResult Listar(string searchPhrase)
        {
            var listaModelo = _servico.obter();
            var lista = listaModelo.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {

                lista = lista.Where("Nome.Contains(@0)", searchPhrase);
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

        private void CarregarCombosTela()
        {

            List<TipodePergunta> tiposPergunta = new List<TipodePergunta>();
            tiposPergunta.Add(new TipodePergunta { codTipo = 1, Descricao = "DATA" });
            tiposPergunta.Add(new TipodePergunta { codTipo = 2, Descricao = "DESCRITIVACURTA" });
            tiposPergunta.Add(new TipodePergunta { codTipo = 3, Descricao = "DESCRITIVALONGA" });
            tiposPergunta.Add(new TipodePergunta { codTipo = 4, Descricao = "MULTIPLAESCOLHA" });
            tiposPergunta.Add(new TipodePergunta { codTipo = 5, Descricao = "OBJETIVA" });
            tiposPergunta.Add(new TipodePergunta { codTipo = 6, Descricao = "NUMÉRICA" });

            ViewBag.TipoPergunta = new SelectList(tiposPergunta, "codTipo", "Descricao");


        }
        #endregion
    }
}