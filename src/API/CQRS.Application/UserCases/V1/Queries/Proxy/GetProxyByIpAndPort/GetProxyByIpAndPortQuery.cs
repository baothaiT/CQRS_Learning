using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIpAndPortQuery : IRequest<ProxyEntity>
{
    public string Ip { get; set; }
    public int Port { get; set; }
}
