using YourNamespace.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YourNamespace.Services
{
    public class SkuKitService
    {
        private readonly HttpClient _httpClient;

        public SkuKitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<SkuKit> GetSkuKit(int skuId)
        {
            var response = await _httpClient.GetAsync($"/api/sku-kit/{skuId}");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SkuKit>(content);
        }

        public async Task CreateSkuKit(SkuKit kit)
        {
            var content = new StringContent(JsonConvert.SerializeObject(kit), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/sku-kit", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateSkuKit(int skuId, SkuKit kit)
        {
            var content = new StringContent(JsonConvert.SerializeObject(kit), System.Text.Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"/api/sku-kit/{skuId}", content);
            response.EnsureSuccessStatusCode();
        }
    }
}
