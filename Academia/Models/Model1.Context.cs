﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class academiaEntities : DbContext
    {
        public academiaEntities()
            : base("name=academiaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Aula> Aulas { get; set; }
        public virtual DbSet<Avaliacao> Avaliacaos { get; set; }
        public virtual DbSet<DiaSemana> DiaSemanas { get; set; }
        public virtual DbSet<Feria> Ferias { get; set; }
        public virtual DbSet<Pagamento> Pagamentoes { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}