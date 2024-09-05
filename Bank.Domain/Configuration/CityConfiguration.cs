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
    public class CityConfiguration: IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(a=> a.Id).ValueGeneratedOnAdd();
            builder.HasOne(c => c.Country)
               .WithMany(city => city.Cities)
               .HasForeignKey(fk => fk.CountryId)
               .HasPrincipalKey(pk => pk.Id);
        }
    }
}
