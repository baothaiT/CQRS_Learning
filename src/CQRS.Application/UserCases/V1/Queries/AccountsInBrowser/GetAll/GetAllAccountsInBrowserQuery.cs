using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.AccountsInBrowser;

public class GetAllAccountsInBrowserQuery : IRequest<IEnumerable<AccountsInBrowserEntity>>
{
    public Guid Id { get; set; }
}
