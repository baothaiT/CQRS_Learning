using CQRS.Application.Services;
using CQRS.Application.Services.Interface;
using CQRS.Domain.Abstractions.WorkerService;
using CQRS.Infrastructure.OKX.Services;
using CQRS.Worker;
using CQRS.Worker.Services;
using CQRS.Worker.Services.Interfaces;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<IInvokeOKXService, InvokeOKXService>();
builder.Services.AddSingleton<IOkxApiClient, OkxApiClient>();

builder.Services.AddSingleton<IOKXFileService, OKXExcelService>();
builder.Services.AddSingleton<IOKXExcelSerivce, OKXExcelSerivce>();

builder.Services.AddSingleton<IAppSettingsService, AppSettingsService>();

var host = builder.Build();
host.Run();
