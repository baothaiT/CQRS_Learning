using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;

public class UpdateAccountsInBrowserCommandHandler : IRequestHandler<UpdateAccountsInBrowserCommand, AccountsInBrowserEntity>
{
    private readonly IMapper _mapper;
    private readonly IAccountsInBrowserRepository<AccountsInBrowserEntity> _accountsInBrowserRepository;
    public UpdateAccountsInBrowserCommandHandler(IAccountsInBrowserRepository<AccountsInBrowserEntity> accountsInBrowserRepository, IMapper mapper)
    {
        _accountsInBrowserRepository = accountsInBrowserRepository;
        _mapper = mapper;
    }

    public async Task<AccountsInBrowserEntity> Handle(UpdateAccountsInBrowserCommand request, CancellationToken cancellationToken)
    {
        var accountsInBrowser = await _accountsInBrowserRepository.GetByIdAsync(request.AccountId, request.BrowserId);
        if (accountsInBrowser != null)
        {
            AccountsInBrowserEntity accountsInBrowserEntity = new AccountsInBrowserEntity();
            _mapper.Map(request, accountsInBrowserEntity);
            await _accountsInBrowserRepository.UpdateAsync(accountsInBrowserEntity);
            return accountsInBrowserEntity;
        }
        throw new NotImplementedException();
    }
}
