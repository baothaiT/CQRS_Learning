using CQRS.Contract.Models.OKX;

namespace MMO.Application.Abstractions;

public interface IInvokeOKXService
{
    Task<RootModel> GetOrderHistory();
}
