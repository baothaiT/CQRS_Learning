using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class ProxyRepository : IProxyRepository
{
    private readonly AppDbContext _context;

    public ProxyRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProxyEntity>> GetAllProxyAsync()
    {
        return await _context.ProxyTable.ToListAsync();
    }

    public async Task<ProxyEntity> GetProxyByIdAsync(Guid id)
    {
        return await _context.ProxyTable.FindAsync(id);
    }

    public async Task AddProxyAsync(ProxyEntity proxy)
    {
        _context.ProxyTable.Add(proxy);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProxyAsync(ProxyEntity proxy)
    {
        _context.ProxyTable.Update(proxy);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProxyAsync(Guid id)
    {
        var proxy = await _context.ProxyTable.FindAsync(id);
        if (proxy != null)
        {
            _context.ProxyTable.Remove(proxy);
            await _context.SaveChangesAsync();
        }
    }
}
