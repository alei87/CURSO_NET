//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Registro_transaccion_deduccion = new HashSet<Registro_transaccion_deduccion>();
            this.Registro_Transaccion = new HashSet<Registro_Transaccion>();
        }
    
        public int Id_Empleado { get; set; }
        public string Cod_Empleado { get; set; }
        public string Cedula_Empleado { get; set; }
        public string Nombre_Empleado { get; set; }
        public int Id_Departamento { get; set; }
        public int Id_Puesto { get; set; }
        public double Salario_Mensual_Empleado { get; set; }
        public string Responsable_Area { get; set; }
    
        public virtual Puesto Puesto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_transaccion_deduccion> Registro_transaccion_deduccion { get; set; }
        public virtual Departamento Departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registro_Transaccion> Registro_Transaccion { get; set; }
    }
}
