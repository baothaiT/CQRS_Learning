using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Account;


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
