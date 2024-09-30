using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.DTO._JoinDTO;
using MediatR;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetProxyAndBrowserByAccountIdQuery : IRequest<List<Proxy_Account_Browser_DTO>>
{
    public Guid AccountId { get; set; }
}
