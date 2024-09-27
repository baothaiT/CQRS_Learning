using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;

public class DeleteAccountsInBrowserCommandHandler : IRequestHandler<DeleteAccountsInBrowserCommand>
{
    private readonly IAccountsInBrowserRepository<AccountsInBrowserEntity> _accountsInBrowserRepository;
    public DeleteAccountsInBrowserCommandHandler(IAccountsInBrowserRepository<AccountsInBrowserEntity> accountsInBrowserRepository)
    {
        _accountsInBrowserRepository = accountsInBrowserRepository;
    }

    public async Task<Unit> Handle(DeleteAccountsInBrowserCommand request, CancellationToken cancellationToken)
    {
        await _accountsInBrowserRepository.DeleteAsync(request.Id);
        return Unit.Value;
    }
}
