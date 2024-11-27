using CQRS.Application.Services;
using CQRS.Application.Services.Interface;
using CQRS.Worker.Services.Interfaces;

namespace CQRS.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IInvokeOKXService _invokeOKXService;
    private readonly IOKXExcelSerivce _oKXExcelSerivce;
    private readonly IAppSettingsService _appSettingsService;

    public Worker(ILogger<Worker> logger, IInvokeOKXService invokeOKXService, IOKXExcelSerivce oKXExcelSerivce, IAppSettingsService appSettingsService)
    {
        _logger = logger;
        _invokeOKXService = invokeOKXService;
        _oKXExcelSerivce = oKXExcelSerivce;
        _appSettingsService = appSettingsService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // if (_logger.IsEnabled(LogLevel.Information))
            // {
            //     _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            // }
            //await _invokeOKXService.GetOrderHistory();

            //_oKXExcelSerivce.ReadAndWriteNewExcel();
            string response = _appSettingsService.GetSetting("OKXURL");
            Console.WriteLine(response);
            string response1 = _appSettingsService.GetSetting("Logging:LogLevel:Default");
            Console.WriteLine(response1);
            await Task.Delay(2000, stoppingToken);
        }
    }
}
