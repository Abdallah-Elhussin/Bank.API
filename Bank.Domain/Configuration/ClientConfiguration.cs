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
    public class ClientConfiguration:IEntityTypeConfiguration<Clinet>
    {
        public void Configure(EntityTypeBuilder<Clinet> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(kb => kb.Id).ValueGeneratedOnAdd();
            builder.HasOne(c => c.sexType)
                 .WithMany(city => city.Clinets)
                 .HasForeignKey(fka => fka.SexId)
                 .HasPrincipalKey(u => u.Id) ;
            builder.HasOne(ab => ab.account)
                 .WithMany(qb => qb.Clinets)
                 .HasForeignKey(fks => fks.AccountID)
                 .HasPrincipalKey(u => u.Id);
            builder.HasOne(ac => ac.Street)
                .WithMany(qc => qc.Clinets)
                .HasForeignKey(fkd => fkd.StreetId)
                .HasPrincipalKey(uc => uc.Id);
            builder.HasOne(ad => ad.AppUser)
               .WithMany(qd => qd.Clinets)
               .HasForeignKey(fkf => fkf.AppUserId)
               .HasPrincipalKey(ud => ud.Id);
        }
    }
}
