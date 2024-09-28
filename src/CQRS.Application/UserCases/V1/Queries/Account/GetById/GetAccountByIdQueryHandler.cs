using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, AccountEntity>
{
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public GetAccountByIdQueryHandler(IAccountRepository<AccountEntity> accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<AccountEntity> Handle(GetAccountByIdQuery query, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetByIdAsync(query.Id);
    }
}
