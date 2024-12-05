using CQRS.Contract.Models.OKX;
using CQRS.Contract.Share.DTO.HistoryOrderTrading;
using MMO.Application.Abstractions;
using MMO.Application.Abstractions.CompareServices;
using System.Collections.Generic;
using System.Drawing;
namespace MMO.Worker.Services;

public class JobService : IJobService
{
    private readonly IInvokeOKXService _invokeOKXService;
    private readonly IHistoryOrderTradingClientService _historyOrderTradingClientService;
    private readonly IBaseHistoryOrderTradingComparer _baseHistoryOrderTradingComparer;
    public JobService(
        IInvokeOKXService invokeOKXService,
        IHistoryOrderTradingClientService historyOrderTradingClientService,
        IBaseHistoryOrderTradingComparer baseHistoryOrderTradingComparer
        )
    {
        _invokeOKXService = invokeOKXService;
        _historyOrderTradingClientService = historyOrderTradingClientService;
        _baseHistoryOrderTradingComparer = baseHistoryOrderTradingComparer;
    }

    public async Task Update_HistoryOrderTrading()
    {
        try
        {
            // 1: Get data from OKX DEX
            RootModel response = await _invokeOKXService.GetOrderHistory();
            List<GetHistoryOrderTradingDTO> responseFromDEXC = _baseHistoryOrderTradingComparer.ConvertTo_GetHistoryOrderTradingDTO(response.Data);

            // 2: Get data from SQL 
            var responseFromSql = await _historyOrderTradingClientService.GetHistoryOrderTradingAsync();


            // 3: Check and add to SQL if it not exist on SQL
            var newHistoryOrderTradingList = _baseHistoryOrderTradingComparer.GetNewList(responseFromSql.ToList(), responseFromDEXC);

            if (newHistoryOrderTradingList.isStatus)
            {
                Console.WriteLine($"Number of list: {newHistoryOrderTradingList.newHistoryOrderTradingList.Count}");
                int index = 0;
                int maxParallelism = Environment.ProcessorCount;
                Console.WriteLine($"Max parallelism allowed: {maxParallelism}");
                var semaphore = new SemaphoreSlim(maxParallelism);

                var tasks = newHistoryOrderTradingList.newHistoryOrderTradingList.Select(async itemHistoryOrderTrading =>
                {
                    await semaphore.WaitAsync();
                    try
                    {
                        Console.WriteLine("Proccess with: " + ++index);
                        await _historyOrderTradingClientService.PostHistoryOrderTradingAsync(itemHistoryOrderTrading);
                    }
                    finally
                    {
                        semaphore.Release();
                    }
                });
                await Task.WhenAll(tasks);

                Console.WriteLine("Update Changed");
            }
            else
            {
                Console.WriteLine("Not Changed");
            }
            Console.WriteLine($"All task started: ");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex);
        }
        
    }

    private List<GetHistoryOrderTradingDTO> fakeData1()
    {
        List<GetHistoryOrderTradingDTO> list = new List<GetHistoryOrderTradingDTO>();
        //for (int i = 0; i < 3; i++)
        //{
        //    GetHistoryOrderTradingDTO getHistoryOrderTradingDTO = new GetHistoryOrderTradingDTO();
        //    getHistoryOrderTradingDTO.Symbol_Prefix = $"test{i}";
        //    getHistoryOrderTradingDTO.Symbol_Suffix = $"test{i}";
        //    //getHistoryOrderTradingDTO.OrderTime = DateTime.Now;
        //    getHistoryOrderTradingDTO.Side = $"test{i}";
        //    getHistoryOrderTradingDTO.FillAndOrderPrice_Suffix = $"test{i}";
        //    getHistoryOrderTradingDTO.FilledAndTotal_Suffix_Value = $"test{i}";
        //    getHistoryOrderTradingDTO.FilledAndOrderValue_Prefix = $"test{i}";
        //    getHistoryOrderTradingDTO.Fee = 1;

        //    list.Add(getHistoryOrderTradingDTO);
        //}
        return list;
    }

    private List<GetHistoryOrderTradingDTO> fakeData2()
    {
        List<GetHistoryOrderTradingDTO> list = new List<GetHistoryOrderTradingDTO>();
        for (int i = 0; i < 3; i++)
        {
            GetHistoryOrderTradingDTO getHistoryOrderTradingDTO = new GetHistoryOrderTradingDTO();
            getHistoryOrderTradingDTO.Symbol_Prefix = $"test{i}";
            getHistoryOrderTradingDTO.Symbol_Suffix = $"test{i}";
            //getHistoryOrderTradingDTO.OrderTime = DateTime.Now;
            getHistoryOrderTradingDTO.Side = $"test{i}";
            getHistoryOrderTradingDTO.FillAndOrderPrice_Suffix = $"test{i}";
            getHistoryOrderTradingDTO.FilledAndTotal_Suffix_Value = $"test{i}";
            getHistoryOrderTradingDTO.FilledAndOrderValue_Prefix = $"test{i}";
            getHistoryOrderTradingDTO.Fee = 1;

            list.Add(getHistoryOrderTradingDTO);
        }
        return list;
    }
}
