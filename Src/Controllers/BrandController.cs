using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandService _brandService;

        public BrandController(BrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost("{brandId}/subcollections/{subcollectionId}")]
        public IActionResult AssociateSubcollection(int brandId, int subcollectionId)
        {
            try
            {
                _brandService.AssociateSubcollection(brandId, subcollectionId);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{brandId}/subcollections/{subcollectionId}")]
        public IActionResult DisassociateSubcollection(int brandId, int subcollectionId)
        {
            try
            {
                _brandService.DisassociateSubcollection(brandId, subcollectionId);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
