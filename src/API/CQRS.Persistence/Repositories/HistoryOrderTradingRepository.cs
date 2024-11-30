using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

    public async Task<List<HistoryOrderTradingEntity>> GetByParam(
        string? side,
        DateTime? startDatetime,
        DateTime? endDatetime,
        string? symbol_Prefix,
        string? symbol_Suffix // Fixed typo here
    )
    {
        // Start building the query
        var query = _context.HistoryOrderTradingTable.AsQueryable();

        // Dynamically add conditions
        if (!string.IsNullOrEmpty(side))
            query = query.Where(h => h.Side == side);

        if (startDatetime.HasValue || endDatetime.HasValue)
        {
            if (startDatetime.HasValue && endDatetime.HasValue)
                query = query.Where(h => h.OrderTime >= startDatetime && h.OrderTime <= endDatetime);
            else if (startDatetime.HasValue)
                query = query.Where(h => h.OrderTime >= startDatetime);
            else if (endDatetime.HasValue)
                query = query.Where(h => h.OrderTime <= endDatetime);
        }

        if (!string.IsNullOrEmpty(symbol_Prefix))
            query = query.Where(h => h.Symbol_Prefix == symbol_Prefix);

        if (!string.IsNullOrEmpty(symbol_Suffix))
            query = query.Where(h => h.Symbol_Suffix == symbol_Suffix);

        // Order and execute the query
        return await query
            .OrderByDescending(h => h.OrderTime)
            .ToListAsync();
    }
}
