using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class UpdateAccountCommandHandler : IRequestHandler<UpdateAccountCommand, AccountEntity>
{
    private readonly IMapper _mapper;
    private readonly IAccountRepository<AccountEntity> _accountRepository;
    public UpdateAccountCommandHandler(IMapper mapper, IAccountRepository<AccountEntity> accountRepository)
    {
        _mapper = mapper;
        _accountRepository = accountRepository;
    }

    public async Task<AccountEntity> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = await _accountRepository.GetByIdAsync(request.Id);
        if (account != null)
        {
            AccountEntity accountEntity = new AccountEntity();
            _mapper.Map(request, accountEntity);
            await _accountRepository.UpdateAsync(accountEntity);
            return accountEntity;
        }
        throw new NotImplementedException();
    }
}
