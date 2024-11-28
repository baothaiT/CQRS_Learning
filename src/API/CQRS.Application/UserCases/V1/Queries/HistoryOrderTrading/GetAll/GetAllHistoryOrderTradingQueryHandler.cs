using AutoMapper;
using CQRS.Application.Services.Interface;
using CQRS.Application.UserCases.V1.Queries.Browser;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Queries.HistoryOrderTrading;

public class GetAllHistoryOrderTradingQueryHandler : IRequestHandler<GetAllHistoryOrderTradingQuery, IEnumerable<GetHistoryOrderTradingDTO>>
{
    private readonly IHistoryOrderTradingRepository _historyOrderTradingRepository;
    private readonly IMapper _mapper;
    public GetAllHistoryOrderTradingQueryHandler(
        IHistoryOrderTradingRepository historyOrderTradingRepository,
        IMapper mapper
        )
    {
        _historyOrderTradingRepository = historyOrderTradingRepository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<GetHistoryOrderTradingDTO>> Handle(GetAllHistoryOrderTradingQuery request, CancellationToken cancellationToken)
    {
        List<GetHistoryOrderTradingDTO> getHistoryOrderTradingDTOs = new List<GetHistoryOrderTradingDTO>();
        var HistoryOrderTradingEntities = await _historyOrderTradingRepository.GetAllAsync();
        _mapper.Map(HistoryOrderTradingEntities, getHistoryOrderTradingDTOs);
        return getHistoryOrderTradingDTOs;
    }
}
