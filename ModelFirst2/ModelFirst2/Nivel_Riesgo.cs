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
    
    public partial class Nivel_Riesgo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nivel_Riesgo()
        {
            this.Puesto = new HashSet<Puesto>();
        }
    
        public int Id_nivel_Riesgo { get; set; }
        public string Tipo_Riesgo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Puesto> Puesto { get; set; }
    }
}
