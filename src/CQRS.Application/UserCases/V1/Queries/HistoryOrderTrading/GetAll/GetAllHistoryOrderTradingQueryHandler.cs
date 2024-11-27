using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;

public class GetAllHistoryOrderTradingQueryHandler : IRequestHandler<GetAllHistoryOrderTradingQuery, IEnumerable<HistoryOrderTradingEntity>>
{
    private readonly IHistoryOrderTradingRepository _historyOrderTradingRepository;
    public GetAllHistoryOrderTradingQueryHandler(IHistoryOrderTradingRepository historyOrderTradingRepository)
    {
        _historyOrderTradingRepository = historyOrderTradingRepository;
    }
    public async Task<IEnumerable<HistoryOrderTradingEntity>> Handle(GetAllHistoryOrderTradingQuery request, CancellationToken cancellationToken)
    {
        return await _historyOrderTradingRepository.GetAllAsync();
    }
}
