using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


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

        [Required]
        [StringLength(100, MinimumLength = 3)]
        // Outros métodos para atualizar e gerenciar produtos
        [Required]
        [Range(0.01, 10000.00)]
    }
}

// Classe de modelo de produto
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    // Outros campos de produto
}
