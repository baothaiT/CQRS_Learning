//using AutoMapper;
//using CQRS.Domain.Abstractions.Repository;
//using CQRS.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CQRS.Persistence.Repositories;

//public class AccountsInBrowserRepository : IRepository<AccountsInBrowserEntity>
//{
//    private readonly AppDbContext _context;
//    private readonly IMapper _mapper;
//    public AccountsInBrowserRepository(AppDbContext context, IMapper mapper)
//    {
//        _context = context;
//        _mapper = mapper;
//    }

//    public async Task<IEnumerable<AccountsInBrowserEntity>> GetAllAsync()
//    {
//        return await _context.AccountsInBrowserTable.ToListAsync();
//    }

//    public async Task<AccountsInBrowserEntity> GetByIdAsync(Guid id)
//    {
//        return await _context.AccountsInBrowserTable.FindAsync(id);
//    }

//    public async Task AddAsync(AccountsInBrowserEntity accountsInBrowser)
//    {
//        _context.AccountsInBrowserTable.Add(accountsInBrowser);
//        await _context.SaveChangesAsync();
//    }

//    public async Task UpdateAsync(AccountsInBrowserEntity accountsInBrowser)
//    {
//        _context.AccountsInBrowserTable.Update(accountsInBrowser);
//        await _context.SaveChangesAsync();
//    }

//    public async Task DeleteAsync(Guid id)
//    {
//        var accountsInBrowser = await _context.AccountsInBrowserTable.FindAsync(id);
//        if (accountsInBrowser != null)
//        {
//            _context.AccountsInBrowserTable.Remove(accountsInBrowser);
//            await _context.SaveChangesAsync();
//        }
//    }
//}
