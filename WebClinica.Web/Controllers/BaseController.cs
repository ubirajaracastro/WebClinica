using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;

namespace WebClinica.Web.Controllers
{
    public class BaseController : Controller
    {       
        public BaseController()
        {

        }
       
        public string CNPJClinica

        {
            get { return "45543915003954"; }

        }

        public String ErrorMessage
        {
            get { return TempData["ErrorMessage"] == null ? String.Empty : TempData["ErrorMessage"].ToString(); }
            set { TempData["ErrorMessage"] = value; }
        }


    }
}