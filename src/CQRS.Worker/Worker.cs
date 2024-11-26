using CQRS.Worker.Services.Interfaces;

namespace CQRS.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IInvokeOKXService _invokeOKXService;

    public Worker(ILogger<Worker> logger, IInvokeOKXService invokeOKXService)
    {
        _logger = logger;
        _invokeOKXService = invokeOKXService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // if (_logger.IsEnabled(LogLevel.Information))
            // {
            //     _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            // }
            await _invokeOKXService.GetOrderHistory();
            await Task.Delay(6000, stoppingToken);
        }
    }
}
