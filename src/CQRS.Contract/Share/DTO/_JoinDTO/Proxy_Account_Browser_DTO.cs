using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO._JoinDTO;

public class Proxy_Account_Browser_DTO: Account_Browser_DTO
{
    public Guid ProxyId { get; set; }
    public string ProxyIp { get; set; }
    public int ProxyPort { get; set; }
    public string ProxyUser { get; set; }
    public string ProxyPassword { get; set; }
    public DateTime? ProxyCreateDate { get; set; }
    public DateTime? ProxyUpdateDate { get; set; }
    public DateTime? ProxyCheckLiveDate { get; set; }
    public ProxyStatusEnum? ProxyIsStatus { get; set; }
}
