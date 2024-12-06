
using MMO.Infrastructure.OKX.Services;
using MMO.Application.Abstractions;
using MMO.Worker;
using MMO.Worker.Services;
using MMO.Infrastructure.OKX.Services.CompareServices;
using MMO.Application.Abstractions.CompareServices;
using MMO.Worker.Services.Interface;


var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

// Application and Infrastructure.OKX
builder.Services.AddSingleton<IInvokeOKXService, InvokeOKXService>();
builder.Services.AddSingleton<IOkxApiClient, OkxApiClient>();
builder.Services.AddSingleton<IOKXFileService, OKXExcelService>();
builder.Services.AddSingleton<ITradingService, TradingService>();
builder.Services.AddSingleton<IOKXExcelSerivce, OKXExcelService>();

builder.Services.AddSingleton<IJobService, JobService>();

builder.Services.AddSingleton<IAppSettingsService, AppSettingsService>();

builder.Services.AddSingleton<IBaseHistoryOrderTradingComparer, BaseHistoryOrderTradingComparer>();

//builder.Services.AddSingleton<IHistoryOrderTradingClientService, HistoryOrderTradingClientService>();
builder.Services.AddHttpClient<IHistoryOrderTradingClientService, HistoryOrderTradingClientService>(client =>
{
    //client.BaseAddress = new Uri("http://localhost:5199/"); // Replace with your API URL
    client.BaseAddress = new Uri("https://fd617f5bb8f5.ngrok.app"); // Replace with your API URL
});

// Worker 
builder.Services.AddSingleton<IJobService, JobService>();

var host = builder.Build();
host.Run();