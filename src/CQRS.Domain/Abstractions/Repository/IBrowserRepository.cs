using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IBrowserRepository
    {
        Task<IEnumerable<BrowserEntity>> GetAllBrowserAsync();
        Task<BrowserEntity> GetBrowserByIdAsync(Guid id);
        Task AddBrowserAsync(BrowserEntity browser);
        Task UpdateBrowserAsync(BrowserEntity browser);
        Task DeleteBrowserAsync(Guid id);
    }
}
