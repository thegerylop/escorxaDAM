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
    
    public partial class procInicial_Animal
    {
        public long idProcessatInicial { get; set; }
        public long idAnimal { get; set; }
        public int Pes { get; set; }
    
        public virtual animals animals { get; set; }
        public virtual processats_inicials processats_inicials { get; set; }
    }
}
