// ***********************************************************************
// Assembly         : VTEX.Health
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-15-2023
// ***********************************************************************
// <copyright file="VtexHealthClient.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace VTEX.Health
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Logging;
    using Newtonsoft.Json;

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
        /// Initializes a new instance of the <see cref="VtexHealthClient" /> class.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        /// <param name="httpClientFactory">The HTTP client factory.</param>
        /// <exception cref="System.ArgumentNullException">loggerFactory</exception>
        /// <exception cref="System.ArgumentNullException">httpClient</exception>
        public VtexHealthClient(ILoggerFactory loggerFactory, IHttpClientFactory httpClientFactory)
        {
            if (loggerFactory == null)
            {
                throw new ArgumentNullException(nameof(loggerFactory));
            }

            _logger = loggerFactory.CreateLogger<VtexHealthClient>();
            _httpClient = httpClientFactory.CreateClient();
        }

        #endregion

        #region Implementation of IVtexHealthClient

        /// <inheritdoc />
        public async Task<IEnumerable<PlatformStatus>> GetPlatformStatuesAsync(
            CancellationToken cancellationToken
        )
        {
            _logger.LogDebug("Getting platform status");
            var response = await _httpClient.GetAsync("/", cancellationToken).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            _logger.LogDebug($"Platform status response: {response.StatusCode}");
            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<PlatformStatus[]>(responseContent)
                : default;
        }

        #endregion
    }
}
