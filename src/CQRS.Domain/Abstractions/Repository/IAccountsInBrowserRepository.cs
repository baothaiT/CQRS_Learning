using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountsInBrowserRepository
    {
        Task<IEnumerable<AccountsInBrowserEntity>> GetAllAccountsInBrowserAsync();
        Task<AccountsInBrowserEntity> GetAccountsInBrowserByIdAsync(Guid id);
        Task AddAccountsInBrowserAsync(AccountsInBrowserEntity accountsInBrowser);
        Task UpdateAccountsInBrowserAsync(AccountsInBrowserEntity accountsInBrowser);
        Task DeleteAccountsInBrowserAsync(Guid id);
    }
}
