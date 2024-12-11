using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using VTEX;

namespace Controllers
{
    [ApiController]
    [Route("api/products/{productId}/specifications")]
    public class ProductSpecificationController : ControllerBase
    {
        private readonly VTEXContext _context;

        public ProductSpecificationController(VTEXContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpecifications(int productId, CancellationToken token)
        {
            var specifications = await _context.GetProductSpecificationsAsync(productId, token);
            return Ok(specifications);
        }

        // Additional endpoints for POST and PUT will be added here
    }
}
