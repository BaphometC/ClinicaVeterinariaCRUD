//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Recepcionista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recepcionista()
        {
            this.Cita = new HashSet<Cita>();
        }
    
        public int IdRecepcionista { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
