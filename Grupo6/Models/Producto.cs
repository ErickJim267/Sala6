using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grupo6.Models
{
    public class Producto
    {
        public int ID_Producto { get; set; }

        public string Nombre_Producto { get; set; }

        public DateTime FechaIngreso{ get; set; }

        public DateTime FechaEgreso { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        public Ubicacion Ubicacion { get; set; }

        public Estado_productos Estado { get; set; }
    }


    public class Ubicacion
    {
        public int Id_Ubicacion { get; set; }

        public string Nombre_Ubicacion { get; set; }


    }

    public class Estado_productos
    {
        public int ID_Estado { get; set; }

        public string Nombre_estado { get; set; }
    }

}
