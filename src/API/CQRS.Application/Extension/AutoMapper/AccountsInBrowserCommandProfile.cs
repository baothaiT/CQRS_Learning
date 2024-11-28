using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Account;
using CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Extension.AutoMapper;

public class AccountsInBrowserCommandProfile : Profile
{
    public AccountsInBrowserCommandProfile()
    {
        // Ignore the primary key (Id) to avoid overwriting it
        CreateMap<AccountsInBrowserEntity, AccountsInBrowserEntity>();

        CreateMap<CreateAccountsInBrowserDto, CreateAccountsInBrowserCommand>();
        CreateMap<UpdateAccountsInBrowserDto, UpdateAccountsInBrowserCommand>();

        CreateMap<CreateAccountsInBrowserCommand, AccountsInBrowserEntity>();
        CreateMap<UpdateAccountsInBrowserCommand, AccountsInBrowserEntity>();
    }
}
