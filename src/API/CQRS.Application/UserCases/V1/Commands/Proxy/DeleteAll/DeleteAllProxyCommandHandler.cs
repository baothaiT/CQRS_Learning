using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class DeleteAllProxyCommandHandler : IRequestHandler<DeleteAllProxyCommand>
{
    private readonly IProxyRepository<ProxyEntity> _proxyRepository;
    public DeleteAllProxyCommandHandler(IProxyRepository<ProxyEntity> proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }

    public async Task<Unit> Handle(DeleteAllProxyCommand request, CancellationToken cancellationToken)
    {
        await _proxyRepository.DeleteAllAsync();
        return Unit.Value;
    }
}
