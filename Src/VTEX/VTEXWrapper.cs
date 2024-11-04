// ***********************************************************************
// Assembly         : VTEX
// Author           : Guilherme Branco Stracini
// Created          : 01-15-2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 01-16-2023
// ***********************************************************************
// <copyright file="VTEXWrapper.cs" company="Guilherme Branco Stracini">
//     © 2020 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
namespace VTEX
{
// ***********************************************************************
namespace VTEX
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    public class VTEXWrapper
    using System.Threading.Tasks;
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Log;
    using CrispyWaffle.Telemetry;
    using CrispyWaffle.Utilities;
    using Enums;
    using GoodPractices;

    /// <summary>
    /// Class Wrapper. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="IDisposable" />
    // TODO change public to internal after remove from Integração Service
    public sealed class VTEXWrapper : IDisposable

    {
        #region Private fields

        /// <summary>
        /// The application key
        /// </summary>
        private string _appKey;

        /// <summary>
        /// The application token
        /// </summary>
        private string _appToken;

        /// <summary>

        /// The authentication cookie
        /// </summary>
        private string _authCookie;

        /// <summary>
        /// The account name
        /// </summary>
        private readonly string _accountName;


        /// <summary>
        /// The internal user agent
        /// </summary>
        private static string _internalUserAgent;

        /// <summary>
        /// Gets the internal user agent.
        /// </summary>
        /// <value>The internal user agent.</value>

        private static string InternalUserAgent
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(_internalUserAgent))
                {
                    return _internalUserAgent;
                }


