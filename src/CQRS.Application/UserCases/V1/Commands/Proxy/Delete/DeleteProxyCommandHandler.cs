using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class DeleteProxyCommandHandler : IRequestHandler<DeleteProxyCommand>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public DeleteProxyCommandHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }

    public async Task<Unit> Handle(DeleteProxyCommand request, CancellationToken cancellationToken)
    {
        await _proxyRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
