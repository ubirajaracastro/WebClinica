using AutoMapper;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System;

namespace WebClinica.Web.Controllers
{
    public class ProcedimentoController : Controller
    {
        #region membros
        private readonly IProcedimentoService _servico;
        private readonly ITipodeConsultaService _servicoTipoConsulta;
        private readonly IEspecialidadeService _servicoEsp;
        private readonly ITabelaNormativaUSSService _serviceTUSS;
        private readonly IConvenioService _servicoConvenio;
        private readonly IProcedimentoCobrancaService _servicoProcedimentoCobranca;
        #endregion

        #region construtor
        public ProcedimentoController(IProcedimentoService servico, IEspecialidadeService servicoEsp,
            ITabelaNormativaUSSService serviceTUSS, ITipodeConsultaService servicoTipoConsulta, 
            IConvenioService servicoConvenio,
            IProcedimentoCobrancaService servicoProcedimentoCobranca)
                {
                    _servico = servico;
                    _servicoEsp = servicoEsp;
                    _serviceTUSS = serviceTUSS;
                    _servicoTipoConsulta = servicoTipoConsulta;
                    _servicoConvenio = servicoConvenio;
                    _servicoProcedimentoCobranca = servicoProcedimentoCobranca;
                }

        #endregion

        #region actions
        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<Procedimento> listaProcedimentoModel = _servico.obter();
            var lista = listaProcedimentoModel.AsQueryable();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("Nome.Contains(@0) or Descricao.Contains(@0)", searchPhrase);
            }

            int totalRegistros = lista.Count();

            return Json(new
            {
                current = 1,
                rowCount = totalRegistros,
                rows = lista,
                total = totalRegistros,
            }, JsonRequestBehavior.AllowGet);

        }


        // GET: Procedimento
        public ActionResult Index()
        {

            return View();
        }

        private void carregaCombosTela()
        {
            var listaTipoConsulta = _servicoTipoConsulta.obter();
            ViewBag.TiposConsulta = new SelectList(listaTipoConsulta, "TipoConsultaId", "Descricao");
            var listaEspecialidade = _servicoEsp.obter();
            ViewBag.TiposEspecialidade = new SelectList(listaEspecialidade, "EspecialidadeId", "DescricaoEspecialidade");

        }

        [HttpPost]
        public JsonResult obterTabelaTUSS(string parametro)
        {
            var listaNormativa = _serviceTUSS.obter(parametro);
            return Json(listaNormativa, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Salvar(ProcedimentoViewModel model, 
            List<ProcedimentoCobrancaConvenioViewModel> listaConvenioCobranca)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ProcedimentoViewModel, Procedimento>();

            });

            if (!ModelState.IsValid)
            {
                return View(model);

            }

            var entidade = Mapper.Map<ProcedimentoViewModel, Procedimento>(model);
            entidade.TipoProcedimentoId = model.TipoConsultaId;
            entidade.CodigoTSUS = Request.Form["txtProcedimentoUSS"];

            List<ProcedimentoCobranca> listaProcedimentoCobrancaDominio = new List<ProcedimentoCobranca>();
            int i = 0;
            foreach (ProcedimentoCobrancaConvenioViewModel item in listaConvenioCobranca)
            {
                if (item.Ativo) { 
                    ProcedimentoCobranca cob = new ProcedimentoCobranca();
                    cob.ConvenioId = item.ConvenioId;
                    cob.ProcedimentoId = item.ProcedimentoId;
                    cob.ValorConvenio = decimal.Parse(Request.Form["ValorConvenio" + i.ToString()]);
                    cob.ValorPaciente = decimal.Parse(Request.Form["ValorPaciente" + i.ToString()]);

                    listaProcedimentoCobrancaDominio.Add(cob);                   
                }
                i += 1;
            }
            
            _servico.salvar(entidade, listaProcedimentoCobrancaDominio);

            return PartialView("~/Views/Shared/_Modal.cshtml");
        }

        public ActionResult AlteraProcedimento(int id)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Procedimento, ProcedimentoViewModel>();
            });

            carregaCombosTela();
            Procedimento procedimento = _servico.obterPorId(id);
            ProcedimentoViewModel model = Mapper.Map<Procedimento, ProcedimentoViewModel>(procedimento);
            model.TipoConsultaId = procedimento.TipoProcedimentoId;
            model.ProcedimentoTUSS = procedimento.CodigoTSUS;

            List<ProcedimentoCobrancaConvenioViewModel> listaConvenioCobrancaViewModel =
                new List<ProcedimentoCobrancaConvenioViewModel>();

            var listaConvenioCobranca = _servicoProcedimentoCobranca.obter(id);

            foreach (var item in listaConvenioCobranca)
            {
                ProcedimentoCobrancaConvenioViewModel p = new ProcedimentoCobrancaConvenioViewModel();
                p.Ativo = true;
                p.ConvenioId = item.ConvenioId;
                p.ProcedimentoId = item.ProcedimentoId;
                p.ValorConvenio = item.ValorConvenio;
                p.ValorPaciente = item.ValorPaciente;
                p.NomeConvenio = _servicoConvenio.ObterPorId(item.ConvenioId).NomeConvenio;

                listaConvenioCobrancaViewModel.Add(p);

            }
            model.ConvenioCobranca = listaConvenioCobrancaViewModel;
            
            return View("Novo", "", model);
        }


        public ActionResult Novo()
        {
            carregaCombosTela();

            Mapper.Initialize(config =>
            {
                config.CreateMap<Procedimento, ProcedimentoViewModel>();

            });

            ProcedimentoViewModel viewProcedimento = new ProcedimentoViewModel();
            var listaConvenio = _servicoConvenio.Obter();

            List<ProcedimentoCobrancaConvenioViewModel> listaConvenioCobranca = new List<ProcedimentoCobrancaConvenioViewModel>();

            foreach (var item in listaConvenio)
            {
                ProcedimentoCobrancaConvenioViewModel proc = new ProcedimentoCobrancaConvenioViewModel();
                proc.ConvenioId = item.ConvenioID;
                proc.NomeConvenio = item.NomeConvenio;
                proc.ValorConvenio = 0;
                proc.ValorPaciente = 0;

                listaConvenioCobranca.Add(proc);
            }

            viewProcedimento.ConvenioCobranca = listaConvenioCobranca;
            viewProcedimento.Ativo = true;


            return View(viewProcedimento);
        }
        #endregion

    }
}