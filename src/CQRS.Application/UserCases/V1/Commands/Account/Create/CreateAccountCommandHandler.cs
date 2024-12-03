using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, AccountEntity>
{
    private readonly IMapper _mapper;
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public CreateAccountCommandHandler(IMapper mapper, IAccountRepository<AccountEntity> accountRepository)
    {
        _mapper = mapper;
        _accountRepository = accountRepository;
    }
    public async Task<AccountEntity> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        AccountEntity AccountEntity = new AccountEntity();
        _mapper.Map(request, AccountEntity);
        AccountEntity.Id = Guid.NewGuid();
        await _accountRepository.AddAsync(AccountEntity);
        return AccountEntity;
    }
}
