using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClinica.Web.Models;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using AutoMapper;
using WebClinica.Comum.Enum;
using WebClinica.Comum.Validacao;
using Newtonsoft.Json;

namespace WebClinica.Web.Controllers
{
    public class PerguntaController : Controller
    {
        private readonly IPerguntaAnamneseService _servico;
        private readonly IModeloAnamneseService _servicoModelo;
        private readonly IPerguntaAnamneseService _servicoPergunta;

        public PerguntaController(IPerguntaAnamneseService servico, IModeloAnamneseService servicoModelo,
            IPerguntaAnamneseService servicoPergunta)
        {
            _servico = servico;
            _servicoModelo = servicoModelo;
            _servicoPergunta = servicoPergunta;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ModeloAnamnese, ModeloAnamneseViewModel>();
            });

            CarregarCombosTela();
            var listaModelos = _servicoModelo.obter();

            List<ModeloAnamneseViewModel> ListaModeloView =
                  Mapper.Map<List<ModeloAnamnese>, List<ModeloAnamneseViewModel>>(listaModelos.ToList());

            PerguntaAnamneseViewModel view = new PerguntaAnamneseViewModel();
            view.Modelos = ListaModeloView;

            return PartialView("_Novo", view);

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


        public JsonResult Salvar(string Items)
        {
            string msg = string.Empty;
            string descricaoPergunta = string.Empty;
            int tipoPergunta = 0;

            ItensResposta lista = JsonConvert.DeserializeObject<ItensResposta>(Items);
            List<RespostaPerguntaAnamnese> listaRespostas = new List<RespostaPerguntaAnamnese>();
            WebClinica.Dominio.Entidades.PerguntasAnamnese novaPergunta = new PerguntasAnamnese();

            foreach (var item in lista.ItensRespostaModel)
            {
                if (String.IsNullOrEmpty(descricaoPergunta))
                {
                    descricaoPergunta = item.DescricaoPergunta;
                    novaPergunta.Descricao = descricaoPergunta;
                }

                if (tipoPergunta == 0)
                {
                    tipoPergunta = item.TipoPergunta;
                    novaPergunta.TipoPergunta = item.TipoPergunta;
                }

                if (item.DescricaoResposta != null)
                {
                    RespostaPerguntaAnamnese resp = new RespostaPerguntaAnamnese();
                    resp.DescricaoResposta = item.DescricaoResposta;
                    resp.TipoPerguntaID = item.TipoPergunta;

                    listaRespostas.Add(resp);
                }

            }

            _servicoPergunta.Salvar(novaPergunta, listaRespostas);

            msg = "Pergunta cadastrada com sucesso";


            var resultado = new
            {
                Msg = msg
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        public JsonResult Excluir(int perguntaId)
        {
            _servicoPergunta.Excluir(perguntaId);
            var resultado = new
            {
                OK = true
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

    }

}