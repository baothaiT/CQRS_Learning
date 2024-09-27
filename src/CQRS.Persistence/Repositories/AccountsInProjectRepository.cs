using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class AccountsInProjectRepository : IRepository<AccountsInProjectEntity>
{
    private readonly AppDbContext _context;

    public AccountsInProjectRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<AccountsInProjectEntity>> GetAllAsync()
    {
        return await _context.AccountsInProjectTable.ToListAsync();
    }

    public async Task<AccountsInProjectEntity> GetByIdAsync(Guid id)
    {
        return await _context.AccountsInProjectTable.FindAsync(id);
    }

    public async Task AddAsync(AccountsInProjectEntity accountsInProject)
    {
        _context.AccountsInProjectTable.Add(accountsInProject);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AccountsInProjectEntity accountsInProject)
    {
        _context.AccountsInProjectTable.Update(accountsInProject);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var accountsInProject = await _context.AccountsInProjectTable.FindAsync(id);
        if (accountsInProject != null)
        {
            _context.AccountsInProjectTable.Remove(accountsInProject);
            await _context.SaveChangesAsync();
        }
    }
}
