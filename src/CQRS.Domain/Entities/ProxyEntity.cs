using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CQRS.Domain.Entities;

public class ProxyEntity: BasedTableEntity
{
    public string Ip { get; set; }
    public int Port { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public ICollection<AccountEntity>? Logs_Account { get; set; }
}
