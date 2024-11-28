using CQRS.Contract.Enums;

namespace CQRS.Contract.Models.OKX;

public class OKXExcelModel
{
    public string Symbol { get; set; } = string.Empty;
    public DateTime OrderTime { get; set; }
    public TypeSideEnum Side { get; set; }
    public string FillAndOrderPrice { get; set; } = string.Empty;
    public string FilledAndTotal { get; set; } = string.Empty;
    public string FilledAndOrderValue { get; set; } = string.Empty;
    public string Fee { get; set; } = string.Empty;
    public string Capital { get; set; } = string.Empty;
    public string? TPAndSL { get; set; }

    public SymbolCoinEnums Symbol_Prefix { get; set; }
    public SymbolCoinEnums Symbol_Suffix { get; set; }

    public double FillAndOrderPrice_Prefix { get; set; }
    public double FillAndOrderPrice_Suffix { get; set; }

    public string FilledAndTotal_Prefix { get; set; } = string.Empty;
    public string FilledAndTotal_Prefix_Value { get; set; } = string.Empty;
    public string FilledAndTotal_Prefix_Symbol { get; set; } = string.Empty;

    public string FilledAndTotal_Suffix { get; set; } = string.Empty;
    public double FilledAndTotal_Suffix_Value { get; set; }
    public string FilledAndTotal_Suffix_Symbol { get; set; } = string.Empty;

    public double FilledAndOrderValue_Prefix { get; set; }
    public string FilledAndOrderValue_Suffix { get; set; } = string.Empty;

    public string Fee_Value { get; set; } = string.Empty;
    public string Fee_Symbol { get; set; } = string.Empty;

    public string TP { get; set; } = string.Empty;
    public string SL { get; set; } = string.Empty;

    public string Profit { get; set; } = string.Empty;
    public string Profit_Value { get; set; } = string.Empty;
    public string Profit_Symbol { get; set; } = string.Empty;


    public override string ToString()
    {
        return $"{Symbol}, {OrderTime}, {Side}, {FillAndOrderPrice}, {FilledAndTotal}, {FilledAndOrderValue}, {TPAndSL}";
    }
}