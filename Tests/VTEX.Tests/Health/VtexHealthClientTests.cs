using Moq;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VTEX.Health;
using Xunit;

namespace VTEX.Tests.Health
{
    public class VtexHealthClientTests
    {
        [Fact]
        public async Task ValidateHealthClient()
        {
            var fixtures = new Collection<PlatformStatus>
            {
                new PlatformStatus
                {
                    LastResult = DateTime.Now,
                    Status = ResultStatus.HEALTHY,
                    Name = "Test",
                    LastResultStatus = "healthy"
                },
                new PlatformStatus
                {
                    LastResult = DateTime.Now,
                    Status = ResultStatus.UNHEALTHY,
                    Name = "Test unhealthy",
                    LastResultStatus = "healthy"
                },
            };

            var clientMock = new Mock<IVtexHealthClient>();
            clientMock.Setup(c => c.GetPlatformStatuesAsync(It.IsAny<CancellationToken>()))
                      .ReturnsAsync(fixtures);

            var result = await clientMock.Object.GetPlatformStatuesAsync(CancellationToken.None);

            Assert.NotNull(result);

            var list = result.ToList();
            Assert.Equal(2, list.Count);
            Assert.Contains(list, r => r.Status.Equals(ResultStatus.HEALTHY));
            Assert.Contains(list, r => r.Status.Equals(ResultStatus.UNHEALTHY));
        }
    }
}
