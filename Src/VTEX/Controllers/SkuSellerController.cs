using Microsoft.AspNetCore.Mvc;
using VTEX.Models;
using System.Collections.Generic;

namespace VTEX.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkuSellerController : ControllerBase
    {
        private static List<SkuSeller> skuSellers = new List<SkuSeller>();

        [HttpGet("{skuId}")]
        public ActionResult<IEnumerable<SkuSeller>> GetSkuSellers(int skuId)
        {
            var sellers = skuSellers.FindAll(s => s.SkuId == skuId);
            if (sellers == null || sellers.Count == 0)
            {
                return NotFound();
            }
            return Ok(sellers);
        }

        [HttpDelete("{skuId}/{sellerId}")]
        public ActionResult DeleteSkuSeller(int skuId, int sellerId)
        {
            var seller = skuSellers.Find(s => s.SkuId == skuId && s.SellerId == sellerId);
            if (seller == null)
            {
                return NotFound();
            }
            skuSellers.Remove(seller);
            return NoContent();
        }
    }
}