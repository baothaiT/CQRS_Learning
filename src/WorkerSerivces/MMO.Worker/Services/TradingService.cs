
using CQRS.Contract.Models.OKX;

namespace MMO.Worker.Services
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
