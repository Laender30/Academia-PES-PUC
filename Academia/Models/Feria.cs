//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feria
    {
        public long FeriasID { get; set; }
        public System.DateTime DataIncio { get; set; }
        public System.DateTime DataFim { get; set; }
        public long Matricula { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}