﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmpresaXwebService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class masterEntities1 : DbContext
    {
        public masterEntities1()
            : base("name=masterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<OrdemDeServico> OrdemDeServico { get; set; }
        public virtual DbSet<Peca> Peca { get; set; }
        public virtual DbSet<Realizado> Realizado { get; set; }
        public virtual DbSet<Usinagem> Usinagem { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
