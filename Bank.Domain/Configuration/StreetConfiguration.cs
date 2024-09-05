using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Domain.Configuration
{
    public class StreetConfiguration : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(kw => kw.Id).ValueGeneratedOnAdd();
            builder.HasOne(cw => cw.City)
                .WithMany(city => city.Streets)
                .HasForeignKey(fk => fk.CityId)
                .HasPrincipalKey(ud => ud.Id);
        }

    }
}
