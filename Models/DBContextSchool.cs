using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_DatabaseFirst.Models
{
    public partial class DBContextSchool : DbContext
    {
        public DBContextSchool()
            : base("name=DBContextSchoolConnectionString")
        {
        }

        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
