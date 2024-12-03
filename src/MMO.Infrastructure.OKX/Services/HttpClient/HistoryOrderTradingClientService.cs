using CQRS.Contract.Share.DTO;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using MMO.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MMO.Infrastructure.OKX.Services;

public class HistoryOrderTradingClientService : IHistoryOrderTradingClientService
{
    private readonly HttpClient _httpClient;
    public HistoryOrderTradingClientService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<GetHistoryOrderTradingDTO>> GetHistoryOrderTradingAsync()
    {
        var response = await _httpClient.GetAsync("HistoryOrderTrading");
        response.EnsureSuccessStatusCode();

        var jsonResponse = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<IEnumerable<GetHistoryOrderTradingDTO>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
    }

    public async Task PostHistoryOrderTradingAsync(GetHistoryOrderTradingDTO getHistoryOrderTradingDTO)
    {
        var content = new StringContent(JsonSerializer.Serialize(getHistoryOrderTradingDTO), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("HistoryOrderTrading", content);
        response.EnsureSuccessStatusCode();
    }
}