                var assembly = System
                    .Reflection.Assembly.GetAssembly(typeof(VTEXWrapper))
                    .GetName();
                _internalUserAgent = $@"{assembly.Name}/{assembly.Version}";
                return _internalUserAgent;
            }
        }

        /// <summary>

        /// The request mediator
        /// </summary>
        private readonly ManualResetEvent _requestMediator = new ManualResetEvent(false);

        #endregion

        #region ~Ctor

        /// <summary>

        /// Initializes a new instance of the <see cref="VTEXWrapper" /> class.
        /// </summary>
        /// <param name="accountName">The account name.</param>
        public VTEXWrapper(string accountName)
        {
            _accountName = accountName;
            _requestMediator.Set();
        }


        #endregion

        #region Implementation of IDisposable

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {

            _appKey = null;
            _appToken = null;
            _requestMediator.Dispose();
        }


        #endregion

        #region Private methods

        /// <summary>
        /// Services the invoker internal.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="token">The token.</param>
        /// <param name="data">The data.</param>
        /// <param name="uriBuilder">The URI builder.</param>
        /// <param name="cookie">The cookie.</param>

        /// <param name="requiresAuthentication">if set to <c>true</c> [requires authentication].</param>
        /// <param name="isRetry">if set to <c>true</c> [is retry].</param>
        /// <returns>System.String.</returns>
        private async Task<string> ServiceInvokerInternal(
            HttpRequestMethod method,
            string endpoint,
            CancellationToken token,
            string data,
            UriBuilder uriBuilder,

            Cookie cookie,
            bool requiresAuthentication,
            bool isRetry = false
        )
        {
            HttpResponseMessage response = null;
            string result = null;
            Exception exr;
            try

            {
                _requestMediator.WaitOne();

                LogConsumer.Trace(
                    "ServiceInvokerAsync -&gt; Method: {0} | Endpoint: {1}",
                    method.GetHumanReadableValue(),
                    endpoint
                );


                LogConsumer.Debug(uriBuilder.ToString());

                var cookieContainer = new CookieContainer();

                using var handler = new HttpClientHandler { CookieContainer = cookieContainer };

                using var client = new HttpClient(handler);

                ConfigureClient(client, requiresAuthentication);


                if (cookie != null)
                {
                    cookieContainer.Add(uriBuilder.Uri, cookie);
                }

                response = await RequestInternalAsync(method, token, data, client, uriBuilder)
                    .ConfigureAwait(false);


                token.ThrowIfCancellationRequested();

                result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                response.EnsureSuccessStatusCode();

                return result;
            }
            catch (AggregateException e)

            {
                var ex = e.InnerExceptions.FirstOrDefault() ?? e.InnerException ?? e;

                exr = HandleException(ex, response, uriBuilder.Uri, method, data, result);

                if (isRetry)
                {
                    throw exr;
                }

            }
            catch (Exception e)
            {
                exr = HandleException(e, response, uriBuilder.Uri, method, data, result);

                if (isRetry)
                {
                    throw exr;
                }

            }

            return await ServiceInvokerInternal(
                    method,
                    endpoint,
                    token,
                    data,
                    uriBuilder,
                    cookie,

                    requiresAuthentication,
                    true
                )
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Handles the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="response">The response.</param>
        /// <param name="uri">The URI.</param>
        /// <param name="method">The method.</param>
        /// <param name="data">The data.</param>
        /// <param name="result">The result.</param>
        /// <returns>Exception.</returns>
        /// <exception cref="UnexpectedApiResponseException"></exception>
        private Exception HandleException(
            Exception exception,
            HttpResponseMessage response,
            Uri uri,
            HttpRequestMethod method,
            string data,
            string result
        )
        {
            var statusCode = 0;
            if (response != null)
            {
                statusCode = (int)response.StatusCode;
            }

            var ex = new UnexpectedApiResponseException(
                uri,
                method.ToString(),
                data,
                result,
                statusCode,
                exception
            );
            if (statusCode == 429 || statusCode == 503)
            {
                _requestMediator.Reset();
                LogConsumer.Warning(
                    "HTTP {2} status code on method {0} - uri {1}",
                    method.ToString(),
                    uri,
                    statusCode
                );
                Thread.Sleep(60 * 1000);
                _requestMediator.Set();
                return ex;
            }
            if (statusCode != 0 && statusCode != 408 && statusCode != 500 && statusCode != 502)
            {
                throw ex;
            }

            LogConsumer.Warning("Retrying the {0} request", method.ToString());
            TelemetryAnalytics.TrackHit(
                $"VTEX_handle_exception_retrying_{method.ToString()}_request"
            );
            return ex;
        }

        /// <summary>
        /// Configures the client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="requiresAuthentication">if set to <c>true</c> [requires authentication].</param>
        private void ConfigureClient(HttpClient client, bool requiresAuthentication)
        {
            client.DefaultRequestHeaders.ExpectContinue = false;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(@"application/json")
            );
            client.DefaultRequestHeaders.TryAddWithoutValidation(
                @"User-Agent",
                $@"guiBranco-VTEX-SDK-dotnet {InternalUserAgent} +https://github.com/guibranco/VTEX-SDK-dotnet"
            );
            if (!requiresAuthentication)
            {
                return;
            }

            client.DefaultRequestHeaders.Add(@"X-VTEX-API-AppKey", _appKey);
            client.DefaultRequestHeaders.Add(@"X-VTEX-API-AppToken", _appToken);
        }

        /// <summary>
        /// Sends an HTTP request asynchronously using the specified method and returns the response.
        /// </summary>
        /// <param name="method">The HTTP method to use for the request (e.g., GET, POST, DELETE, etc.).</param>
        /// <param name="token">A cancellation token to cancel the operation if needed.</param>
        /// <param name="data">The data to be sent in the request body, if applicable.</param>
        /// <param name="client">The HttpClient instance used to send the request.</param>
        /// <param name="uriBuilder">The UriBuilder that constructs the URI for the request.</param>
        /// <returns>A task that represents the asynchronous operation, containing the HttpResponseMessage received from the server.</returns>
        /// <remarks>
        /// This method handles different HTTP methods such as GET, POST, PUT, DELETE, and PATCH.
        /// It constructs the appropriate request based on the provided method and sends it using the specified HttpClient.
        /// If the method requires a body (like POST, PUT, or PATCH), it creates a StringContent object with the provided data.
        /// The method also supports cancellation through the provided CancellationToken.
        /// The response from the server is returned as an HttpResponseMessage, which can be used to inspect the result of the request.
        /// </remarks>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when an unsupported HTTP method is provided.</exception>
        private static async Task<HttpResponseMessage> RequestInternalAsync(
            HttpRequestMethod method,
            CancellationToken token,
            string data,
            HttpClient client,
            UriBuilder uriBuilder
        )
        {
            HttpResponseMessage response;
            StringContent content = null;
            if (!string.IsNullOrWhiteSpace(data))
            {
                content = new StringContent(data, Encoding.UTF8, @"application/json");
            }

            switch (method)
            {
                case HttpRequestMethod.DELETE:
                    response = await client
                        .DeleteAsync(uriBuilder.Uri, token)
                        .ConfigureAwait(false);
                    break;
                case HttpRequestMethod.GET:
                    response = await client.GetAsync(uriBuilder.Uri, token).ConfigureAwait(false);
                    break;
                case HttpRequestMethod.POST:
                    response = await client
                        .PostAsync(uriBuilder.Uri, content, token)
                        .ConfigureAwait(false);
                    break;
                case HttpRequestMethod.PUT:
                    response = await client
                        .PutAsync(uriBuilder.Uri, content, token)
                        .ConfigureAwait(false);
                    break;
                case HttpRequestMethod.PATCH:
                    var request = new HttpRequestMessage(new HttpMethod(@"PATCH"), uriBuilder.Uri)
                    {
                        Content = content,
                    };
                    response = await client.SendAsync(request, token).ConfigureAwait(false);
                    request.Dispose();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(method), method, null);
            }

            return response;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Retrieves a list of all collections.
        /// </summary>
        /// <param name="token">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation, containing the list of collections as a string.</returns>
        public async Task<string> GetCollectionsAsync(CancellationToken token)
        {
            return await ServiceInvokerAsync(HttpRequestMethod.GET, "collections", token);
        }

        /// <summary>
        /// Updates an existing collection.
        /// </summary>
        /// <param name="id">The identifier of the collection to be updated.</param>
        /// <param name="data">The data representing the updated collection.</param>
        /// <param name="token">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response as a string.</returns>
        public async Task<string> UpdateCollectionAsync(int id, string data, CancellationToken token)
        {
    return await ServiceInvokerAsync(HttpRequestMethod.PUT, $"collections/{id}", token, data: data);
}
        /// <summary>
        /// Deletes a collection.
        /// </summary>
        /// <param name="id">The identifier of the collection to be deleted.</param>
        /// <param name="token">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response as a string.</returns>
        public async Task<string> DeleteCollectionAsync(int id, CancellationToken token)
        {
        public async Task<string> DeleteCollectionAsync(int id, CancellationToken token)
            return await ServiceInvokerAsync(HttpRequestMethod.DELETE, $"collections/{id}", token);

        }
        /// <summary>
        /// Creates a new collection.
        /// </summary>
        /// <param name="data">The data representing the new collection to be created.</param>
        /// <param name="token">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response as a string.</returns>
        public async Task<string> CreateCollectionAsync(string data, CancellationToken token)
        {
            return await ServiceInvokerAsync(HttpRequestMethod.POST, "collections", token, data: data);

        }
        /// <summary>
        /// Sets the rest credentials.
        /// </summary>
        /// <param name="appKey">The application key.</param>
        /// <param name="appToken">The application token.</param>
        public void SetRestCredentials(string appKey, string appToken)
        {
            _appKey = appKey;
            _appToken = appToken;
        }

        /// <summary>
        /// Sets the vtex identifier client authentication cookie.
        /// </summary>
        /// <param name="cookieValue">The cookie value.</param>
        public void SetVtexIdClientAuthCookie(string cookieValue)
        {
            _authCookie = cookieValue;
        }

        /// <summary>
        /// Asynchronously invokes a service endpoint with the specified HTTP method and parameters.
        /// </summary>
        /// <param name="method">The HTTP request method to be used (e.g., GET, POST).</param>
        /// <param name="endpoint">The endpoint of the service to be invoked. This should not be localizable.</param>
        /// <param name="token">A cancellation token to observe while waiting for the task to complete.</param>
        /// <param name="queryString">An optional dictionary of query string parameters to be included in the request.</param>
        /// <param name="data">An optional string containing data to be sent with the request.</param>
        /// <param name="restEndpoint">An optional parameter specifying the REST endpoint type. Defaults to <see cref="RequestEndpoint.DEFAULT"/>.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response as a string.</returns>
        /// <remarks>
        /// This method constructs a URI using the provided endpoint and query string parameters,
        /// and then invokes the service asynchronously. It handles authentication and cookie management
        /// as needed based on the service requirements. The method is designed to work with various
        /// HTTP methods and can send data in the request body if specified.
        /// The response from the service is returned as a string, allowing for further processing or
        /// parsing as needed by the caller.
        /// </remarks>
        public async Task<string> ServiceInvokerAsync(
            HttpRequestMethod method,
            [Localizable(false)] string endpoint,
            CancellationToken token,
            Dictionary<string, string> queryString = null,
            string data = null,
            RequestEndpoint restEndpoint = RequestEndpoint.DEFAULT
        )
        {
            Cookie cookie = null;
            var requiresAuthentication = true;
            var protocol = @"https";
            var port = 443;
            var host = GetHostData(
                ref endpoint,
                ref queryString,
                restEndpoint,
                ref cookie,
                ref protocol,
                ref port,
                ref requiresAuthentication
            );
            var query = string.Empty;
            if (queryString is { Count: > 0 })
            {
                query = new QueryStringBuilder().AddRange(queryString).ToString();
            }

            var builder = new UriBuilder(protocol, host, port, endpoint)
            {
                Query = query.Replace(@"?", string.Empty),
            };
            return await ServiceInvokerInternal(
                    method,
                    endpoint,
                    token,
                    data,
                    builder,
                    cookie,
                    requiresAuthentication
                )
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the host data.
        /// </summary>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="queryString">The query string.</param>
        /// <param name="restEndpoint">The rest endpoint.</param>
        /// <param name="cookie">The cookie.</param>
        /// <param name="protocol">The protocol.</param>
        /// <param name="port">The port.</param>
        /// <param name="requiresAuthentication">if set to <c>true</c> [requires authentication].</param>
        /// <returns>System.String.</returns>
            ref string endpoint,
        ref string endpoint,
            ref Dictionary<string, string> queryString,
            RequestEndpoint restEndpoint,
            ref Cookie cookie,
            ref string protocol,
            ref int port,
            ref bool requiresAuthentication
        )
        {
            string host;
            switch (restEndpoint)
            {
                case RequestEndpoint.DEFAULT:
                    host = $@"{_accountName}.{VTEXConstants.PlatformStableDomain}";
                    endpoint = $@"api/{endpoint}";
                    break;
                case RequestEndpoint.PAYMENTS:
                    host = $@"{_accountName}.{VTEXConstants.PaymentsDomain}";
                    endpoint = $@"api/{endpoint}";
                    break;
                case RequestEndpoint.LOGISTICS:
                    host = VTEXConstants.LogisticsDomain;
                    endpoint = $@"api/{endpoint}";
                    if (queryString == null)
                    {
                        queryString = new();
                    }

                    queryString.Add(@"an", _accountName);
                    break;
                case RequestEndpoint.API:
                case RequestEndpoint.MASTER_DATA:
                    host = VTEXConstants.ApiDomain;
                    endpoint = $@"{_accountName}/{endpoint}";
                    break;
                case RequestEndpoint.BRIDGE:
                    host = $@"{_accountName}.{VTEXConstants.MyVtexDomain}";
                    endpoint = $@"api/{endpoint}";
                    if (!string.IsNullOrWhiteSpace(_authCookie))
                    {
                        cookie = new(VTEXConstants.VtexIdClientAuthCookieName, _authCookie);
                    }

                    break;
                case RequestEndpoint.HEALTH:
                    protocol = @"http";
                    port = 80;
                    host = VTEXConstants.MonitoringDomain;
                    endpoint = @"api/healthcheck/modules";
                    requiresAuthentication = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(restEndpoint), restEndpoint, null);
            }

            return host;
        }

        #endregion
