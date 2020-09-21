using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace VTEX.Health
{
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
            var response = await _httpClient.GetAsync("/", cancellationToken);
            var responseContent = await response.Content.ReadAsStringAsync();
            _logger.LogDebug($"Platform status response: {response.StatusCode}");
            return response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<PlatformStatus[]>(responseContent) : default;
        }

        #endregion
    }
}
