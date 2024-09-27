//using CQRS.Domain.Abstractions.Repository;
//using CQRS.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CQRS.Persistence.Repositories;

//public class LogsRepository : IRepository<LogsEntity>
//{
//    private readonly AppDbContext _context;

//    public LogsRepository(AppDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IEnumerable<LogsEntity>> GetAllAsync()
//    {
//        return await _context.LogsTable.ToListAsync();
//    }

//    public async Task<LogsEntity> GetByIdAsync(Guid id)
//    {
//        return await _context.LogsTable.FindAsync(id);
//    }

//    public async Task AddAsync(LogsEntity logs)
//    {
//        _context.LogsTable.Add(logs);
//        await _context.SaveChangesAsync();
//    }

//    public async Task UpdateAsync(LogsEntity logs)
//    {
//        _context.LogsTable.Update(logs);
//        await _context.SaveChangesAsync();
//    }

//    public async Task DeleteAsync(Guid id)
//    {
//        var logs = await _context.LogsTable.FindAsync(id);
//        if (logs != null)
//        {
//            _context.LogsTable.Remove(logs);
//            await _context.SaveChangesAsync();
//        }
//    }
//}
