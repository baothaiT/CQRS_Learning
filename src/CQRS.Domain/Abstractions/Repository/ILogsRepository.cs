using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface ILogsRepository
    {
        Task<IEnumerable<LogsEntity>> GetAllLogsAsync();
        Task<LogsEntity> GetLogsByIdAsync(Guid id);
        Task AddLogsAsync(LogsEntity logs);
        Task UpdateLogsAsync(LogsEntity logs);
        Task DeleteLogsAsync(Guid id);
    }
}
