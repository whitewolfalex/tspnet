//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mecanici
    {
        public int MecanicId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int DetaliuComandaDetaliuComandaId { get; set; }
    
        public virtual DetaliuComanda DetaliuComanda { get; set; }
    }
}
