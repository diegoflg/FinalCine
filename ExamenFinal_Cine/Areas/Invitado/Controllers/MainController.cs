using Semana13_2_AJAX_Cine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Semana13_2_AJAX_Cine.Areas.Invitado.Controllers
{
    public class MainController : Controller
    {
        // GET: Invitado/Main
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listado()
        {
            return PartialView(DAGeneral.listadoInterprete());
        }
    }
}