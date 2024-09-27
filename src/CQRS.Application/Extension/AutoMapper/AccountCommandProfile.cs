using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Account;
using CQRS.Application.UserCases.V1.Queries.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Extension.AutoMapper;

public class AccountCommandProfile : Profile
{
    public AccountCommandProfile()
    {
        // Ignore the primary key (Id) to avoid overwriting it
        CreateMap<AccountEntity, AccountEntity>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());



        CreateMap<CreateAccountsDto, CreateAccountCommand>();
        CreateMap<UpdateAccountsDto, UpdateAccountCommand>();

        CreateMap<CreateAccountCommand, AccountEntity>();
        CreateMap<UpdateAccountCommand, AccountEntity>();
    }
}
