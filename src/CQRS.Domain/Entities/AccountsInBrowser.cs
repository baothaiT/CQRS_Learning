using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class AccountsInBrowser
{
    public Guid AccountId { get; set; }
    public Account AccountsInBrowser_Account { get; set; }

    public Guid BrowserId { get; set; }
    public Browser AccountsInBrowser_Browser { get; set; }
    public bool IsDelete { get; set; }
}
