using CQRS.Application.UserCases.V1.Commands.Account;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class DeleteAccountCommandHandler : IRequestHandler<DeleteAccountCommand>
{
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public DeleteAccountCommandHandler(IAccountRepository<AccountEntity> accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Unit> Handle(DeleteAccountCommand request, CancellationToken cancellationToken)
    {
        await _accountRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
