using System.Text.Json.Serialization;

namespace CQRS.Domain.Models.OKX;

public class RootModel
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("data")]
    public List<HistoryOrderDataModel> Data { get; set; }
}