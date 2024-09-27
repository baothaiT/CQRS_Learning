using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountRepository
    {
        Task<IEnumerable<AccountEntity>> GetAllAccountAsync();
        Task<AccountEntity> GetAccountByIdAsync(Guid id);
        Task AddAccountAsync(AccountEntity account);
        Task UpdateAccountAsync(AccountEntity account);
        Task DeleteAccountAsync(Guid id);
    }
}
