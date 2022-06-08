using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using System.Linq.Dynamic;
using AutoMapper;

namespace WebClinica.Web.Controllers
{
    public class TipodeConsultaController : Controller
    {
        ITipodeConsultaService _servico;
        const string CNPJ = "45543915003954";

        public TipodeConsultaController(ITipodeConsultaService servico)
        {
            _servico = servico;

        }
        public ActionResult Index() 
        {
            return View();
        }

        public JsonResult Excluir(int tipoConsultaID)
        {
            _servico.Excluir(tipoConsultaID);
            var resultado = new
            {
                OK = true
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }
        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<TipodeConsulta> listaTipoConsultaModel = _servico.obter();       
            var lista = listaTipoConsultaModel.AsQueryable();

            //generos.ForEach(g => contexto.Generos.Add(g));           

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("Descricao.Contains(@0)", searchPhrase);
            }
            
            int total = lista.Count();

            return Json(new
            {  current = 1,
                rowCount = total,
                rows = lista,
                total = total,
            }, JsonRequestBehavior.AllowGet);
         }


        public ActionResult Novo()
        {          
            TipodeConsultaViewModel tipoConsulta = new TipodeConsultaViewModel();
            return View(tipoConsulta);
        }

        public ActionResult Salvar(TipodeConsultaViewModel tipoConsulta)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<TipodeConsultaViewModel, TipodeConsulta>();
            });

            TipodeConsulta tipoConsultaModelo = Mapper.Map<TipodeConsultaViewModel, TipodeConsulta>(tipoConsulta);
            tipoConsultaModelo.CNPJClinica = CNPJ;

            if (!ModelState.IsValid)
                return View(tipoConsulta);


            _servico.Salvar(tipoConsultaModelo);
                return PartialView("~/Views/Shared/_Modal.cshtml");            
        
        }

    }
}