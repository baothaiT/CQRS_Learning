using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;

public class CreateAccountsInBrowserCommandHandler : IRequestHandler<CreateAccountsInBrowserCommand, AccountsInBrowserEntity>
{
    private readonly IAccountsInBrowserRepository<AccountsInBrowserEntity> _accountsInBrowserRepository;
    private readonly IMapper _mapper;
    public CreateAccountsInBrowserCommandHandler(IAccountsInBrowserRepository<AccountsInBrowserEntity> accountsInBrowserRepository, IMapper mapper)
    {
        _accountsInBrowserRepository = accountsInBrowserRepository;
        _mapper = mapper;
    }
    public async Task<AccountsInBrowserEntity> Handle(CreateAccountsInBrowserCommand request, CancellationToken cancellationToken)
    {
        AccountsInBrowserEntity AccountsInBrowserEntity = new AccountsInBrowserEntity();
        _mapper.Map(request, AccountsInBrowserEntity);
        await _accountsInBrowserRepository.AddAsync(AccountsInBrowserEntity);
        return AccountsInBrowserEntity;
    }
}
