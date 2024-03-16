using Grupo6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo6.Controllers
{
    public class ProductoController : Controller
    {

        Grupo6Entities contexto = new Grupo6Entities();

        // GET: 
        public ActionResult Index() 
        {

            return View();
        }

        // GET: Productos
        public ActionResult Productos()
        {

            //if (TempData["msj"] != null)
            //{
            //    ViewBag.msj = TempData["msj"];
            //}

            List<Producto> data = contexto.Producto.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Producto producto)
        {

            string accion = Request.Form["boton"].ToString();
            string eliminacion = Request.Form["eliminacion"].ToString();
            string modificacion = Request.Form["modificacion"].ToString();

            switch (accion)
            {
                case "Guardar":
                    contexto.Producto.Add(producto);
                    contexto.SaveChanges();
                    TempData["msj"] = "Guardado";

                    break;

                case "Modificar":
                    if (modificacion.Equals("si"))
                    {
                        Producto temp = contexto.Producto.FirstOrDefault(p => p.Id_Producto == producto.Id_Producto);
                        temp.Id_Ubicacion = producto.Id_Ubicacion;
                        temp.Nombre_Producto = producto.Nombre_Producto;
                        temp.Pedidos = producto.Pedidos;
                        temp.Precio = producto.Precio;
                        temp.Ubicacion = producto.Ubicacion;
                        temp.Id_Estado = producto.Id_Estado;
                        temp.Estado_Productos = producto.Estado_Productos;
                        temp.Cantidad = producto.Cantidad;
                        contexto.SaveChanges();
                        TempData["msj"] = "Modificado";

                    }

                    break;


                case "Eliminar":
                    if (eliminacion.Equals("si"))
                    {
                        contexto.Producto.Remove(contexto.Producto.Remove(contexto.Producto.FirstOrDefault(p => p.Id_Producto == producto.Id_Producto)));
                        contexto.SaveChanges();
                        TempData["msj"] = "Eliminado";

                    }


                    break;
            }

            return View();
        }
    }
}