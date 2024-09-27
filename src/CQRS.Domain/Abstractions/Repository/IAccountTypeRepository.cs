using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountTypeRepository
    {
        Task<IEnumerable<AccountTypeEntity>> GetAllAccountTypeAsync();
        Task<AccountTypeEntity> GetAccountTypeByIdAsync(Guid id);
        Task AddAccountTypeAsync(AccountTypeEntity accountType);
        Task UpdateAccountTypeAsync(AccountTypeEntity accountType);
        Task DeleteAccountTypeAsync(Guid id);
    }
}
