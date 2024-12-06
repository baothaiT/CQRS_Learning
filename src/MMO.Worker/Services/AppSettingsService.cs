using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMO.Worker.Services.Interface;

namespace MMO.Worker.Services
{
    public class AppSettingsService : IAppSettingsService
    {
        private readonly IConfiguration _configuration;

        public AppSettingsService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetSetting(string key)
        {
            var value = _configuration[key];

            if (string.IsNullOrEmpty(value))
            {
                throw new KeyNotFoundException($"The key '{key}' was not found in appsettings.");
            }

            return value;
        }
    }
}
