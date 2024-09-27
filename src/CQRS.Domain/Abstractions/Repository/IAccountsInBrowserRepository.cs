using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountsInBrowserRepository<T> : IWriteRepository<T>
    {
        Task<IEnumerable<AccountsInBrowserEntity>> GetAllAsync();
        Task<AccountsInBrowserEntity> GetByIdAsync(Guid idAccount, Guid idBrowser);
    }
}
