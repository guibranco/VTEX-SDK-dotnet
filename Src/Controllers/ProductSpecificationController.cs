using System.Threading;
using Microsoft.AspNetCore.Mvc;
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


        [HttpPost]
        public async Task<IActionResult> CreateSpecification(int productId, [FromBody] Specification specification, CancellationToken token)
        {
            // Logic to create a new specification
            await _context.UpdateProductSpecificationAsync(specification, productId, token);
            return CreatedAtAction(nameof(GetSpecifications), new { productId }, specification);
        }

        [HttpPut("{specificationId}")]
        public async Task<IActionResult> UpdateSpecification(int productId, int specificationId, [FromBody] Specification specification, CancellationToken token)
        {
            // Logic to update an existing specification
            if (specification.Id != specificationId)
            {
                return BadRequest();
            }
            await _context.UpdateProductSpecificationAsync(specification, productId, token);
            return NoContent();
        }
}
