using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.Account;

public class GetAllAccountQuery : IRequest<IEnumerable<AccountEntity>>
{
    public Guid Id { get; set; }
}
