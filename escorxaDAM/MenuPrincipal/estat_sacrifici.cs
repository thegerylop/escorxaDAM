//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenuPrincipal
{
    using System;
    using System.Collections.Generic;
    
    public partial class estat_sacrifici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estat_sacrifici()
        {
            this.sacrificis = new HashSet<sacrificis>();
        }
    
        public long idEstatSacrifici { get; set; }
        public string nomEstatSacrifici { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sacrificis> sacrificis { get; set; }
    }
}
