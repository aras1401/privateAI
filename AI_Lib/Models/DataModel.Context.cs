﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AI_Lib.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Lib_AIEntities : DbContext
    {
        public Lib_AIEntities()
            : base("name=Lib_AIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<author> author { get; set; }
        public virtual DbSet<book> book { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<publisher> publisher { get; set; }
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<user_roles> user_roles { get; set; }
    }
}
