//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grupo6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Pedidos = new HashSet<Pedidos>();
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int Id_Persona { get; set; }
        public Nullable<int> Id_Rol { get; set; }
        public string Nombre_Persona { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Nullable<int> Id_Estado_Usuario { get; set; }
        public Nullable<int> Id_Categoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Estado_Usuario Estado_Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
