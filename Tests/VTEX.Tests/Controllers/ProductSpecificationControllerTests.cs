using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using VTEX;
using Xunit;

namespace VTEX.Tests.Controllers
{
    public class ProductSpecificationControllerTests
    {
        private readonly VTEXContext _context;
        private readonly ProductSpecificationController _controller;

        public ProductSpecificationControllerTests()
        {
            _context = Substitute.For<VTEXContext>();
            _controller = new ProductSpecificationController(_context);
        }

        [Fact]
        public async Task GetSpecifications_ReturnsOkResult()
        {
            // Arrange
            int productId = 1;

            _context.GetProductSpecificationsAsync(productId, Arg.Any<CancellationToken>()).Returns(new List<Specification>());
            // Act
            var result = await _controller.GetSpecifications(productId, CancellationToken.None);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task CreateSpecification_ReturnsCreatedAtActionResult()
        {
            // Arrange
            int productId = 1;
            var specification = new Specification();

            // Act
            var result = await _controller.CreateSpecification(productId, specification, CancellationToken.None);
              var result = await _controller.CreateSpecification(productId, specification, CancellationToken.None);

            // Assert
            Assert.IsType<CreatedAtActionResult>(result);
        }

        // Additional tests for UpdateSpecification will be added here

        [Fact]
        public async Task UpdateSpecification_ReturnsNoContentResult()
        {
            // Arrange
            int productId = 1;
            int specificationId = 1;
            var specification = new Specification { Id = specificationId };

            // Act
            var result = await _controller.UpdateSpecification(productId, specificationId, specification, CancellationToken.None);

            // Assert
