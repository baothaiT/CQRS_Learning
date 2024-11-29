using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using CQRS.Contract.Share.Enum;

namespace CQRS.Contract.Share.DTO.HistoryOrderTrading;

public class GetHistoryOrderTradingDTO : BaseHistoryOrderTradingDTO
{
    public Guid Id { get; set; }

    public object this[string key]
    {
        get
        {
            switch (key)
            {
                case nameof(HistoryOrderTradingCompareNameEnum.Symbol_Prefix):
                    return Symbol_Prefix;
                case nameof(HistoryOrderTradingCompareNameEnum.Symbol_Suffix):
                    return Symbol_Suffix;
                case nameof(HistoryOrderTradingCompareNameEnum.OrderTime):
                    return OrderTime;
                case nameof(HistoryOrderTradingCompareNameEnum.Side):
                    return Side;
                case nameof(HistoryOrderTradingCompareNameEnum.FillAndOrderPrice_Suffix):
                    return FillAndOrderPrice_Suffix;
                case nameof(HistoryOrderTradingCompareNameEnum.FilledAndTotal_Suffix_Value):
                    return FilledAndTotal_Suffix_Value;
                case nameof(HistoryOrderTradingCompareNameEnum.FilledAndOrderValue_Prefix):
                    return FilledAndOrderValue_Prefix;
                case nameof(HistoryOrderTradingCompareNameEnum.Fee):
                    return Fee;
                default:
                    throw new KeyNotFoundException($"Key '{key}' not found");
            }
        }
        //set
        //{
        //    switch (key)
        //    {
        //        case "id":
        //            Id = Convert.ToInt32(value);
        //            break;
        //        case "name":
        //            Name = value.ToString();
        //            break;
        //        case "date":
        //            Date = Convert.ToDateTime(value);
        //            break;
        //        default:
        //            throw new KeyNotFoundException($"Key '{key}' not found");
        //    }
        //}
    }
}
