using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Application.UserCases.V1.Queries;

namespace CQRS.Application.UserCases.V1.Queries.Browser;

public class GetBrowserByIdQuery : IRequest<BrowserEntity>
{
    public Guid Id { get; set; }
}
