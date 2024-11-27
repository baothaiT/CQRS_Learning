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

        var buyExcel = excelData.Where(x => x.Side == TypeSideEnum.BUY && x.Symbol_Prefix == SymbolCoinEnums.DOGE).ToList();

        foreach (var itemBuy in buyExcel)
        {
            Console.WriteLine($"Symbol_Prefix {itemBuy.Symbol_Prefix};");
            Console.WriteLine($"Symbol_Suffix {itemBuy.Symbol_Suffix};");
            Console.WriteLine($"Order Time {itemBuy.OrderTime};");
            Console.WriteLine($"Side {itemBuy.Side};");
            Console.WriteLine($"FillAndOrderPrice_Prefix {itemBuy.FillAndOrderPrice_Prefix};");
            Console.WriteLine($"FillAndOrderPrice_Suffix {itemBuy.FillAndOrderPrice_Suffix};");
            Console.WriteLine($"Filled and Total Prefix Value {itemBuy.FilledAndTotal_Prefix_Value};");
            Console.WriteLine($"Filled and Total Prefix Symbol  {itemBuy.FilledAndTotal_Prefix_Symbol};");
            Console.WriteLine($"Filled and Total Suffix Value  {itemBuy.FilledAndTotal_Suffix_Value};");
            Console.WriteLine($"Filled and Total Suffix Symbol   {itemBuy.FilledAndTotal_Suffix_Symbol};");
            Console.WriteLine($"Filled and Order Value Prefix   {itemBuy.FilledAndOrderValue_Prefix};");
            Console.WriteLine($"Fee   {itemBuy.Fee};");
            Console.WriteLine("--------------------------");
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine("--------------------------");
    }
}