using BootcampAPI.Models.TPH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootcampAPI.Configuration
{
    public class BankAcountConfiguration : IEntityTypeConfiguration<BankaHesabi>
    {
        public void Configure(EntityTypeBuilder<BankaHesabi> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
