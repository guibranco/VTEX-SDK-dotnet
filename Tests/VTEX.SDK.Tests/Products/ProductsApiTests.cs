using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Moq.Protected;
using System.Threading;
using System.Net;

namespace VTEX.SDK.Tests.Products
{
    public class ProductsApiTests
    {
        [Fact]
        public async Task GetProductAsync_ShouldReturnProductData()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            handlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{ 'id': '123', 'name': 'Test Product' }"),
                });

            var httpClient = new HttpClient(handlerMock.Object);
            var api = new ProductsApi(httpClient);
            var result = await api.GetProductAsync("123");
            Assert.Contains("Test Product", result);
        }
    }
}