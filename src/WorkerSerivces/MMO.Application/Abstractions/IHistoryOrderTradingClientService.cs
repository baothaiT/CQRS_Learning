using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.Application.Abstractions;

public interface IHistoryOrderTradingClientService
{
    Task<IEnumerable<GetHistoryOrderTradingDTO>> GetHistoryOrderTradingAsync();
    Task PostHistoryOrderTradingAsync(GetHistoryOrderTradingDTO getHistoryOrderTradingDTO);
}
