using AutoMapper;
using CQRS.Application.UserCases.V1.Commands.Account;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.HistoryOrderTrading;

public class CreateHistoryOrderTradingCommandHandler : IRequestHandler<CreateHistoryOrderTradingCommand, HistoryOrderTradingEntity>
{
    private readonly IHistoryOrderTradingRepository _historyOrderTradingRepository;
    private readonly IMapper _mapper;
    public CreateHistoryOrderTradingCommandHandler(IHistoryOrderTradingRepository historyOrderTradingRepository, IMapper mapper)
    {
        _historyOrderTradingRepository = historyOrderTradingRepository;
        _mapper = mapper;
    }
    public async Task<HistoryOrderTradingEntity> Handle(CreateHistoryOrderTradingCommand request, CancellationToken cancellationToken)
    {
        HistoryOrderTradingEntity historyOrderTradingEntity = new HistoryOrderTradingEntity();
        _mapper.Map(request, historyOrderTradingEntity);
        historyOrderTradingEntity.Id = Guid.NewGuid();
        await _historyOrderTradingRepository.Create(historyOrderTradingEntity);
        return historyOrderTradingEntity;
    }
}
