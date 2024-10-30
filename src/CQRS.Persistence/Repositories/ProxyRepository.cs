using AutoMapper;
using CQRS.Contract.Share.Services;
using CQRS.Domain.Abstractions.Repository;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Persistence.Repositories;

public class ProxyRepository : IProxyRepository<ProxyEntity>
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    

    public ProxyRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProxyEntity>> GetAllAsync()
    {
        return await _context.ProxyTable.Where(x => x.IsDelete != true).ToListAsync();
    }

    public async Task<ProxyEntity> GetByIdAsync(Guid id)
    {
        return await _context.ProxyTable?.FirstOrDefaultAsync(x=> x.Id == id && x.IsDelete != true);
    }

    public async Task AddAsync(ProxyEntity proxy)
    {
        _context.ProxyTable.Add(proxy);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(ProxyEntity proxy)
    {
        var found = await _context.ProxyTable?.FirstOrDefaultAsync(x=> x.Id == proxy.Id && x.IsDelete != true);

        if (found != null)
        {
            _mapper.Map(proxy, found);
            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        var proxy = await _context.ProxyTable?.FirstOrDefaultAsync(x => x.Id == id && x.IsDelete != true);
        if (proxy != null)
        {
            _context.ProxyTable.Remove(proxy);
            await _context.SaveChangesAsync();
        }
    }


    public async Task DeleteAllAsync()
    {
        var proxy = await _context.ProxyTable.ToListAsync();
        if (proxy.Any())
        {
            _context.ProxyTable.RemoveRange(proxy);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<ProxyEntity> GetProxyByIpAndPortAsync(string Ip, int Port)
    {
        return await _context.ProxyTable.FirstOrDefaultAsync(x => x.Ip == Ip && x.Port == Port);
    }
}
