//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_VeronicaAlvarez
{
    using System;
    using System.Collections.Generic;
    
    public partial class Desarrollador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Desarrollador()
        {
            this.Tareas = new HashSet<Tarea>();
        }
    
        public int DesarrolladorId { get; set; }
        public string Nombre { get; set; }
        public System.DateTime Nacimiento { get; set; }
        public string Telefono { get; set; }
        public string Categoria { get; set; }
        public string Codigo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
