using CQRS.Application.UserCases.V1.Commands;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetAllProxyQueryHandler : BasedProxyQueriesHandler, IRequestHandler<GetAllProxyQuery, IEnumerable<ProxyEntity>>
{
    public GetAllProxyQueryHandler(IProxyRepository proxyRepository) : base(proxyRepository)
    {

    }

    public async Task<IEnumerable<ProxyEntity>> Handle(GetAllProxyQuery query, CancellationToken cancellationToken)
    {
        return await _proxyRepository.GetAllProxyAsync();
    }

}
