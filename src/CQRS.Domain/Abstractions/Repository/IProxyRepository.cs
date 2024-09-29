using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IProxyRepository<T> : IWriteRepository<T>, IReadRepository<T>
    {
        Task<ProxyEntity> GetProxyByIpAndPortAsync(string Ip, int Port);
    }
}
