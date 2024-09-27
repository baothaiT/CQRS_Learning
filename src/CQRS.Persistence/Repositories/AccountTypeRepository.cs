//using CQRS.Domain.Abstractions.Repository;
//using CQRS.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CQRS.Persistence.Repositories;

//public class AccountTypeRepository : IRepository<AccountTypeEntity>
//{
//    private readonly AppDbContext _context;

//    public AccountTypeRepository(AppDbContext context)
//    {
//        _context = context;
//    }

//    public async Task<IEnumerable<AccountTypeEntity>> GetAllAsync()
//    {
//        return await _context.AccountTypeTable.ToListAsync();
//    }

//    public async Task<AccountTypeEntity> GetByIdAsync(Guid id)
//    {
//        return await _context.AccountTypeTable.FindAsync(id);
//    }

//    public async Task AddAsync(AccountTypeEntity accountType)
//    {
//        _context.AccountTypeTable.Add(accountType);
//        await _context.SaveChangesAsync();
//    }

//    public async Task UpdateAsync(AccountTypeEntity accountType)
//    {
//        _context.AccountTypeTable.Update(accountType);
//        await _context.SaveChangesAsync();
//    }

//    public async Task DeleteAsync(Guid id)
//    {
//        var accountType = await _context.AccountTypeTable.FindAsync(id);
//        if (accountType != null)
//        {
//            _context.AccountTypeTable.Remove(accountType);
//            await _context.SaveChangesAsync();
//        }
//    }
//}
