namespace VTEX.Health
{
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Class VtexHealthClient.
    /// Implements the <see cref="VTEX.Health.IVtexHealthClient" />
    /// </summary>
    /// <seealso cref="VTEX.Health.IVtexHealthClient" />
    public class VtexHealthClient : IVtexHealthClient
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<VtexHealthClient> _logger;

        /// <summary>
        /// The HTTP client
        /// </summary>
        private readonly HttpClient _httpClient;

        #region ~ctors

        /// <summary>
        /// Initializes a new instance of the <see cref="VtexHealthClient"/> class.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        /// <param name="httpClient">The HTTP client.</param>
        /// <exception cref="System.ArgumentNullException">loggerFactory</exception>
        /// <exception cref="System.ArgumentNullException">httpClient</exception>
        public VtexHealthClient(ILoggerFactory loggerFactory, HttpClient httpClient)
        {
            if (loggerFactory == null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }

            _logger = loggerFactory.CreateLogger<VtexHealthClient>();
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        #endregion

        #region Implementation of IVtexHealthClient

        /// <inheritdoc />
        public async Task<IEnumerable<PlatformStatus>> GetPlatformStatuesAsync(CancellationToken cancellationToken)
        {
            _logger.LogDebug("Getting platform status");
            var response = await _httpClient.GetAsync("/", cancellationToken).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            _logger.LogDebug($"Platform status response: {response.StatusCode}");
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<PlatformStatus[]>(responseContent) : default;
        }

        #endregion
    }
}
