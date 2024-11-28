using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Domain.Abstractions.Repository;
using MediatR;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIpAndPortQueryHandler : IRequestHandler<GetProxyByIpAndPortQuery, ProxyEntity>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public GetProxyByIpAndPortQueryHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }
    public async Task<ProxyEntity> Handle(GetProxyByIpAndPortQuery request, CancellationToken cancellationToken)
    {
        var proxyResponse = await _proxyRepository.GetProxyByIpAndPortAsync(request.Ip, request.Port);
        return proxyResponse;
    }
}
