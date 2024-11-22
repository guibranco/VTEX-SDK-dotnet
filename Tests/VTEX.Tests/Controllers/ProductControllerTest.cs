using Microsoft.AspNetCore.Mvc;
using VTEX.API.Controllers;
using Xunit;

namespace VTEX.Tests.Controllers
{
    public class ProductControllerTest
    {
        [Fact]
        public void CreateProduct_ReturnsOkResult()
        {
            // Arrange
            var controller = new ProductController();
            var product = new Product { Name = "Test Product", Price = 10.0m };

            // Act
            var result = controller.CreateProduct(product);

            // Assert
            Assert.IsType<OkResult>(result);
        }
    }
}
