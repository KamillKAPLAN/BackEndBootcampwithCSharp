using BootcampAPI.Models.TPH;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KAMILKAPLAN;Database=DbBackEnd;User Id=sa;Password=1;");
            // optionsBuilder.UseSqlite("Data Source=DbBackEnd.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.Entity<BankaHesabi>().ToTable("BankAcount", "dbo");
            modelBuilder.Entity<KrediKarti>().ToTable("CreeditAcount");

            modelBuilder.Entity<Student>(entity => {
                entity.ToTable("tblStudent");
                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(x => x.Name).IsRequired().HasMaxLength(55);
                entity.Property(x => x.CreatedAt).HasDefaultValue(0);
                entity.Property(a => a.UpdatedBy).HasColumnType("datetime");
                entity.Property(x => x.CreatedAt).HasColumnType("date").HasDefaultValue("2002-12-05");
            });

            modelBuilder.Entity<Notes>(e =>
            {
                //......
            });

            modelBuilder.Entity<Grade>(e =>
            {
                //......
            });
        }
    }
}
