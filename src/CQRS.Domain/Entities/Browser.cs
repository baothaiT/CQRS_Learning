using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class Browser: BasedTable
{
    public string Name { get; set; }
    public string Path { get; set; }
    public bool IsStatus { get; set; }

    public DateTime CreateDate { get; set; }

    public ICollection<AccountsInBrowser> Browser_AccountsInBrowser { get; set; }
}
