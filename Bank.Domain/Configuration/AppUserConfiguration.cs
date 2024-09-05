using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Bank.Domain.Entities;

namespace Bank.Domain.Configuration
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        private const string AdministratorId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var admin = new AppUser
            {
                Id = AdministratorId,
                UserName = "Admin",
                NormalizedUserName = "Admin".ToUpper(),
                Email = "Admin@Admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
            };
            admin.PasswordHash = PassGenerate(admin);

            builder.HasData(admin);
        }
        public string PassGenerate(AppUser user)
        {
            var passHash = new PasswordHasher<AppUser>();
            return passHash.HashPassword(user, "Admin@0489");
        }
    }
}
