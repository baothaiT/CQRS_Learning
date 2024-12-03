using CQRS.Contract.Models.OKX;
using MMO.Application.Abstractions;
using Newtonsoft.Json;


namespace MMO.Infrastructure.OKX.Services;

public class InvokeOKXService: IInvokeOKXService
{
    private readonly string _apiKey;
    private readonly string _secretKey;
    private readonly string _passphrase;
    private readonly IOkxApiClient _okxApiClient;
    public InvokeOKXService(IOkxApiClient okxApiClient)
    {
        _apiKey = "ee436608-591d-400a-bf5f-f21a74df31d8";
        _secretKey = "FFD6793A773DD8D3A30426F6C34A7547";
        _passphrase = "0VfQFsA3e9gP3Ffd5eYz!";
        _okxApiClient = okxApiClient;
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
