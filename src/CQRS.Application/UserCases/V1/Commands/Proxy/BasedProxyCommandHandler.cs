using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Domain.Abstractions.Repository;

namespace CQRS.Application.UserCases.V1.Commands.Proxy;

public class BasedProxyCommandHandler
{
    protected readonly IProxyRepository _proxyRepository;
    public BasedProxyCommandHandler(IProxyRepository proxyRepository)
    {
        _proxyRepository = proxyRepository;
    }
}
