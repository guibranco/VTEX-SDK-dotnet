using System.Threading.Tasks;
using Snapshooter.Xunit;
using Xunit;

public class SnapshotTests
{
    [Fact]
    public async Task ShouldMatchExpectedResponse()
    {
        // Arrange
        var expectedResponse = new { OrderId = "12345" };

        // Act
        var actualResponse = await _service.GetOrderAsync("12345");

        // Assert
        actualResponse.Should().MatchSnapshot();
    }
}
