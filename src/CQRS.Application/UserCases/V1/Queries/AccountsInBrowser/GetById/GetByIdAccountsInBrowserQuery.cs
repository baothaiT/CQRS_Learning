using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.AccountsInBrowser;

public class GetByIdAccountsInBrowserQuery : IRequest<AccountsInBrowserEntity>
{
    public Guid IdAccount { get; set; }
    public Guid IdBrowser { get; set; }
}
