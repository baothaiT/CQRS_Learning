using CQRS.Contract.Models.OKX;
using MMO.Application.Abstractions;
using Newtonsoft.Json;


namespace MMO.Infrastructure.OKX.Services;

public class InvokeOKXService: IInvokeOKXService
{
    private string _apiKey;
    private string _secretKey;
    private string _passphrase;
    private readonly IOkxApiClient _okxApiClient;
    public InvokeOKXService(IOkxApiClient okxApiClient)
    {
        _okxApiClient = okxApiClient;
    }
   
    public void Setup(string apiKey, string secretKey, string passphrase)
    {
        _apiKey = apiKey;
        _secretKey = secretKey;
        _passphrase = passphrase;
        _okxApiClient.Setup(_apiKey, _secretKey, _passphrase);
    }

    private (long startTimestampMillis, long endTimestampMillis) GetStartAndEndTimestamp()
    {
        DateTime endDateTime = DateTime.Now;
        DateTime startDateTime = endDateTime.AddDays(-1);

        // Convert to UTC first to avoid timezone issues
        DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        // Convert startDateTime to timestamp in milliseconds
        long startTimestampMillis = (long)(startDateTime.ToUniversalTime() - unixEpoch).TotalMilliseconds;
        long endTimestampMillis = (long)(endDateTime.ToUniversalTime() - unixEpoch).TotalMilliseconds;
        return (startTimestampMillis, endTimestampMillis);
    }

    public async Task<RootModel> GetOrderHistory()
    {
        var result = GetStartAndEndTimestamp();
        var queryParam = await _okxApiClient.GenerateQueryParam(
            ordType: "limit",
            instType: "SPOT",
            begin: result.startTimestampMillis.ToString(),
            end: result.endTimestampMillis.ToString()
        );
        return await _okxApiClient.GetSpotOrderHistoryAsync(queryParam);
    }
}
