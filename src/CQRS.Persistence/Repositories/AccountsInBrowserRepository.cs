using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class BrowserRepository : IRepository<BrowserEntity>
{
    private readonly AppDbContext _context;

    public BrowserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BrowserEntity>> GetAllAsync()
    {
        return await _context.BrowserTable.ToListAsync();
    }

    public async Task<BrowserEntity> GetByIdAsync(Guid id)
    {
        return await _context.BrowserTable.FindAsync(id);
    }

    public async Task AddAsync(BrowserEntity browser)
    {
        _context.BrowserTable.Add(browser);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(BrowserEntity browser)
    {
        _context.BrowserTable.Update(browser);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var browser = await _context.BrowserTable.FindAsync(id);
        if (browser != null)
        {
            _context.BrowserTable.Remove(browser);
            await _context.SaveChangesAsync();
        }
    }
}
