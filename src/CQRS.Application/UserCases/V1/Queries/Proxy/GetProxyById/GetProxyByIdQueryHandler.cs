using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIdQueryHandler : IRequestHandler<GetProxyByIdQuery, ProxyEntity>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public GetProxyByIdQueryHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }

    public async Task<ProxyEntity> Handle(GetProxyByIdQuery query, CancellationToken cancellationToken)
    {
        return await _proxyRepository.GetByIdAsync(query.Id);
    }
}
