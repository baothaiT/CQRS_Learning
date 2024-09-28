using CQRS.Contract.Share.DTO._JoinDTO;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IAccountRepository<T> : IRepository<T>
    {
        Task<List<Account_Browser_DTO>> GetBrowserByAccountId(Guid IdAccount);
    }
}
