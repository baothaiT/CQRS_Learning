using CQRS.Contract.Share.DTO;
using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;

public class CreateAccountsInBrowserCommand : CreateAccountsInBrowserDto, IRequest<AccountsInBrowserEntity>
{
}
