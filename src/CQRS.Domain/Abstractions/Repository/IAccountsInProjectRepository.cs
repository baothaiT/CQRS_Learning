using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountsInProjectRepository
    {
        Task<IEnumerable<AccountsInProjectEntity>> GetAllAccountsInProjectAsync();
        Task<AccountsInProjectEntity> GetAccountsInProjectByIdAsync(Guid id);
        Task AddAccountsInProjectAsync(AccountsInProjectEntity accountsInProject);
        Task UpdateAccountsInProjectAsync(AccountsInProjectEntity accountsInProject);
        Task DeleteAccountsInProjectAsync(Guid id);
    }
}
