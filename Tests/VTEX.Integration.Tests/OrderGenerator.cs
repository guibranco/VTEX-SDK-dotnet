using Bogus;

public class OrderGenerator
{
    public static Order CreateFakeOrder()
    {
        var faker = new Faker<Order>()
            .RuleFor(o => o.OrderId, f => f.Random.Guid().ToString())
            .RuleFor(o => o.CustomerName, f => f.Name.FullName())
            .RuleFor(o => o.Amount, f => f.Finance.Amount());

        return faker.Generate();
    }
}

public class Order
{
    public string OrderId { get; set; }
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
}