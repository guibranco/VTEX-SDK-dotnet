using Microsoft.AspNetCore.Mvc;
using VTEX.Models;

namespace VTEX.Api
{
    [Route("api/sku")]
    [ApiController]
    public class SkuApi : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<Sku> GetSkuById(int id)
        {
            // Logic to retrieve SKU by id
            return Ok(new Sku { Id = id, Name = "Sample SKU", Price = 100.0, Inventory = 50 });
        }
    }
}

// Note: This is a basic implementation. The actual logic to retrieve SKU details from the database should be added.
