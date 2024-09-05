using Bank.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bank.Domain.Configuration
{
    public class CountryConfiguration :  IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(ka => ka.Id).ValueGeneratedOnAdd();
               
        }
    }
}
