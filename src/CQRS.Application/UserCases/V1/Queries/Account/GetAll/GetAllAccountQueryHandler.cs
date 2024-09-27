using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetAllAccountQueryHandler : BasedQueriesHandler<AccountEntity>, IRequestHandler<GetAllAccountQuery, IEnumerable<AccountEntity>>
{
    public GetAllAccountQueryHandler(IRepository<AccountEntity> repository) : base(repository)
    {

    }

    public async Task<IEnumerable<AccountEntity>> Handle(GetAllAccountQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }

}
