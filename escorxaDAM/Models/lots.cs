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
    
    public partial class lots
    {
        public long idLot { get; set; }
        public long idRemo { get; set; }
        public Nullable<long> idEstabulacio { get; set; }
        public Nullable<long> idSacrifici { get; set; }
        public Nullable<long> idProcessatInicial { get; set; }
        public Nullable<long> idProcessatFinal { get; set; }
        public Nullable<long> idEmmagatzematge { get; set; }
        public string numLot { get; set; }
    
        public virtual emmagatzematges emmagatzematges { get; set; }
        public virtual estables estables { get; set; }
        public virtual processats_finals processats_finals { get; set; }
        public virtual processats_inicials processats_inicials { get; set; }
        public virtual recepcions_bestiar recepcions_bestiar { get; set; }
        public virtual sacrificis sacrificis { get; set; }
    }
}