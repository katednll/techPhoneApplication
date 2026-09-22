using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace techPhoneApplication.Services
{
    public class CurrencyService
    {
        private readonly HttpClient _httpClient;

        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> ConvertToPHP(decimal amount, string currency, DateTime date)
        {
            if (currency == "PHP") return amount;

            var dateStr = date.ToString("yyyy-MM-dd");
            var url = $"https://api.frankfurter.dev/v1/{dateStr}?from={currency}&to=PHP";

            var response = await _httpClient.GetFromJsonAsync<FrankfurterResponse>(url);
            var rate = response.Rates["PHP"];
            return amount * rate;
        }
    }

    public class FrankfurterResponse
    {
        public Dictionary<string, decimal> Rates { get; set; }
    }
}
