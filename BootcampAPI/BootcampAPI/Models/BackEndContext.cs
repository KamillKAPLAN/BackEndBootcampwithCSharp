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
        }
    }
}
