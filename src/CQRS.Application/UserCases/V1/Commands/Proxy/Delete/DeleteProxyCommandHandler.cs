using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class DeleteProxyCommandHandler : BasedProxyCommandHandler, IRequestHandler<DeleteProxyCommand>
{
    public DeleteProxyCommandHandler(IProxyRepository proxyRepository) : base(proxyRepository)
    {

    }

    public async Task<Unit> Handle(DeleteProxyCommand request, CancellationToken cancellationToken)
    {
        await _proxyRepository.DeleteProxyAsync(request.Id);
        return Unit.Value;
    }
}
