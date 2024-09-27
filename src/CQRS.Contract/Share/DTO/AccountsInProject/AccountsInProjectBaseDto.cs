using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class AccountsInProjectBaseDto
{
    public Guid AccountId { get; set; }
    public GetAccountsDto AccountsInProject_Account { get; set; }

    public Guid ProjectId { get; set; }
    public GetProjectDto AccountsInProject_Project { get; set; }

    public bool IsDelete { get; set; }
}
