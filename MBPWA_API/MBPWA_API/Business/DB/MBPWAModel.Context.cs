﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MBPWA_API.Business.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MBPWAEntities1 : DbContext
    {
        public MBPWAEntities1()
            : base("name=MBPWAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassPackage> ClassPackages { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
    }
}