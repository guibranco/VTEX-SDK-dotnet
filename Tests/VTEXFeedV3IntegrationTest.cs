using System;
using System.Threading.Tasks;
using Xunit;

namespace VTEXIntegration.Tests
{
    public class VTEXFeedV3IntegrationTest
    {
        [Fact]
        public async Task GetFeedOrderStatus1Async_ValidResponse_ReturnsContent()
        {
            // Arrange
            var integration = new VTEXFeedV3Integration("validApiKey", "validApiToken");

            // Act
            var result = await integration.GetFeedOrderStatus1Async();

            // Assert
            Assert.False(string.IsNullOrWhiteSpace(result), "Expected non-empty response content.");
        }

        [Fact]
        public async Task GetFeedOrderStatus1Async_InvalidCredentials_ThrowsException()
        {
            // Arrange
            var integration = new VTEXFeedV3Integration("invalidApiKey", "invalidApiToken");

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(
                async () => await integration.GetFeedOrderStatus1Async()
            );
        }

        [Fact]
        public async Task GetFeedOrderStatus1Async_EmptyResponse_ThrowsException()
        {
            // Arrange
            var integration = new VTEXFeedV3Integration("validApiKey", "validApiToken");

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () => await integration.GetFeedOrderStatus1Async());
        }
    }
}
