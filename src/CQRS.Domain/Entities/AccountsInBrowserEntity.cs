using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class AccountsInBrowserEntity
{
    public Guid AccountId { get; set; }
    public AccountEntity AccountsInBrowser_Account { get; set; }

    public Guid BrowserId { get; set; }
    public BrowserEntity AccountsInBrowser_Browser { get; set; }
    public bool IsDelete { get; set; }
    public bool? IsMigration { get; set; }
}
