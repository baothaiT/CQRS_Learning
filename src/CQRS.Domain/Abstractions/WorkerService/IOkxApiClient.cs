using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Abstractions.Repository
{
    public interface IOkxApiClient
    {
        public Task Setup(string apiKey, string secretKey, string passphrase);
        public Task<dynamic> GetAccountBalanceAsync();
        public Task<dynamic> GetSpotOrderHistoryAsync(string queryParams);
        public Task<string> GenerateQueryParam(string ordType, string instType, string begin = "", string end = "");
    }
}