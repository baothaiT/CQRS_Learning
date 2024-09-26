using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class AccountsInProjectEntity
{
    public Guid AccountId { get; set; }
    public AccountEntity AccountsInProject_Account { get; set; }

    public Guid ProjectId { get; set; }
    public ProjectEntity AccountsInProject_Project { get; set; }

    public bool IsDelete { get; set; }
}
