using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CQRS.Application.Services.Interface;
using CQRS.Contract.Share.Enum;
using CQRS.Contract.Share.Models;

namespace CQRS.Application.Services
{
    public class ProxyService: IProxyService
    {
        public ProxyService() { }
        //public async Task<bool> IsProxyWorking(string proxyAddress, string proxyUsername, string proxyPassword, string testUrl)
        public async Task<GetProxyDto> IsProxyWorking(GetProxyDto proxy)
        {
            try
            {
                // Create proxy
                string testUrl = "https://httpbin.org/ip";
                string proxyAddress = $"{proxy.Ip}:{proxy.Port}";
                var webProxy = new WebProxy(proxyAddress, true);

                // If credentials are provided, set them
                if (!string.IsNullOrEmpty(proxy.User) && !string.IsNullOrEmpty(proxy.Password))
                {
                    webProxy.Credentials = new NetworkCredential(proxy.User, proxy.Password);
                }

                // Setup HttpClientHandler to use the proxy
                var httpClientHandler = new HttpClientHandler
                {
                    Proxy = webProxy,
                    UseProxy = true
                };

                // Create HttpClient
                using (HttpClient client = new HttpClient(httpClientHandler))
                {
                    // Set a timeout in case of delays
                    client.Timeout = TimeSpan.FromSeconds(10);

                    // Send a test request to the provided URL
                    HttpResponseMessage response = await client.GetAsync(testUrl);

                    // Check if the response was successful
                    if(response.IsSuccessStatusCode)
                    {
                        proxy.IsStatus = ProxyStatusEnum.Live;

                    }
                    else
                    {
                        proxy.IsStatus = ProxyStatusEnum.Die;
                    }
                }
                return proxy;
            }
            catch (Exception ex)
            {
                // Handle exceptions like timeouts, bad proxy credentials, etc.
                Console.WriteLine($"Error: {ex.Message}");
                proxy.IsStatus = ProxyStatusEnum.Die;
                return proxy;
            }
        }
    }
}
