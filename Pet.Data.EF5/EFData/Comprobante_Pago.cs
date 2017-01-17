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
    
    public partial class Comprobante_Pago
    {
        public Comprobante_Pago()
        {
            this.Comprobante_Examen = new HashSet<Comprobante_Examen>();
        }
    
        public int id_comprobante { get; set; }
        public int id_cliente { get; set; }
        public int id_paciente { get; set; }
        public string numero_comprobante { get; set; }
        public Nullable<decimal> monto_total { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string tipo_comprobante { get; set; }
        public string forma_pago { get; set; }
        public string estado_comprobante { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Comprobante_Examen> Comprobante_Examen { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}