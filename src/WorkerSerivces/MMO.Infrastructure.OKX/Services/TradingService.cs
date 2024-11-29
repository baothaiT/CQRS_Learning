
using CQRS.Contract.Models.OKX;
using MMO.Application.Abstractions;

namespace MMO.Infrastructure.OKX.Services
{
    public class TradingService: ITradingService
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
