using CQRS.Contract.Share.DTO._JoinDTO;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetBrowserByAccountIdQueryHandler : IRequestHandler<GetBrowserByAccountIdQuery, List<Account_Browser_DTO>>
{
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public GetBrowserByAccountIdQueryHandler(IAccountRepository<AccountEntity> accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<List<Account_Browser_DTO>> Handle(GetBrowserByAccountIdQuery request, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetBrowserByAccountId(request.AccountId);
       
    }
}
