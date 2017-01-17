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
    
    public partial class Empleado
    {
        public Empleado()
        {
            this.Cartilla_Atencion = new HashSet<Cartilla_Atencion>();
            this.Detalle_Atencion = new HashSet<Detalle_Atencion>();
            this.Empleado1 = new HashSet<Empleado>();
        }
    
        public int id_empleado { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellido_paterno { get; set; }
        public string apellido_materno { get; set; }
        public string especialidad { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public Nullable<System.DateTime> fecha_nacimiento { get; set; }
        public string telefono_casa { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string cargo { get; set; }
        public Nullable<int> id_supervisor { get; set; }
        public int id_sede { get; set; }
    
        public virtual ICollection<Cartilla_Atencion> Cartilla_Atencion { get; set; }
        public virtual ICollection<Detalle_Atencion> Detalle_Atencion { get; set; }
        public virtual Sede Sede { get; set; }
        public virtual ICollection<Empleado> Empleado1 { get; set; }
        public virtual Empleado Empleado2 { get; set; }
    }
}
