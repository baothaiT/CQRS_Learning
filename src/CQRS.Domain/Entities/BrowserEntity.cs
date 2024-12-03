using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class BrowserEntity: BasedTableEntity
{
    public string Name { get; set; }
    public string Path { get; set; }
    public bool IsStatus { get; set; }

    public decimal? XPosition { get; set; }
    public decimal? YPosition { get; set; }
    public decimal? WithScreeen { get; set; }
    public decimal? HightScreen { get; set; }
    public decimal? Scale { get; set; }
    public string? UserAgent { get; set; }

    public DateTime CreateDate { get; set; }

    public ICollection<AccountsInBrowserEntity> Browser_AccountsInBrowser { get; set; }
}
