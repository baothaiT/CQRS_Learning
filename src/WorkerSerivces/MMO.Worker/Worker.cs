

using MMO.Application.Abstractions;
using MMO.Worker.Services;

namespace MMO.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IJobService _jobService;


    public Worker(ILogger<Worker> logger, IJobService jobService)
    {
        _logger = logger;
        _jobService = jobService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            // if (_logger.IsEnabled(LogLevel.Information))
            // {
            //     _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            // }

            await _jobService.Update_HistoryOrderTrading();

            await Task.Delay(3000, stoppingToken);
        }
    }
}
