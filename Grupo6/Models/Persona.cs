using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grupo6.Models
{
    public class Persona
    {
        public int ID_Persona { get; set; }

        public Rol Rol { get; set; }

        public string Nombre_Cpersona { get; set; }

        public string Direccion{ get; set; }

        public string Telefono { get; set; }

        public string Correo{ get; set; }

        public Estado_usuario Estado_Usuario { get; set; }

        public Categoria Categoria { get; set; }
    }

    public class Rol
    {
        public int Id_Rol { get; set; }

        public string Nombre_Rol { get; set; }
    }


    public class Estado_usuario
    {
        public int Id_estado_usuario { get; set; }

        public string Nombre_estado { get; set; }

    }

    public class Categoria
    {
        public int Id_categoria { get; set; }

        public string Nombre_Categoria { get; set; }

        public decimal Descuento { get; set; }
    }
}