using CQRS.Application.UserCases.V1.Commands;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Application.UserCases.V1.Queries;

namespace CQRS.Application.UserCases.V1.Queries.Browser;

public class GetAllBrowserQueryHandler : BasedQueriesHandler<BrowserEntity>, IRequestHandler<GetAllBrowserQuery, IEnumerable<BrowserEntity>>
{
    public GetAllBrowserQueryHandler(IRepository<BrowserEntity> repository) : base(repository)
    {

    }

    public async Task<IEnumerable<BrowserEntity>> Handle(GetAllBrowserQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }

}
