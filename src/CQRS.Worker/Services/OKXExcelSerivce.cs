using CQRS.Domain.Abstractions.WorkerService;
using CQRS.Domain.Enums;
using CQRS.Worker.Services.Interfaces;

namespace CQRS.Worker.Services;

public class OKXExcelSerivce: IOKXExcelSerivce
{
    private readonly IOKXFileService _oKXFileService;
    public OKXExcelSerivce(IOKXFileService oKXFileService)
    {
        _oKXFileService = oKXFileService;
    }

    public void ReadAndWriteNewExcel()
    {
        var targetDirectory = _oKXFileService.GetFilePath();

        Console.WriteLine(targetDirectory);
        var excelData = _oKXFileService.Read(targetDirectory);

        _oKXFileService.Write(excelData.Where(x => x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList(), targetDirectory);

        TradingService tradingService = new TradingService();
        var profit = tradingService.CaculatorProfit(
            excelData.Where(x => x.Side == TypeSideEnum.BUY && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList(),
            excelData.Where(x => x.Side == TypeSideEnum.SELL && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList()
        );

        Console.WriteLine($"Profit = {profit} USDT");
    }
}