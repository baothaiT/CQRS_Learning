using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Account: BasedTable
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsStatus { get; set; }
    public DateTime CreateDate { get; set; }

    // Navigation Proxy
    public Guid? Proxy { get; set; }
    public Proxy? Account_Proxy { get; set; }

    // Navigation AccountType
    public Guid UserType { get; set; } // FK to AccountType
    public AccountType AccountType { get; set; }


    public ICollection<Logs> Logs { get; set; }
    public ICollection<AccountsInBrowser> Account_AccountsInBrowser { get; set; }
    public ICollection<AccountsInProject> Account_AccountsInProject { get; set; }
}
