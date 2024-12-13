using Microsoft.AspNetCore.Mvc;

namespace VTEX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkuServiceTypeController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSkuServiceType()
        {
            // Logic for creating SKU Service Type
            return Ok();
        }
    }
}