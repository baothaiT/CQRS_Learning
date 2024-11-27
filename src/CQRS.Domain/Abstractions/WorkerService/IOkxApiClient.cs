

using CQRS.Domain.Models.OKX;

namespace CQRS.Domain.Abstractions.WorkerService;

public interface IOkxApiClient
{
    public Task Setup(string apiKey, string secretKey, string passphrase);
    public Task<dynamic> GetAccountBalanceAsync();
    public Task<RootModel> GetSpotOrderHistoryAsync(string queryParams);
    public Task<string> GenerateQueryParam(string ordType, string instType, string begin = "", string end = "");
}
