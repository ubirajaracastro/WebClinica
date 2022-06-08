using System.Web.Mvc;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using AutoMapper;
using WebClinica.Comum.Validacao;

namespace WebClinica.Web.Controllers
{
    public class ClinicaController : Controller
    {
        const int idPais = 1;
        private readonly IClinicaService _servico;
        private readonly IEstadoService _servicoUf;
        private readonly ICidadeService _servicoCidade;

        public ClinicaController(IClinicaService servico, IEstadoService servicoUF, ICidadeService servicoCidade)
        {
            _servico = servico;
            _servicoUf = servicoUF;
            _servicoCidade = servicoCidade;
        }


        public ActionResult Index()
        {
            var listaUf = _servicoUf.obterEstados(idPais);
            var listaEstados = new List<SelectListItem>();


            foreach (var item in listaUf)
            {
                listaEstados.Add(new SelectListItem

                {
                    Value = item.Id.ToString(),
                    Text = item.Nome

                });

            }
            ViewBag.ListaUF = new SelectList(listaUf, "EstadoId", "Nome");

            Mapper.Initialize(config =>

            {
                config.CreateMap<Clinica, ClinicaViewModel>();

            });

            Clinica objClinica = _servico.obterClinica();
            if (objClinica.ClinicaId>0)
            {
                var nomeCidadeAtual = _servicoCidade.obterCidade(objClinica.IdCidade);
                ViewBag.CidadeAtual = nomeCidadeAtual.Nome;
                ViewBag.CodigoCidadeAtual = nomeCidadeAtual.Id;

                if (objClinica.UtilizaTISS)
                    ViewBag.UtilizaTISS = "true";

            }            
                      
            ClinicaViewModel clinicaView = Mapper.Map<Clinica, ClinicaViewModel>(objClinica);
            return View(clinicaView);

        }

        [HttpPost]
        public JsonResult obterCidadePorEstado(int estadoID)
        {
            var listaCidade = _servicoCidade.obterCidadesPorEstado(estadoID);
            return Json(listaCidade, JsonRequestBehavior.AllowGet);
        }

        
        // GET: Clinica/Create
        public ActionResult Salvar(ClinicaViewModel model)
        {
            Mapper.Initialize(config =>

            {
                config.CreateMap<ClinicaViewModel, Clinica>();

            });

            if (!ModelState.IsValid)
            {   
                return View(model);

            }                           


            if(!Util.ValidaCnpj(model.CNPJ))
            {
                ViewBag.CNPJValido = "false";
                return View(model);
            }
            
             model.IdCidade = int.Parse(Request.Form["Cidade"]);
             var entidade = Mapper.Map<ClinicaViewModel, Clinica>(model);
            _servico.salvarClinica(entidade);

             return PartialView("~/Views/Shared/_Modal.cshtml");
                

            }


        // GET: Clinica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clinica/Delete/5
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
