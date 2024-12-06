using CQRS.Contract.Models.OKX;

namespace MMO.Application.Abstractions;

public interface IInvokeOKXService
{
    void Setup(string apiKey, string secretKey, string passphrase);
    Task<RootModel> GetOrderHistory();
}
