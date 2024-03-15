using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Productos()
        {
            ViewBag.Message = "Seleccione sus productos favoritos!";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Regístrese con nosotros para recibir ofertas increíbles!";

            return View();
        }
    }
}