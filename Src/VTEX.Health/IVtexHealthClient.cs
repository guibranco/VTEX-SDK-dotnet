using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VTEX.Health
{
    public interface IVtexHealthClient
    {
        /// <summary>
        /// Gets the platform statues asynchronous.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<PlatformStatus>> GetPlatformStatuesAsync(CancellationToken cancellationToken);
    }
}
