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
    
    public partial class Avaliacao
    {
        public long AvaliacaoID { get; set; }
        public string Anamnese { get; set; }
        public string Ergometrico { get; set; }
        public string DobrasCutaneas { get; set; }
        public System.DateTime DataRealizacao { get; set; }
        public System.DateTime DataAgendamento { get; set; }
        public long Matricula { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}