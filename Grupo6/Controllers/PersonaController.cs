using Grupo6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grupo6.Controllers
{
    public class PersonaController : Controller
    {
        Grupo6Entities contexto = new Grupo6Entities();
        // GET: 
        public ActionResult Index()
        {

            return View();
        }

        // GET: Persona
        public ActionResult Persona()
        {

            if (TempData["msj"] != null)
            {
                ViewBag.msj = TempData["msj"];
            }

            List<Persona> data = contexto.Persona.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {

            string accion = Request.Form["boton"].ToString();
            string eliminacion = Request.Form["eliminacion"].ToString();
            string modificacion = Request.Form["modificacion"].ToString();

            switch (accion)
            {
                case "Guardar":
                    contexto.Persona.Add(persona);
                    contexto.SaveChanges();
                    TempData["msj"] = "Guardado";

                    break;

                case "Modificar":
                    if (modificacion.Equals("si"))
                    {
                        Persona temp = contexto.Persona.FirstOrDefault(p => p.Id_Persona == persona.Id_Persona);
                        temp.Nombre_Persona = persona.Nombre_Persona;
                        temp.Categoria = persona.Categoria;
                        temp.Direccion = persona.Direccion;
                        temp.Telefono = persona.Telefono;
                        temp.Correo = persona.Correo;
                        temp.Id_Rol = persona.Id_Rol;
                        temp.Estado_Usuario = persona.Estado_Usuario;
                        temp.Id_Categoria = persona.Id_Categoria;

                        contexto.SaveChanges();
                        TempData["msj"] = "Modificado";

                    }

                    break;


                case "Eliminar":
                    if (eliminacion.Equals("si"))
                    {
                        contexto.Persona.Remove(contexto.Persona.Remove(contexto.Persona.FirstOrDefault(p => p.Id_Persona  == persona.Id_Persona)));
                        contexto.SaveChanges();
                        TempData["msj"] = "Eliminado";

                    }


                    break;
            }

            return View();
        }
    }
}