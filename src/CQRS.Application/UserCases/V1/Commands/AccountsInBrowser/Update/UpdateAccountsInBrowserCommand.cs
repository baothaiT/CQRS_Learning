using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.AccountsInBrowser;

public class UpdateAccountsInBrowserCommand : UpdateAccountsInBrowserDto, IRequest<AccountsInBrowserEntity>
{
    public Guid AccountId { get; set; }
    public Guid BrowserId { get; set; }
}
