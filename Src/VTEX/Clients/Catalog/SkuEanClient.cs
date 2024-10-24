using System.Collections.Generic;
using System.Threading.Tasks;

namespace VTEX.Clients.Catalog
{
    public class SkuEanClient : ISkuEanClient
    {
        public async Task<IEnumerable<string>> GetSkuEansAsync(int skuId)
        {
            // Implementation for retrieving SKU EANs
        }

        public async Task AddSkuEanAsync(int skuId, string ean)
        {
            // Implementation for adding a new SKU EAN
        }

        public async Task UpdateSkuEanAsync(int skuId, string oldEan, string newEan)
        {
            // Implementation for updating an existing SKU EAN
        }
    }
}
