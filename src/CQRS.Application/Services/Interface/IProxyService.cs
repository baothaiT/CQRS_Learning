using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.Services.Interface;

public interface IProxyService
{
    Task<GetProxyDto> IsProxyWorking(GetProxyDto proxy);
}
