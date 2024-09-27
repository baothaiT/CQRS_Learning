using CQRS.Application.UserCases.V1.Queries.Account;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.AccountsInBrowser;

public class GetByIdAccountsInBrowserQueryHandler : IRequestHandler<GetByIdAccountsInBrowserQuery, AccountsInBrowserEntity>
{
    private readonly IAccountsInBrowserRepository<AccountsInBrowserEntity> _accountsInBrowserRepository;
    public GetByIdAccountsInBrowserQueryHandler(IAccountsInBrowserRepository<AccountsInBrowserEntity> accountsInBrowserRepository)
    {
        _accountsInBrowserRepository = accountsInBrowserRepository;
    }

    public async Task<AccountsInBrowserEntity> Handle(GetByIdAccountsInBrowserQuery query, CancellationToken cancellationToken)
    {
        return await _accountsInBrowserRepository.GetByIdAsync(query.IdAccount, query.IdBrowser);
    }
}
