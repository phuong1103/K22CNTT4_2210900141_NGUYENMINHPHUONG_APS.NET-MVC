﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NmpLesson07Db.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NmpK22CNTT4_Lesson07DbEntities : DbContext
    {
        public NmpK22CNTT4_Lesson07DbEntities()
            : base("name=NmpK22CNTT4_Lesson07DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NmpKhoa> NmpKhoas { get; set; }
        public virtual DbSet<NmpSinhVien> NmpSinhViens { get; set; }
    }
}
