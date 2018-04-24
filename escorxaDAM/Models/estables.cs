//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class estables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estables()
        {
            this.lots = new HashSet<lots>();
        }
    
        public long idEstable { get; set; }
        public long idUsuariResponsable { get; set; }
        public long idEstatEstabulacio { get; set; }
        public long idInspeccioSanitaria { get; set; }
        public string numEstable { get; set; }
        public System.DateTime dataEntrada { get; set; }
        public System.DateTime dataSortida { get; set; }
        public string Incidencies { get; set; }
    
        public virtual estat_estabulacions estat_estabulacions { get; set; }
        public virtual inspeccions inspeccions { get; set; }
        public virtual usuaris usuaris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lots> lots { get; set; }
    }
}
