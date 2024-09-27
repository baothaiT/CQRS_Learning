using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Browser;

public class DeleteBrowserCommandHandler : BasedCommandHandler<BrowserEntity>, IRequestHandler<DeleteBrowserCommand>
{
    public DeleteBrowserCommandHandler(IRepository<BrowserEntity> repository) : base(repository)
    {

    }

    public async Task<Unit> Handle(DeleteBrowserCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
