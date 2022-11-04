using BootcampAPI.Models.TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootcampAPI.Configuration
{
    public class CreeditAcountConfiguration : IEntityTypeConfiguration<KrediKarti>
    {
        public void Configure(EntityTypeBuilder<KrediKarti> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
