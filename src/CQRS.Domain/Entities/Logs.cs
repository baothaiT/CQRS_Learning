using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Logs: BasedTable
{
    public int Code { get; set; }
    public string Message { get; set; }
    public DateTime CreateDate { get; set; }


    // Navigation Property
    public Guid User { get; set; } // FK to Account
    public Account Logs_Account { get; set; }
}
