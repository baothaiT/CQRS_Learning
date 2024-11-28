
using MMO.Infrastructure.OKX.Services;
using MMO.Application.Abstractions;
using MMO.Worker;
using MMO.Worker.Services;
using MMO.Worker.Services.Interfaces;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddSingleton<IInvokeOKXService, InvokeOKXService>();
builder.Services.AddSingleton<IOkxApiClient, OkxApiClient>();

builder.Services.AddSingleton<IOKXFileService, OKXExcelService>();
builder.Services.AddSingleton<IOKXExcelSerivce, OKXExcelSerivce>();

var host = builder.Build();
host.Run();