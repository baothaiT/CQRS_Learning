using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class UpdateAccountCommandHandler : BasedCommandHandler<AccountEntity>, IRequestHandler<UpdateAccountCommand, AccountEntity>
{
    private readonly IMapper _mapper;
    public UpdateAccountCommandHandler(IRepository<AccountEntity> repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }

    public async Task<AccountEntity> Handle(UpdateAccountCommand request, CancellationToken cancellationToken)
    {
        var account = await _repository.GetByIdAsync(request.Id);
        if (account != null)
        {
            AccountEntity accountEntity = new AccountEntity();
            _mapper.Map(request, accountEntity);
            await _repository.UpdateAsync(accountEntity);
            return accountEntity;
        }
        throw new NotImplementedException();
    }
}
