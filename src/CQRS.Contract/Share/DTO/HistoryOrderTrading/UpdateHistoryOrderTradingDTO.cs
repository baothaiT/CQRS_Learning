using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Contract.Share.DTO.HistoryOrderTrading;

public class UpdateHistoryOrderTradingDTO : BaseHistoryOrderTradingDTO
{
    public Guid Id { get; set; }
}
