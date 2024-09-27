using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class DeleteProxyCommandHandler : BasedCommandHandler<ProxyEntity>, IRequestHandler<DeleteProxyCommand>
{
    public DeleteProxyCommandHandler(IRepository<ProxyEntity> repository) : base(repository)
    {

    }

    public async Task<Unit> Handle(DeleteProxyCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
