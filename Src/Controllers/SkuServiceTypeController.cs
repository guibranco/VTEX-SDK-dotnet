using Microsoft.AspNetCore.Mvc;

using VTEX.Services;
namespace VTEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkuServiceTypeController : ControllerBase
    {
        private readonly SkuServiceTypeService _skuServiceTypeService = new SkuServiceTypeService();
        [HttpPost]
        public IActionResult CreateSkuServiceType([FromBody] SkuServiceTypeDto skuServiceTypeDto)
        {
            // Logic for creating SKU Service Type
            _skuServiceTypeService.CreateSkuServiceType(skuServiceTypeDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSkuServiceType(int id, [FromBody] SkuServiceTypeDto skuServiceTypeDto)
            _skuServiceTypeService.UpdateSkuServiceType(id, skuServiceTypeDto);
        {
            // Logic for updating SKU Service Type
            return Ok();
        }

            _skuServiceTypeService.DeleteSkuServiceType(id);
        [HttpDelete("{id}")]
        {
            // Logic for creating SKU Service Type
            return Ok();
        }
    }
}
