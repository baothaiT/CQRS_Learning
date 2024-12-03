using CQRS.Contract.Share.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO.HistoryOrderTrading;

public class GetByParamHistoryOrderTradingDTO
{
    public string? Side { get; set; } = string.Empty;
    public DateTime? startDatetime { get; set; }
    public DateTime? endDatetime { get; set; }
    public string? Symbol_Prefix { get; set; } = string.Empty;
    public string? Symbol_Suffix { get; set; } = string.Empty;
    public IsResovlveEnum IsResovlve { get; set; }
    public HistoryOrderTradingSortEnum SortName { get; set; }
}
