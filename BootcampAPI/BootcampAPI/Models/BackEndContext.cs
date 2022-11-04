﻿using BootcampAPI.Models.TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace BootcampAPI.Models
{
    public class BackEndContext : DbContext
    {
        public BackEndContext() { }
        public BackEndContext(DbContextOptions<BackEndContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<FaturaDetayi> FaturaDetayis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KAMILKAPLAN;Database=DbBackEnd;User Id=sa;Password=1;");
            // optionsBuilder.UseSqlite("Data Source=DbBackEnd.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankaHesabi>().ToTable("BankAcount");
            modelBuilder.Entity<KrediKarti>().ToTable("CreeditAcount");
        }
    }
}