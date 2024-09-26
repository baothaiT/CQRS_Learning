using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Proxy;

public class GetProxyByIdQuery : IRequest<ProxyEntity>
{
    public Guid Id { get; set; }
}
