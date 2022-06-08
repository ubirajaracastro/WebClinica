using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using AutoMapper;

namespace WebClinica.Web.Controllers
{
    public class ConfiguracaoClinicaController : Controller
    {
        private readonly IConfiguracaoClinicaService _servico;

       public ConfiguracaoClinicaController(IConfiguracaoClinicaService servico)
        {
            _servico = servico;
                
        }

        public ActionResult Index()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<ConfiguracaoClinica, ConfiguracaoClinicaViewModel>();

            });

            ConfiguracaoClinicaViewModel configView = Mapper.Map<ConfiguracaoClinica, ConfiguracaoClinicaViewModel>(_servico.obterConfiguracao());
            
            return View(configView);
        }

        public ActionResult SalvarConfiguracao(ConfiguracaoClinicaViewModel model)
        {
            Mapper.Initialize(config =>

            {
                config.CreateMap<ConfiguracaoClinicaViewModel,ConfiguracaoClinica>();

            });
            var entidade = Mapper.Map <ConfiguracaoClinicaViewModel,ConfiguracaoClinica>(model);
            _servico.SalvarConfiguracao(entidade);

            return PartialView("~/Views/Shared/_Modal.cshtml");
           

        }
    }
}