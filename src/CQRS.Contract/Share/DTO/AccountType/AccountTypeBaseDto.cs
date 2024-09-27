using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class AccountTypeBaseDto
{
    public AccountTypeEnum TypeName { get; set; }
    public bool IsDelete { get; set; }

    // Navigation Property
    public ICollection<GetAccountsDto> AccountType_Accounts { get; set; }
}
