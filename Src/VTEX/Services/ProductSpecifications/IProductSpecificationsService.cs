using System.Threading.Tasks;
using VTEX.Models;

namespace VTEX.Services.ProductSpecifications
{
    public interface IProductSpecificationsService
    {
        Task<ProductSpecification> GetProductSpecificationsAsync(int productId);
        Task CreateProductSpecificationAsync(ProductSpecification specification);
        Task UpdateProductSpecificationAsync(ProductSpecification specification);
        // Add other necessary methods
    }
}
