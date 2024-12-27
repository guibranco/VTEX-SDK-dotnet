using System.Threading.Tasks;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using Xunit;

public class ErpServiceTests : IClassFixture<WireMockServerFixture>
{
    private readonly WireMockServerFixture _fixture;

    public ErpServiceTests(WireMockServerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task ShouldHandleSuccessfulResponse()
    {
        // Arrange
        _fixture.Server
            .Given(Request.Create().WithPath("/api/orders").UsingGet())
            .RespondWith(Response.Create().WithStatusCode(200).WithBody("{ \"orderId\": \"12345\" }"));

        // Act
        var result = await _service.GetOrderAsync("12345");

        // Assert
        Assert.Equal("12345", result.OrderId);
    }
}