using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BootcampAPI.Models
{
    public class BackEndContext : DbContext
    {
        public BackEndContext() { }
        public BackEndContext(DbContextOptions<BackEndContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KAMILKAPLAN;Database=DbBackEnd;User Id=sa;Password=1;");
            // optionsBuilder.UseSqlite("Data Source=DbBackEnd.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
