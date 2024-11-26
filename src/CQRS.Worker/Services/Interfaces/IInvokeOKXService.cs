using CQRS.Domain.Abstractions.Repository;
using Newtonsoft.Json;

namespace CQRS.Worker.Services.Interfaces;

public interface IInvokeOKXService
{
    Task GetOrderHistory();
}