using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIdQueryHandler : BasedProxyQueriesHandler, IRequestHandler<GetProxyByIdQuery, ProxyEntity>
{
    public GetProxyByIdQueryHandler(IProxyRepository proxyRepository) : base(proxyRepository)
    {

    }

    public async Task<ProxyEntity> Handle(GetProxyByIdQuery query, CancellationToken cancellationToken)
    {
        return await _proxyRepository.GetProxyByIdAsync(query.Id);
    }
}
