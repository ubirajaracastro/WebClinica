using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Linq.Dynamic;

namespace WebClinica.Web.Controllers
{
    public class ConvenioController : BaseController
    {
        #region membros
        private readonly IConvenioService _servico;
        private readonly IProfissionalService _servicoProfissional;
        private readonly IDescritivoTabelasPlanoService _servicoTabelas;
        #endregion

        #region Construtor
        public ConvenioController(IConvenioService servico, IProfissionalService servicoProfissional,
            IDescritivoTabelasPlanoService servicoTabelas)
        {
            _servico = servico;
            _servicoProfissional = servicoProfissional;
            _servicoTabelas = servicoTabelas;
        }
        #endregion

        #region actions
        public ActionResult Mensagem()
        {
            return View();
        }

        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<Convenio> listaConvenios = _servico.Obter();

            var lista = listaConvenios.AsQueryable();
            int total = lista.Count();

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("NomeConvenio.Contains(@0) or NumeroRegistro.Contains(@0)", searchPhrase);
            }

            return Json(new
            {
                current = 1,
                rowCount = listaConvenios.Count(),
                rows = lista,
                total = listaConvenios.Count(),
            }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            //IEnumerable<Convenio> listaConvenio = _servico.Obter();
            return View();
        }

        private List<ConvenioProfissionalQueAtendeViewModel> obterListaProfissional()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Profissional, ProfissionalViewModel>();
            });

            var listaProfissionais = _servicoProfissional.listarProfissional();

            IEnumerable<ProfissionalViewModel> listaProfissionaisView =
                Mapper.Map<IEnumerable<Profissional>, IEnumerable<ProfissionalViewModel>>(listaProfissionais);

            List<ConvenioProfissionalQueAtendeViewModel> listaProfissionaisdoConvenio = new
                List<ConvenioProfissionalQueAtendeViewModel>();

            foreach (ProfissionalViewModel item in listaProfissionaisView)
            {
                ConvenioProfissionalQueAtendeViewModel prof = new ConvenioProfissionalQueAtendeViewModel();
                prof.ProfissionalId = item.ProfissionalId;
                prof.Nome = item.Nome;
                prof.Ativo = false;

                listaProfissionaisdoConvenio.Add(prof);
            }

            return listaProfissionaisdoConvenio;
        }

        public ActionResult AlterarConvenio(int id)
        {
            Convenio convenio = _servico.ObterPorId(id);

            Mapper.Initialize(config =>
            {
                config.CreateMap<Convenio, ConvenioViewModel>();
            });

            var listaTabelas = _servicoTabelas.obter();
            ViewBag.Tabelas = new SelectList(listaTabelas, "Codigo", "Descricao");

            ConvenioViewModel model = Mapper.Map<Convenio, ConvenioViewModel>(convenio);
            model.ProfissionaisQueAtendem = obterListaProfissional();

            return View("Novo", model);
        }


        public ActionResult Novo()
        {
            var listaTabelas = _servicoTabelas.obter();
            ViewBag.Tabelas = new SelectList(listaTabelas, "Codigo", "Descricao");
            ConvenioViewModel convenioView = new ConvenioViewModel();

            convenioView.DataCadastro = DateTime.Now;
            convenioView.Ativo = false;

            convenioView.ProfissionaisQueAtendem = obterListaProfissional();


            return View(convenioView);
        }

        public JsonResult obterPlanos(int ConvenioID)
        {
            var listaPlanos = _servico.ObterPlanos(ConvenioID);
            return Json(listaPlanos, JsonRequestBehavior.AllowGet);
        }

        public JsonResult obterTabelaProcedimento(int id)
        {
            var tabela = _servicoTabelas.obter(id);

            var result = new
            {
                nomeTabela = tabela.Descricao

            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ExcluirPlano(int id)
        {
            _servico.ExcluirPlano(id);

            var result = new
            {
                retorno = "true",

            };

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SalvarPlano(string idConvenio, string descricaoPlano, int? idTabela)
        {
            ConvenioPlano plano = new ConvenioPlano();
            Convenio convenio = _servico.ObterPorId(int.Parse(idConvenio));
            plano.Convenio = convenio;
            plano.DataCadastro = DateTime.Now;
            plano.DescricaoPlano = descricaoPlano;
            plano.TabelaID = idTabela;

            int idPlano = _servico.SalvarPlano(plano);

            var result = new
            {
                retorno = "true",
                ID = idPlano,
                plano = descricaoPlano

            };

            return Json(result, JsonRequestBehavior.AllowGet);

        }
        public JsonResult Salvar(ConvenioViewModel convenio, List<ConvenioProfissionalQueAtendeViewModel> listaProfissional)
        {
            string mensagem = string.Empty;
            int idConvenio = 0;

            if (!ModelState.IsValid)
            {
                mensagem = "Ocorreu um erro no preenchimento do cadastro. Verifique os campos obrigatórios.";
            }

            else
            {
                Mapper.Initialize(config =>
                {
                    config.CreateMap<ConvenioViewModel, Convenio>();

                });

                Convenio convenioModel = Mapper.Map<ConvenioViewModel, Convenio>(convenio);
                convenioModel.CNPJClinica = CNPJClinica;
                convenioModel.DataCadastro = DateTime.Now;


                List<ConvenioProfissional> listaConvenioProfissionalDominio = new List<ConvenioProfissional>();

                foreach (ConvenioProfissionalQueAtendeViewModel item in listaProfissional)
                {
                    if (item.Ativo)
                    {
                        ConvenioProfissional convenioProf = new ConvenioProfissional();
                        convenioProf.ConvenioId = item.ConvenioId;
                        convenioProf.ProfissionalId = item.ProfissionalId;
                        listaConvenioProfissionalDominio.Add(convenioProf);
                    }
                }

                idConvenio = _servico.Salvar(convenioModel, listaConvenioProfissionalDominio);
                mensagem = "Convênio cadastrado com sucesso.";               
               

            }

            var result = new
            {
                msg = mensagem,
                retorno = "true",
                nomeConvenio = convenio.NomeConvenio,
                ID = idConvenio
            };

            return Json(result, JsonRequestBehavior.AllowGet);

        }
        #endregion
    }

}