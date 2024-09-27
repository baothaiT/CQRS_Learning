using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.Account;

public class CreateAccountCommandHandler : BasedCommandHandler<AccountEntity>, IRequestHandler<CreateAccountCommand, AccountEntity>
{
    private readonly IMapper _mapper;
    public CreateAccountCommandHandler(IRepository<AccountEntity> repository, IMapper mapper) : base(repository)
    {
        _mapper = mapper;
    }
    public async Task<AccountEntity> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
    {
        AccountEntity AccountEntity = new AccountEntity();
        _mapper.Map(request, AccountEntity);
        AccountEntity.Id = Guid.NewGuid();
        await _repository.AddAsync(AccountEntity);
        return AccountEntity;
    }
}
