﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nmplesson12.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NguyenMinhPhuong_2210900141Entities2 : DbContext
    {
        public NguyenMinhPhuong_2210900141Entities2()
            : base("name=NguyenMinhPhuong_2210900141Entities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NMP_SACH> NMP_SACH { get; set; }
        public virtual DbSet<NMP_TACGIA> NMP_TACGIA { get; set; }
    }
}