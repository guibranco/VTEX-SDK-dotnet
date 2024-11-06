using Microsoft.AspNetCore.Mvc;
using Src.Controllers;
using Src.Models;
using Src.Repositories;
using Xunit;

namespace Tests.SellerAPI.Tests
{
    public class SellerControllerTests
    {
        private readonly SellerController _controller;
        private readonly SellerRepository _repository;

        public SellerControllerTests()
        {
            _repository = new SellerRepository();
            _controller = new SellerController(_repository);
        }

        [Fact]
        public void GetSeller_ReturnsNotFound_WhenSellerDoesNotExist()
        {
            var result = _controller.GetSeller(1);
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public void CreateSeller_ReturnsCreatedAtActionResult()
        {
            var seller = new Seller { Id = 1, Name = "Test Seller", ContactInfo = "test@example.com" };
            var result = _controller.CreateSeller(seller);
            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Fact]
        public void GetSeller_ReturnsSeller_WhenSellerExists()
        {
            var seller = new Seller { Id = 1, Name = "Test Seller", ContactInfo = "test@example.com" };
            _repository.AddSeller(seller);
            var result = _controller.GetSeller(1);
            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
