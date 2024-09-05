using Bank.Infrastructure.Interfaces;

namespace Bank.Infrastructure.RepositeryShared
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryRepository CountryRepository { get; }
        ISexRepository sexRepository { get; }

        IStreetRepository streetRepository { get; }

        IAccountRepository accountRepository { get; }
        IClinetRepository clinetRepository { get; }
        ICityRepository cityRepository { get; }

    }

}
