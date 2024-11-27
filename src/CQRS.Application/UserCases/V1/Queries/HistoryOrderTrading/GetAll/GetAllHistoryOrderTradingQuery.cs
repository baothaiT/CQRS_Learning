using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;

public class GetAllHistoryOrderTradingQuery : IRequest<IEnumerable<HistoryOrderTradingEntity>>
{
}
