using CQRS.Contract.Models.OKX;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using CQRS.Contract.Share.Enum;
using MMO.Application.Abstractions.CompareServices;
using System.Collections.Generic;
using System.Numerics;

namespace MMO.Infrastructure.OKX.Services.CompareServices;

public class BaseHistoryOrderTradingComparer : IBaseHistoryOrderTradingComparer
{
    public (bool isStatus, List<GetHistoryOrderTradingDTO> newHistoryOrderTradingList) GetNewList(List<GetHistoryOrderTradingDTO> listFromSQL, List<GetHistoryOrderTradingDTO> listFromDEXC)
    {
        if(listFromSQL.Count == 0)
        {
            return (true, listFromDEXC);
        }

        List<GetHistoryOrderTradingDTO> newHistoryOrderTrading = new List<GetHistoryOrderTradingDTO>();
        if (listFromDEXC.Count == 0)
            return (false, null);
        foreach (var itemDEXC in listFromDEXC)
        {
            bool result = true;
            foreach (var itemSQL in listFromSQL)
            {
                //True is existing, false is not exsting
                result = true;
                result = IsCompare(itemSQL.Symbol_Prefix, itemDEXC.Symbol_Prefix, result);
                result = IsCompare(itemSQL.Symbol_Suffix, itemDEXC.Symbol_Suffix, result);
                result = IsCompare(itemSQL.OrderTime.ToString(), itemDEXC.OrderTime.ToString(), result);
                result = IsCompare(itemSQL.Side, itemDEXC.Side, result);
                result = IsCompare(itemSQL.FillAndOrderPrice_Suffix, itemDEXC.FillAndOrderPrice_Suffix, result);
                result = IsCompare(itemSQL.FilledAndTotal_Suffix_Value, itemDEXC.FilledAndTotal_Suffix_Value, result);
                result = IsCompare(itemSQL.FilledAndOrderValue_Prefix, itemDEXC.FilledAndOrderValue_Prefix, result);
                result = IsCompare(itemSQL.Fee, itemDEXC.Fee, result);

                if (result)
                    break;
            }
            if(!result)
                newHistoryOrderTrading.Add(itemDEXC);
        }
        if (newHistoryOrderTrading.Count == 0)
            return (false, null);
        return (true, newHistoryOrderTrading);
    }
    public bool IsCompare(string itemSQL, string itemDEXC, bool isStatus)
    {
        if((isStatus) && (string.IsNullOrEmpty(itemSQL) && string.IsNullOrEmpty(itemDEXC)))
            return true;
        if ((isStatus) && (itemSQL.Equals(itemDEXC)))
            return true;
        return false;
    }

    public bool IsCompare(double itemSQL, double itemDEXC, bool isStatus)
    {
        if ((isStatus) && (itemSQL == null && itemDEXC == null))
            return true;
        if ((isStatus) && (itemSQL == itemDEXC))
            return true;
        return false;
    }

    public List<GetHistoryOrderTradingDTO> ConvertTo_GetHistoryOrderTradingDTO(List<HistoryOrderDataModel> historyOrderDataModels)
    {
        List<GetHistoryOrderTradingDTO> getHistoryOrderTradingDTOs = new List<GetHistoryOrderTradingDTO>();

        foreach (var itemHistoryOrderTrading in historyOrderDataModels)
        {
            GetHistoryOrderTradingDTO getHistoryOrderTradingDTO = new GetHistoryOrderTradingDTO();
            getHistoryOrderTradingDTO.Symbol_Prefix = itemHistoryOrderTrading.InstId.Split('-')[0];
            getHistoryOrderTradingDTO.Symbol_Suffix = itemHistoryOrderTrading.InstId.Split('-')[1];

            if (long.TryParse(itemHistoryOrderTrading.CTime, out long milliseconds))
            {
                // Convert milliseconds to DateTime
                DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).DateTime.AddHours(7); // Need to add + 7H
                getHistoryOrderTradingDTO.OrderTime = dateTime.ToLocalTime();
            }
            else
            {
                Console.WriteLine("Invalid millisecond timestamp string.");
            }
            getHistoryOrderTradingDTO.Side = itemHistoryOrderTrading.Side.ToUpper();
            getHistoryOrderTradingDTO.FillAndOrderPrice_Prefix = Convert.ToDouble(itemHistoryOrderTrading.FillPx);
            getHistoryOrderTradingDTO.FillAndOrderPrice_Suffix = Convert.ToDouble(itemHistoryOrderTrading.FillPx);
            getHistoryOrderTradingDTO.FilledAndTotal_Prefix_Value = itemHistoryOrderTrading.Sz;
            getHistoryOrderTradingDTO.FilledAndTotal_Prefix_Symbol = itemHistoryOrderTrading.FeeCcy;
            getHistoryOrderTradingDTO.FilledAndTotal_Suffix_Value = itemHistoryOrderTrading.Sz;
            getHistoryOrderTradingDTO.FilledAndTotal_Suffix_Symbol = itemHistoryOrderTrading.FeeCcy;
            getHistoryOrderTradingDTO.FilledAndOrderValue_Prefix = (Double.Parse(itemHistoryOrderTrading.FillPx) * Double.Parse(itemHistoryOrderTrading.Sz)).ToString(); 
            getHistoryOrderTradingDTO.Fee = Double.Parse(itemHistoryOrderTrading.Fee);

            getHistoryOrderTradingDTOs.Add(getHistoryOrderTradingDTO);
        }
        return getHistoryOrderTradingDTOs;
    }
}
