using CQRS.Contract.Share.DTO._JoinDTO;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetProxyAndBrowserByAccountIdQueryHandler : IRequestHandler<GetProxyAndBrowserByAccountIdQuery, List<Proxy_Account_Browser_DTO>>
{
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public GetProxyAndBrowserByAccountIdQueryHandler(IAccountRepository<AccountEntity> accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public async Task<List<Proxy_Account_Browser_DTO>> Handle(GetProxyAndBrowserByAccountIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var accountResponse = await _accountRepository.GetProxyAndBrowser_ByAccountId(request.AccountId);
            return accountResponse;
        }
        catch (Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
