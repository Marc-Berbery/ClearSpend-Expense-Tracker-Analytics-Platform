using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace Adv._Project.Services
{
    public class CurrencyService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public CurrencyService( HttpClient httpClient ,IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiKey = configuration["OpenExchangeRates:ApiKey"];
        }

        public async Task<decimal> ConvertCurrencyAsync(decimal amount, string fromCurrency, string toCurrency)
        {
            string url = $"https://openexchangerates.org/api/latest.json?app_id={_apiKey}";
            var response = await _httpClient.GetStringAsync(url);
            var exchangeRates = JsonConvert.DeserializeObject<ExchangeRateResponse>(response);

            if (exchangeRates == null || !exchangeRates.Rates.ContainsKey(fromCurrency) || !exchangeRates.Rates.ContainsKey(toCurrency))
            {
                throw new Exception("Invalid currency codes or failed to fetch exchange rates.");
            }

            var fromRate = exchangeRates.Rates[fromCurrency];
            var toRate = exchangeRates.Rates[toCurrency];

            // Convert the amount from 'fromCurrency' to 'toCurrency'
            return (amount / fromRate) * toRate;
        }
    }

    public class ExchangeRateResponse
    {
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
