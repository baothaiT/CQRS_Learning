using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetAllAccountQueryHandler : IRequestHandler<GetAllAccountQuery, IEnumerable<AccountEntity>>
{
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public GetAllAccountQueryHandler(IAccountRepository<AccountEntity> accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<IEnumerable<AccountEntity>> Handle(GetAllAccountQuery query, CancellationToken cancellationToken)
    {
        return await _accountRepository.GetAllAsync();
    }

}
