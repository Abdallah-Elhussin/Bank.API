using Bank.Domain.Configuration;
using Bank.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Bank.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Clinet> Clinets { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Sex> Sexs { get; set; }
     
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new CityConfiguration());
            builder.ApplyConfiguration(new AccountConfiguration());
            builder.ApplyConfiguration(new StreetConfiguration());
            builder.ApplyConfiguration(new SexConfiguration());

            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new RoleAssignConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
