
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using MMO.Application.Abstractions;
using CQRS.Contract.Models.OKX;

namespace MMO.Infrastructure.OKX.Services;

public class OkxApiClient : IOkxApiClient
{
    private static readonly string BaseUrl = "https://www.okx.com";
    private string _ApiKey;
    private string _SecretKey;
    private string _Passphrase;
    public OkxApiClient(){}
    public Task Setup(string apiKey, string secretKey, string passphrase)
    {
        _ApiKey = apiKey;
        _SecretKey = secretKey;
        _Passphrase = passphrase;
        return Task.CompletedTask;
    }
    private string GenerateSignature(string timestamp, string method, string requestPath, string body = "")
    {
        string preHash = timestamp + method + requestPath + body;
        byte[] secretKeyBytes = Encoding.UTF8.GetBytes(_SecretKey);
        using (HMACSHA256 hmac = new HMACSHA256(secretKeyBytes))
        {
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(preHash));
            return Convert.ToBase64String(hashBytes);
        }
    }
    private async Task<string> SendRequestAsync(string method, string endpoint, string body = "")
    {
        using (HttpClient client = new HttpClient())
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            string signature = GenerateSignature(timestamp, method, endpoint, body);
            // Add required headers
            client.DefaultRequestHeaders.Add("OK-ACCESS-KEY", _ApiKey);
            client.DefaultRequestHeaders.Add("OK-ACCESS-SIGN", signature);
            client.DefaultRequestHeaders.Add("OK-ACCESS-TIMESTAMP", timestamp);
            client.DefaultRequestHeaders.Add("OK-ACCESS-PASSPHRASE", _Passphrase);
            HttpResponseMessage response;
            if (method == "GET")
            {
                response = await client.GetAsync(BaseUrl + endpoint);
            }
            else if (method == "POST")
            {
                HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");
                response = await client.PostAsync(BaseUrl + endpoint, content);
            }
            else
            {
                throw new InvalidOperationException("Unsupported HTTP method");
            }
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
    public async Task<dynamic> GetAccountBalanceAsync()
    {
        string endpoint = "/api/v5/account/balance";
        string response = await SendRequestAsync("GET", endpoint);
        return JsonConvert.DeserializeObject(response);
    }
    public async Task<RootModel> GetSpotOrderHistoryAsync(string queryParams)
    {
        string endpoint = $"/api/v5/trade/orders-history-archive{queryParams}";
        string response = await SendRequestAsync("GET", endpoint);
        return JsonConvert.DeserializeObject<RootModel>(response);
    }
    public Task<string> GenerateQueryParam(string ordType, string instType, string begin = "", string end = "")
    {
        string queryParams = $"?ordType={ordType}&instType={instType}";
        if(!string.IsNullOrEmpty(begin))
        {
            queryParams += $"&begin={begin}";
        }
        if(!string.IsNullOrEmpty(end))
        {
            queryParams += $"&end={end}";
        }
        return Task.FromResult(queryParams);
    }
}