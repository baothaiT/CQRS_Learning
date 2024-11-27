using CQRS.Worker.Services.Interfaces;

namespace CQRS.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IInvokeOKXService _invokeOKXService;
    private readonly IOKXExcelSerivce _oKXExcelSerivce;

    public Worker(ILogger<Worker> logger, IInvokeOKXService invokeOKXService, IOKXExcelSerivce oKXExcelSerivce)
    {
        _logger = logger;
        _invokeOKXService = invokeOKXService;
        _oKXExcelSerivce = oKXExcelSerivce;
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

            _oKXExcelSerivce.ReadAndWriteNewExcel();
            await Task.Delay(6000, stoppingToken);
        }
    }
}
