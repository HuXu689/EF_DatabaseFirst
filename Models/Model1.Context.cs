﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DatabaseFirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TruongEF_DBFirstEntities : DbContext
    {
        public TruongEF_DBFirstEntities()
            : base("name=TruongEF_DBFirstEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }
    }
}