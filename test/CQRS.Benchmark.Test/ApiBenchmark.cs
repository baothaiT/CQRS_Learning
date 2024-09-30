using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;
using CQRS.Benchmark.Test.Request.Proxy;

namespace CQRS.Benchmark.Test;

[Config(typeof(CustomConfig))]
public class ApiBenchmark
{
    private readonly ApiClient _apiClient;
    private readonly ProxyRequest _proxyRequest;

    public ApiBenchmark()
    {
        _apiClient = new ApiClient();
        _proxyRequest = new ProxyRequest
        {
            Ip = "192.168.1.999",
            Port = 8080,
            User = "proxyUser1",
            Password = "proxyPass1",
            IsDelete = false
        };
    }

    [Benchmark]
    public async Task GetApiDataBenchmark()
    {
        // Replace with your actual API URL
        string url = "http://localhost:5199/Proxy";
        Console.WriteLine("URL: " + url);
        await _apiClient.GetDataFromApiAsync(url);
    }

    [Benchmark]
    public async Task PostApiDataBenchmark()
    {
        string apiUrl = "http://localhost:5199/Proxy"; // Replace with your actual API endpoint
        await _apiClient.PostDataToApiAsync(apiUrl, _proxyRequest);
    }
}
