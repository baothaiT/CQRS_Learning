using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class ProxyRepository : IRepository<ProxyEntity>
{
    private readonly AppDbContext _context;

    public ProxyRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProxyEntity>> GetAllAsync()
    {
        return await _context.Proxy.ToListAsync();
    }

    public async Task<ProxyEntity> GetByIdAsync(Guid id)
    {
        return await _context.Proxy.FindAsync(id);
    }

    public async Task AddAsync(ProxyEntity proxy)
    {
        _context.Proxy.Add(proxy);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ProxyEntity proxy)
    {
        _context.Proxy.Update(proxy);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var proxy = await _context.Proxy.FindAsync(id);
        if (proxy != null)
        {
            _context.Proxy.Remove(proxy);
            await _context.SaveChangesAsync();
        }
    }
}
