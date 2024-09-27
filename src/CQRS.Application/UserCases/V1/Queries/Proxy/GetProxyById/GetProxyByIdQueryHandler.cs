using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIdQueryHandler : BasedQueriesHandler<ProxyEntity>, IRequestHandler<GetProxyByIdQuery, ProxyEntity>
{
    public GetProxyByIdQueryHandler(IRepository<ProxyEntity> repository) : base(repository)
    {

    }

    public async Task<ProxyEntity> Handle(GetProxyByIdQuery query, CancellationToken cancellationToken)
    {
        return await _repository.GetByIdAsync(query.Id);
    }
}
