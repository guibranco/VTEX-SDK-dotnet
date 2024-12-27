using System.Threading.Tasks;
using NSubstitute;
using Xunit;

public class OrderServiceTests
{
    private readonly IOrderRepository _orderRepository;
    private readonly OrderService _orderService;

    public OrderServiceTests()
    {
        _orderRepository = Substitute.For<IOrderRepository>();
        _orderService = new OrderService(_orderRepository);
    }

    [Fact]
    public async Task ShouldReturnOrder()
    {
        // Arrange
        var fakeOrder = OrderGenerator.CreateFakeOrder();
        _orderRepository.GetOrderAsync(Arg.Any<string>()).Returns(Task.FromResult(fakeOrder));

        // Act
        var result = await _orderService.GetOrderAsync(fakeOrder.OrderId);

        // Assert
        Assert.Equal(fakeOrder.OrderId, result.OrderId);
    }
}