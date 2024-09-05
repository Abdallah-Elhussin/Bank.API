using Bank.Infrastructure.Interfaces;
using Bank.Infrastructure.Services;

namespace Bank.Infrastructure.RepositeryShared
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public ICountryRepository CountryRepository { get; }
        public ISexRepository sexRepository { get; }
        public IStreetRepository streetRepository { get; }
        public IAccountRepository accountRepository { get; }
        public IClinetRepository clinetRepository { get; }
        public ICityRepository cityRepository { get; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            CountryRepository = new CountryRepository(_context);

            sexRepository = new SexRepository(_context);

            streetRepository = new StreetRepository(_context);

            accountRepository = new AccountsRepository(_context);

            clinetRepository = new ClinetRepository(_context);

            cityRepository = new CityRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }

}
