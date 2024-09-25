using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class AccountType: BasedTable
{
    public AccountTypeEnum TypeName { get; set; }
    public bool IsDelete { get; set; }

    // Navigation Property
    public ICollection<Account> AccountType_Accounts { get; set; }
}
