using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VTEXIntegration
{
    public class VTEXFeedV3Integration
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _apiToken;

        public VTEXFeedV3Integration(string apiKey, string apiToken)
        {
            _httpClient = new HttpClient();
            _apiKey = apiKey;
            _apiToken = apiToken;
        }

        public async Task<string> GetFeedOrderStatus1Async()
        {
            var request = new HttpRequestMessage(
                HttpMethod.Get,
                "https://api.vtex.com/your-account/feed/orders/status"
            request.Headers.Add("X-VTEX-API-AppKey", _apiKey);
            request.Headers.Add("X-VTEX-API-AppToken", _apiToken);

            try
            {
                var response = await _httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrWhiteSpace(content))
                {
                    throw new Exception("Received empty response from VTEX API.");
                }
                return content;
            }
            catch (HttpRequestException e)
            {
                throw new Exception("Error fetching order status from VTEX API.", e);
            }
        }
    }
}
