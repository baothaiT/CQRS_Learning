using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IWriteRepository<T>
    {
        Task AddAsync(T request);
        Task UpdateAsync(T request);
        Task DeleteAsync(Guid id);
    }
}
