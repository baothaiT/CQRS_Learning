using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO;

public class AccountsInBrowserBaseDto
{
    public Guid BrowserId { get; set; }
    public Guid AccountId { get; set; }
    public bool IsDelete { get; set; }
}
