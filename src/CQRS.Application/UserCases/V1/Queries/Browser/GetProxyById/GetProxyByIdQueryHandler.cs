using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Application.UserCases.V1.Queries;

namespace CQRS.Application.UserCases.V1.Queries.Browser;

public class GetBrowserByIdQueryHandler : BasedQueriesHandler<BrowserEntity>, IRequestHandler<GetBrowserByIdQuery, BrowserEntity>
{
    public GetBrowserByIdQueryHandler(IRepository<BrowserEntity> repository) : base(repository)
    {

    }

    public async Task<BrowserEntity> Handle(GetBrowserByIdQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(query.Id);
    }
}
