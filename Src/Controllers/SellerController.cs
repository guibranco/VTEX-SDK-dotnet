using Microsoft.AspNetCore.Mvc;
using Src.Models;
using Src.Repositories;

namespace Src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerController : ControllerBase
    {
        private readonly SellerRepository _sellerRepository;

        public SellerController(SellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Seller> GetSeller(int id)
        {
            var seller = _sellerRepository.GetSellerById(id);
            if (seller == null)
            {
                return NotFound();
            }
            return Ok(seller);
        }

        [HttpPost]
        public ActionResult CreateSeller(Seller seller)
        {
            _sellerRepository.AddSeller(seller);
            return CreatedAtAction(nameof(GetSeller), new { id = seller.Id }, seller);
        }
    }
}
