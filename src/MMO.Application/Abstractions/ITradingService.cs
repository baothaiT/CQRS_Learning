using CQRS.Contract.Models.OKX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO.Application.Abstractions;

public interface ITradingService
{
    public double CaculatorProfit(List<OKXExcelModel> buyData, List<OKXExcelModel> sellData);
}
