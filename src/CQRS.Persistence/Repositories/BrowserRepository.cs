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

    public async Task AddAsync(BrowserEntity browserEntity)
    {
        _context.BrowserTable.Add(browserEntity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(BrowserEntity browserEntity)
    {
        _context.BrowserTable.Update(browserEntity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var accountsInProject = await _context.BrowserTable.FindAsync(id);
        if (accountsInProject != null)
        {
            _context.BrowserTable.Remove(accountsInProject);
            await _context.SaveChangesAsync();
        }
    }
}
