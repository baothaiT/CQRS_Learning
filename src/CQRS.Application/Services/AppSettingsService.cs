﻿using CQRS.Application.Services.Interface;
using Microsoft.Extensions.Configuration;

namespace CQRS.Application.Services
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
