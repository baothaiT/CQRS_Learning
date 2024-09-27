using CQRS.Application.UserCases.V1.Commands.Account;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class DeleteAccountCommandHandler : BasedCommandHandler<AccountEntity>, IRequestHandler<DeleteAccountCommand>
{
    public DeleteAccountCommandHandler(IRepository<AccountEntity> repository) : base(repository)
    {

    }

    public async Task<Unit> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
