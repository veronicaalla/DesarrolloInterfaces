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
    
    public partial class Tarea
    {
        public int TareaId { get; set; }
        public Nullable<int> DesarrolladorId { get; set; }
        public string Descripcion { get; set; }
        public string Proyecto { get; set; }
        public string Prioridad { get; set; }
        public int Estimado { get; set; }
        public Nullable<System.DateTime> Asignacion { get; set; }
        public bool Cerrada { get; set; }
    
        public virtual Desarrollador Desarrolladore { get; set; }
    }
}