using System.Collections.Generic;
using System.Threading.Tasks;

namespace VTEX.Clients.Catalog.Contracts
{
    public interface ISkuEanClient
    {
        Task<IEnumerable<string>> GetSkuEansAsync(int skuId);
        Task AddSkuEanAsync(int skuId, string ean);
        Task UpdateSkuEanAsync(int skuId, string oldEan, string newEan);
    }
}
