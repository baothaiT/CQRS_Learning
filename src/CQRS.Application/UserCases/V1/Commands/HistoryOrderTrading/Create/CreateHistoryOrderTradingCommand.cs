using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Application.UserCases.V1.Commands.HistoryOrderTrading;

public class CreateHistoryOrderTradingCommand : CreateHistoryOrderTradingDTO, IRequest<HistoryOrderTradingEntity>
{
}
