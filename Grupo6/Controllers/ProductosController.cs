using Grupo6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo6.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index() 
        {

            return View();
        }

       [HttpPost]
        public ActionResult Index(Producto producto)
        {


            return View();
        }
    }
}