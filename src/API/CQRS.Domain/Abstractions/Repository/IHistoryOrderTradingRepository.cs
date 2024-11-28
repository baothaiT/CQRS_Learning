using CQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository;

public interface IHistoryOrderTradingRepository
{
    public Task<List<HistoryOrderTradingEntity>> GetAllAsync();
    public Task Create(HistoryOrderTradingEntity historyOrderTradingEntity);
    public Task<Boolean> ChangeResolve(Guid Id);
    public Task<HistoryOrderTradingEntity> GetById(Guid Id);
    //public Task GetByParam();
}
