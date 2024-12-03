using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;

namespace CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;

public class GetAllHistoryOrderTradingQuery : IRequest<IEnumerable<GetHistoryOrderTradingDTO>>
{
}
