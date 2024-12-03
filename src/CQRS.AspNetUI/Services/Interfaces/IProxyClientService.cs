﻿using CQRS.Contract.Share.DTO;

namespace CQRS.AspNetUI.Services.Interfaces
{
    public interface IProxyClientService
    {
        Task<IEnumerable<GetProxyDto>> GetProxyAsync();
        Task<GetProxyDto> GetProxyByIdAsync(string id);
        Task CreateProxyAsync(CreateProxyDto proxy);
        Task UpdateProxyAsync(UpdateProxyDto proxy);
        Task DeleteProxyAsync(string id);
        Task<List<GetProxyDto>> IsProxyWorking(List<GetProxyDto> proxies);
        Task UpdateProxiesAsync(List<GetProxyDto> proxies);
    }
}