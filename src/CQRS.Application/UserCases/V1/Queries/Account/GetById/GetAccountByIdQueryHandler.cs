using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetAccountByIdQueryHandler : BasedQueriesHandler<AccountEntity>, IRequestHandler<GetAccountByIdQuery, AccountEntity>
{
    public GetAccountByIdQueryHandler(IRepository<AccountEntity> repository) : base(repository)
    {

    }

    public async Task<AccountEntity> Handle(GetAccountByIdQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(query.Id);
    }
}
