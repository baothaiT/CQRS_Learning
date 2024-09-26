using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IProxyRepository
    {
        Task<IEnumerable<ProxyEntity>> GetAllProxyAsync();
        Task<ProxyEntity> GetProxyByIdAsync(Guid id);
        Task AddProxyAsync(ProxyEntity proxy);
        Task UpdateProxyAsync(ProxyEntity proxy);
        Task DeleteProxyAsync(Guid id);
    }
}
