using CQRS.Domain.Models.OKX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Worker.Services
{
    public class TradingService
    {
        public TradingService()
        {

        }

        public double CaculatorProfit(List<OKXExcelModel> buyData, List<OKXExcelModel> sellData)
        {
            double profit = sellData.Sum(x => x.FilledAndOrderValue_Prefix) - buyData.Sum(x => x.FilledAndOrderValue_Prefix);
            return profit;
        }
    }
}
