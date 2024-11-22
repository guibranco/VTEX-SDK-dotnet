using Microsoft.AspNetCore.Mvc;

namespace VTEX.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            // Lógica para criar um novo produto
            return Ok();
        }

        // Outros métodos para atualizar e gerenciar produtos
    }
}

// Classe de modelo de produto
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    // Outros campos de produto
}
