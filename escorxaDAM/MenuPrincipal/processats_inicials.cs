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
    
    public partial class processats_inicials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public processats_inicials()
        {
            this.lots = new HashSet<lots>();
        }
    
        public long idProcessatInicial { get; set; }
        public long idUsuari { get; set; }
        public long idEstatInicial { get; set; }
        public int numCarril { get; set; }
        public string DIB { get; set; }
        public double pesCanal { get; set; }
    
        public virtual estat_processos_inicials estat_processos_inicials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lots> lots { get; set; }
        public virtual usuaris usuaris { get; set; }
    }
}
