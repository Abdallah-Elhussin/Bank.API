using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bank.Domain.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private const string Admin = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string Clinet = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole { Id = Admin, Name = "Admin", NormalizedName = "Admin".ToUpper() },
                new IdentityRole { Id = Clinet, Name = "Clinet", NormalizedName = "Clinet".ToUpper() }
                );
        }
    }
}
