using CQRS.Application.UserCases.V1.Commands;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetAllProxyQueryHandler : IRequestHandler<GetAllProxyQuery, IEnumerable<ProxyEntity>>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public GetAllProxyQueryHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }

    public async Task<IEnumerable<ProxyEntity>> Handle(GetAllProxyQuery query, CancellationToken cancellationToken)
    {
        return await _proxyRepository.GetAllAsync();
    }

}
