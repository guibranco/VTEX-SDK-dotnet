using Xunit;
using VTEX.Services;

namespace VTEX.Tests
{
    public class SalesChannelApiTests
    {
        private readonly SalesChannelService _service;

        public SalesChannelApiTests()
        {
            _service = new SalesChannelService();
        }

        [Fact]
        public void TestGetAllSalesChannels()
        {
            var result = _service.GetAllSalesChannels();
            Assert.NotNull(result);
        }

        // Additional tests for other endpoints
    }
}
