using CQRS.Contract.Models.OKX;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.Application.Abstractions.CompareServices;

public interface IBaseHistoryOrderTradingComparer
{
    (bool isStatus, List<GetHistoryOrderTradingDTO> newHistoryOrderTradingList) GetNewList(List<GetHistoryOrderTradingDTO> listFromSQL, List<GetHistoryOrderTradingDTO> listFromDEXC);
    List<GetHistoryOrderTradingDTO> ConvertTo_GetHistoryOrderTradingDTO(List<HistoryOrderDataModel> historyOrderDataModels);
}
