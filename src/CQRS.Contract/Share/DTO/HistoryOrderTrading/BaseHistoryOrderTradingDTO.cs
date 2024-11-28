namespace CQRS.Contract.Share.DTO.HistoryOrderTrading;

public class BaseHistoryOrderTradingDTO
{
    public string Symbol_Prefix { get; set; }
    public string Symbol_Suffix { get; set; }
    public DateTime OrderTime { get; set; }
    public string Side { get; set; }

    public string FillAndOrderPrice_Prefix { get; set; }
    public string FillAndOrderPrice_Suffix { get; set; }
    public string FilledAndTotal_Prefix_Value { get; set; }
    public string FilledAndTotal_Prefix_Symbol { get; set; }

    public string FilledAndTotal_Suffix_Value { get; set; }
    public string FilledAndTotal_Suffix_Symbol { get; set; }
    public string FilledAndOrderValue_Prefix { get; set; }
    public double Fee { get; set; }

    public Boolean IsResovlve { get; set; }
}
