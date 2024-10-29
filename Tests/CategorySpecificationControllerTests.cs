using System;
using Xunit;
using Src.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class CategorySpecificationControllerTests
    {
        [Fact]
        public void GetSpecificationsByCategory_ReturnsOkResult()
        {
            // Arrange
            var controller = new CategorySpecificationController();
            int testCategoryId = 1;

            // Act
            var result = controller.GetSpecificationsByCategory(testCategoryId);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
