using Bank.Domain.Entities;
using Bank.Infrastructure.RepositeryShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Infrastructure.Interfaces
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
       
    }
}
