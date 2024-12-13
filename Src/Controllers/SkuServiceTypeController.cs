using Microsoft.AspNetCore.Mvc;

namespace VTEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkuServiceTypeController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSkuServiceType([FromBody] SkuServiceTypeDto skuServiceTypeDto)
        {
            // Logic for creating SKU Service Type
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSkuServiceType(int id, [FromBody] SkuServiceTypeDto skuServiceTypeDto)
        {
            // Logic for updating SKU Service Type
            return Ok();
        }

        [HttpDelete("{id}")]
        {
            // Logic for creating SKU Service Type
            return Ok();
        }
    }
}
