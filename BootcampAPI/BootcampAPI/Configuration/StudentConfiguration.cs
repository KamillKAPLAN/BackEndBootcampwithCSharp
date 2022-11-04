using BootcampAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootcampAPI.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("tblStudent");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50).HasDefaultValue("isim alalnı boş");
            //builder.Property(x => x.CreatedAt).HasDefaultValue("");    
            builder.HasOne<StudentAddress>(x => x.StudentAddress)
                .WithOne(x => x.Student)
                .HasForeignKey<StudentAddress>(x => x.StudentAddressId);
        }
    }
}
