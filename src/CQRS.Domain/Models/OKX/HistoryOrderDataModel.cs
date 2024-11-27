using System.Text.Json.Serialization;

namespace CQRS.Domain.Models.OKX;
public class HistoryOrderDataModel
{
    [JsonPropertyName("accFillSz")]
    public string AccFillSz { get; set; }

    [JsonPropertyName("avgPx")]
    public string AvgPx { get; set; }

    [JsonPropertyName("cTime")]
    public string CTime { get; set; }

    [JsonPropertyName("fee")]
    public string Fee { get; set; }

    [JsonPropertyName("feeCcy")]
    public string FeeCcy { get; set; }

    [JsonPropertyName("fillPx")]
    public string FillPx { get; set; }

    [JsonPropertyName("fillSz")]
    public string FillSz { get; set; }

    [JsonPropertyName("fillTime")]
    public string FillTime { get; set; }

    [JsonPropertyName("instId")]
    public string InstId { get; set; }

    [JsonPropertyName("instType")]
    public string InstType { get; set; }

    [JsonPropertyName("ordId")]
    public string OrdId { get; set; }

    [JsonPropertyName("ordType")]
    public string OrdType { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }
    [JsonPropertyName("sz")]
    public string Sz { get; set; }

    [JsonPropertyName("side")]
    public string Side { get; set; }

    [JsonPropertyName("tdMode")]
    public string TdMode { get; set; }

    [JsonPropertyName("tradeId")]
    public string TradeId { get; set; }
}