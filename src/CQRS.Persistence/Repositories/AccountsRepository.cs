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
using System.Security.Principal;
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
        var browsers = await (from accountInBrowser in _context.AccountsInBrowserTable
                              join account in _context.AccountTable
                                  on accountInBrowser.AccountId equals account.Id into accountGroup
                              from account in accountGroup.DefaultIfEmpty() // Simulates Right Join
                              join browser in _context.BrowserTable
                                  on accountInBrowser.BrowserId equals browser.Id into browserGroup
                              from browser in browserGroup.DefaultIfEmpty() // Left Join
                              where accountInBrowser.AccountId == IdAccount // Filter on the account ID
                              select new Account_Browser_DTO
                              {
                                  AccountId = account.Id,
                                  UserName = account != null ? account.UserName : null,
                                  Password = account != null ? account.Password : null,
                                  IsStatus = account.IsStatus,
                                  AccountCreateDate = account.CreateDate,
                                  BrowserId = browser.Id,
                                  Name = browser != null ? browser.Name : null,
                                  BrowserIsStatus = browser.IsStatus,
                                  XPosition = browser != null ? browser.XPosition : (int?)null,
                                  YPosition = browser != null ? browser.YPosition : (int?)null,
                                  WithScreeen = browser != null ? browser.WithScreeen : (int?)null,
                                  HightScreen = browser != null ? browser.HightScreen : (int?)null,
                                  UserAgent = browser != null ? browser.UserAgent : null,
                                  BrowserCreateDate = browser.CreateDate
                              }).ToListAsync();

        return browsers;
    }

    public async Task<List<Proxy_Account_Browser_DTO>> GetProxyAndBrowser_ByAccountId(Guid IdAccount)
    {
        var browsers = await (from accountInBrowser in _context.AccountsInBrowserTable
                              join account in _context.AccountTable
                                  on accountInBrowser.AccountId equals account.Id into accountGroup
                              from account in accountGroup.DefaultIfEmpty() // Simulates Right Join
                              join browser in _context.BrowserTable
                                  on accountInBrowser.BrowserId equals browser.Id into browserGroup
                              from browser in browserGroup.DefaultIfEmpty() // Left Join
                              where accountInBrowser.AccountId == IdAccount // Filter on the account ID
                              select new Account_Browser_DTO
                              {
                                  AccountId = account.Id,
                                  ProxyId = account.Proxy,
                                  UserName = account != null ? account.UserName : null,
                                  Password = account != null ? account.Password : null,
                                  IsStatus = account.IsStatus,
                                  AccountCreateDate = account.CreateDate,
                                  BrowserId = browser.Id,
                                  Name = browser != null ? browser.Name : null,
                                  BrowserIsStatus = browser.IsStatus,
                                  XPosition = browser != null ? browser.XPosition : (int?)null,
                                  YPosition = browser != null ? browser.YPosition : (int?)null,
                                  WithScreeen = browser != null ? browser.WithScreeen : (int?)null,
                                  HightScreen = browser != null ? browser.HightScreen : (int?)null,
                                  UserAgent = browser != null ? browser.UserAgent : null,
                                  BrowserCreateDate = browser.CreateDate
                              }).ToListAsync();

        if(browsers.Any())
        {
            var proxyResponse = from accountInBrowser in browsers
                                 join proxy in _context.ProxyTable
                                     on accountInBrowser.ProxyId equals proxy.Id into accountInBrowserGroup
                                 from proxy in accountInBrowserGroup.DefaultIfEmpty()  // This is the left join part
                                 select new Proxy_Account_Browser_DTO
                                 {
                                     // Account and browser properties
                                     AccountId = accountInBrowser.AccountId,
                                     UserName = accountInBrowser.UserName,
                                     Password = accountInBrowser.Password,
                                     IsStatus = accountInBrowser.IsStatus,
                                     AccountCreateDate = accountInBrowser.AccountCreateDate,

                                     BrowserId = accountInBrowser.BrowserId,
                                     Name = accountInBrowser.Name,
                                     BrowserIsStatus = accountInBrowser.IsStatus,
                                     XPosition = accountInBrowser.XPosition,
                                     YPosition = accountInBrowser.YPosition,
                                     WithScreeen = accountInBrowser.WithScreeen,
                                     HightScreen = accountInBrowser.HightScreen,
                                     UserAgent = accountInBrowser.UserAgent,
                                     BrowserCreateDate = accountInBrowser.BrowserCreateDate,

                                     // Proxy properties (with null checks since proxy can be null)
                                     ProxyId = proxy.Id,
                                     ProxyIp = proxy.Ip,
                                     ProxyPort = proxy.Port,
                                     ProxyUser = proxy.User,
                                     ProxyPassword = proxy.Password,
                                     ProxyIsStatus = proxy.IsStatus,
                                     ProxyCreateDate = proxy.CreateDate,
                                     ProxyUpdateDate = proxy.UpdateDate,
                                     ProxyCheckLiveDate = proxy.CheckLiveDate,
                                 };
            if(proxyResponse != null && proxyResponse.Any())
            {
                return proxyResponse.ToList();
            }
        }
        return new List<Proxy_Account_Browser_DTO>();
    }
}
