using AutoMapper;
using CQRS.Contract.Share.DTO._JoinDTO;
using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class AccountsRepository : IAccountRepository<AccountEntity>
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public AccountsRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AccountEntity>> GetAllAsync()
    {
        return await _context.AccountTable.ToListAsync();
    }

    public async Task<AccountEntity> GetByIdAsync(Guid id)
    {
        return await _context.AccountTable.FindAsync(id);
    }

    public async Task AddAsync(AccountEntity account)
    {
        _context.AccountTable.Add(account);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(AccountEntity account)
    {
        var found = await _context.AccountTable.FindAsync(account.Id);

        if (found != null)
        {
            _mapper.Map(account, found);
            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        var browser = await _context.AccountTable.FindAsync(id);
        if (browser != null)
        {
            _context.AccountTable.Remove(browser);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<List<Account_Browser_DTO>> GetBrowserByAccountId(Guid IdAccount)
    {
        var browsers = await (from account in _context.AccountTable
                             join accountInBrowser in _context.AccountsInBrowserTable on account.Id equals accountInBrowser.AccountId
                             join browser in _context.BrowserTable on accountInBrowser.BrowserId equals browser.Id
                             where account.Id == IdAccount
                             select new Account_Browser_DTO
                             {
                                 AccountId = account.Id,
                                 UserName = account.UserName,
                                 Password = account.Password,
                                 IsStatus = account.IsStatus,
                                 AccountCreateDate = account.CreateDate,
                                 BrowserId = browser.Id,
                                 Name = browser.Name,
                                 BrowserIsStatus = browser.IsStatus,
                                 XPosition = browser.XPosition,
                                 YPosition = browser.YPosition,
                                 WithScreeen = browser.WithScreeen,
                                 HightScreen = browser.HightScreen,
                                 UserAgent = browser.UserAgent,
                                 BrowserCreateDate = browser.CreateDate
                             }).ToListAsync();

        return browsers;
    }
}
