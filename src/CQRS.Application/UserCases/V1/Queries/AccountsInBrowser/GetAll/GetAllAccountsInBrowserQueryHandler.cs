﻿using CQRS.Application.UserCases.V1.Queries.Account;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.AccountsInBrowser;

public class GetAllAccountsInBrowserQueryHandler : IRequestHandler<GetAllAccountsInBrowserQuery, IEnumerable<AccountsInBrowserEntity>>
{
    private readonly IAccountsInBrowserRepository<AccountsInBrowserEntity> _accountsInBrowserRepository;
    public GetAllAccountsInBrowserQueryHandler(IAccountsInBrowserRepository<AccountsInBrowserEntity> accountsInBrowserRepository)
    {
        _accountsInBrowserRepository = accountsInBrowserRepository;
    }

    public async Task<IEnumerable<AccountsInBrowserEntity>> Handle(GetAllAccountsInBrowserQuery query, CancellationToken cancellationToken)
    {
        return await _accountsInBrowserRepository.GetAllAsync();
    }
}
