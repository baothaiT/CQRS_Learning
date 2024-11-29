using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class HistoryOrderTradingRepository : IHistoryOrderTradingRepository
{
    private readonly AppDbContext _context;
    public HistoryOrderTradingRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Boolean> ChangeResolve(Guid Id)
    {
        var response = await GetById(Id);
        if (response != null)
        {
            response.IsResovlve = !response.IsResovlve;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

    public async Task Create(HistoryOrderTradingEntity historyOrderTradingEntity)
    {
        await _context.HistoryOrderTradingTable.AddAsync(historyOrderTradingEntity);
        await _context.SaveChangesAsync();
    }

    public async Task<List<HistoryOrderTradingEntity>> GetAllAsync()
    {
        return await _context.HistoryOrderTradingTable.OrderByDescending(x => x.OrderTime).ToListAsync();
    }

    public async Task<HistoryOrderTradingEntity> GetById(Guid Id)
    {
        return await _context.HistoryOrderTradingTable.FirstOrDefaultAsync(x => x.Id == Id);
    }
}
