using AutoMapper;
using CQRS.Domain.Abstractions.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.HistoryOrderTrading;

public class ChangeIsRolveCommandHandler : IRequestHandler<ChangeIsRolveCommand, Boolean>
{
    private readonly IHistoryOrderTradingRepository _historyOrderTradingRepository;
    public ChangeIsRolveCommandHandler(IHistoryOrderTradingRepository historyOrderTradingRepository)
    {
        _historyOrderTradingRepository = historyOrderTradingRepository;
    }
    public async Task<bool> Handle(ChangeIsRolveCommand request, CancellationToken cancellationToken)
    {
        return await _historyOrderTradingRepository.ChangeResolve(request.Id);
    }
}
