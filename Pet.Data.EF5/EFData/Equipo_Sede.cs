//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pet.Data.EF5.EFData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipo_Sede
    {
        public Equipo_Sede()
        {
            this.Detalle_Atencion = new HashSet<Detalle_Atencion>();
        }
    
        public int id_equipo { get; set; }
        public string descripcion { get; set; }
        public int id_sede { get; set; }
    
        public virtual ICollection<Detalle_Atencion> Detalle_Atencion { get; set; }
        public virtual Sede Sede { get; set; }
    }
}
