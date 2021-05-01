using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebOBS.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using WebOBS.Entity;

namespace WebOBS.DataAccess.Concrete.EntityFrameworkCore
{
   public class WebOBSDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-5BF3GC9;Database=ObsDB;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        }
        public DbSet<Ogrenci> Ogrenci { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<DersOgrenci> DersOgrenci { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Ogrenci>(new OgrenciMap());
            modelBuilder.ApplyConfiguration<Ders>(new DersMap());
            modelBuilder.ApplyConfiguration<DersOgrenci>(new DersOgrenciMap());
        }
    }
}
