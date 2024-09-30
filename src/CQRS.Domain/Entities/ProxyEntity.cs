using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CQRS.Contract.Share.Enum;

namespace CQRS.Domain.Entities;

public class ProxyEntity: BasedTableEntity
{
    public string Ip { get; set; }
    public int Port { get; set; }
    public string User { get; set; }
    public string Password { get; set; }
    public DateTime? CreateDate { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? CheckLiveDate { get; set; }
    public ProxyStatusEnum? IsStatus { get; set; }
    public ICollection<AccountEntity>? Proxy_Account { get; set; }
}
