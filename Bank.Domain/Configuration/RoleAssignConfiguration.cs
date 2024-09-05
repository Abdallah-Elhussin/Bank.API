using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Bank.Domain.Configuration
{
    public class RoleAssignConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private const string Admin = "2301D884-221A-4E7D-B509-0113DCC043E1";

        private const string AdministratorId = "B22698B8-42A2-4115-9631-1C2D1E2AC5F7";

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            IdentityUserRole<string> iur = new IdentityUserRole<string>
            {
                RoleId = Admin,
                UserId = AdministratorId
            };

            builder.HasData(iur);
        }
    }
}
