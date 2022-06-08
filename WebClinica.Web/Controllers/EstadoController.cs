using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;

namespace WebClinica.Web.Controllers
{
    public class EstadoController : Controller
    {
        private readonly ICidadeService _servico;

        public EstadoController(ICidadeService servico)
        {
            _servico = servico;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult obterCidadePorEstado(int estadoID)
        {
            var listaCidade = _servico.obterCidadesPorEstado(estadoID);
            return Json(listaCidade, JsonRequestBehavior.AllowGet);
        }
    }
}