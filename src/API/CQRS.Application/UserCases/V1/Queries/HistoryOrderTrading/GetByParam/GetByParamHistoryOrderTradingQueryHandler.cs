using AutoMapper;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;

public class GetByParamHistoryOrderTradingQueryHandler : IRequestHandler<GetByParamHistoryOrderTradingQuery, IEnumerable<GetHistoryOrderTradingDTO>>
{
    private readonly IHistoryOrderTradingRepository _historyOrderTradingRepository;
    private readonly IMapper _mapper;
    public GetByParamHistoryOrderTradingQueryHandler(
        IHistoryOrderTradingRepository historyOrderTradingRepository,
        IMapper mapper
        )
    {
        _historyOrderTradingRepository = historyOrderTradingRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetHistoryOrderTradingDTO>> Handle(GetByParamHistoryOrderTradingQuery request, CancellationToken cancellationToken)
    {
        List<GetHistoryOrderTradingDTO> getHistoryOrderTradingDTOs = new List<GetHistoryOrderTradingDTO>();
        var HistoryOrderTradingEntities = await _historyOrderTradingRepository.GetByParam(
            side: request.Side,
            startDatetime: request.startDatetime,
            endDatetime: request.endDatetime,
            symbol_Prefix: request.Symbol_Prefix,
            sysbol_Suffix: request.Symbol_Suffix
            );
        _mapper.Map(HistoryOrderTradingEntities, getHistoryOrderTradingDTOs);
        return getHistoryOrderTradingDTOs;
    }
}
