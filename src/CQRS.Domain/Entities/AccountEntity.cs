﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class AccountEntity: BasedTableEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public bool IsStatus { get; set; }
    public DateTime CreateDate { get; set; }

    // Navigation Proxy
    public Guid? Proxy { get; set; }
    public ProxyEntity? Account_Proxy { get; set; }

    // Navigation AccountType
    public Guid? UserType { get; set; } // FK to AccountType
    public AccountTypeEntity? AccountType { get; set; }


    public ICollection<LogsEntity>? Logs { get; set; }
    public ICollection<AccountsInBrowserEntity>? Account_AccountsInBrowser { get; set; }
    public ICollection<AccountsInProjectEntity>? Account_AccountsInProject { get; set; }
}