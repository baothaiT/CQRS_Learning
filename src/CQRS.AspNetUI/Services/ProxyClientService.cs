using CQRS.AspNetUI.Services.Interfaces;
using CQRS.Contract.Share.DTO;
using System.Text.Json;
using System.Text;
using Microsoft.DotNet.MSIdentity.Shared;

namespace CQRS.AspNetUI.Services
{
    public class ProxyClientService : IProxyClientService
    {
        private readonly HttpClient _httpClient;

        public ProxyClientService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GetProxyDto>> GetProxyAsync()
        {
            var response = await _httpClient.GetAsync("Proxy");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<GetProxyDto>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<GetProxyDto> GetProxyByIdAsync(string id)
        {
            var response = await _httpClient.GetAsync($"Proxy/{id}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<GetProxyDto>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task CreateProxyAsync(CreateProxyDto proxy)
        {
            var content = new StringContent(JsonSerializer.Serialize(proxy), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Proxy", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateProxyAsync(UpdateProxyDto proxy)
        {
            var content = new StringContent(JsonSerializer.Serialize(proxy), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"Proxy/{proxy.Id}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteProxyAsync(string id)
        {
            var response = await _httpClient.DeleteAsync($"Proxy/{id}");
            response.EnsureSuccessStatusCode();
        }

        public async Task<List<GetProxyDto>> IsProxyWorking(List<GetProxyDto> proxies)
        {
            var content = new StringContent(JsonSerializer.Serialize(proxies), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Proxy/CheckProxies", content);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<GetProxyDto>>(jsonResponse, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateProxiesAsync(List<GetProxyDto> proxies)
        {
            var content = new StringContent(JsonSerializer.Serialize(proxies), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Proxy/UpdateProxies", content);
            response.EnsureSuccessStatusCode();
        }
    }
}
