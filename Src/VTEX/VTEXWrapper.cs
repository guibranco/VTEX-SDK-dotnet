namespace VTEX
{
    using CrispyWaffle.Extensions;
    using CrispyWaffle.Log;
    using CrispyWaffle.Telemetry;
    using CrispyWaffle.Utilities;
    using Enums;
    using GoodPractices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Wrapper. This class cannot be inherited.
    /// </summary>
    /// <seealso cref="IDisposable" />
    internal sealed class VTEXWrapper : IDisposable
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

                var assembly = System.Reflection.Assembly.GetAssembly(typeof(VTEXWrapper)).GetName();
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
        /// <returns></returns>
        private async Task<string> ServiceInvokerInternal(
            HttpRequestMethod method,
            string endpoint,
            CancellationToken token,
            string data,
            UriBuilder uriBuilder,
            Cookie cookie,
            bool requiresAuthentication,
            bool isRetry = false)
        {
            HttpResponseMessage response = null;
            string result = null;
            Exception exr;
            try
            {
                _requestMediator.WaitOne();
                LogConsumer.Trace("ServiceInvokerAsync -&gt; Method: {0} | Endpoint: {1}", method.GetHumanReadableValue(), endpoint);
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
            return await ServiceInvokerInternal(method, endpoint, token, data, uriBuilder, cookie, requiresAuthentication, true).ConfigureAwait(false);
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
        /// <exception cref="UnexpectedApiResponseException"></exception>
        private Exception HandleException(
            Exception exception,
            HttpResponseMessage response,
            Uri uri,
            HttpRequestMethod method,
            string data,
            string result)
        {
            var statusCode = 0;
            if (response != null)
            {
                statusCode = (int)response.StatusCode;
            }

            var ex = new UnexpectedApiResponseException(uri, method.ToString(), data, result, statusCode, exception);
            if (statusCode == 429 ||
                statusCode == 503)
            {
                _requestMediator.Reset();
                LogConsumer.Warning("HTTP {2} status code on method {0} - uri {1}", method.ToString(), uri, statusCode);
                Thread.Sleep(60 * 1000);
                _requestMediator.Set();
                return ex;
            }
            if (statusCode != 0 &&
                statusCode != 408 &&
                statusCode != 500 &&
                statusCode != 502)
            {
                throw ex;
            }

            LogConsumer.Warning("Retrying the {0} request", method.ToString());
            TelemetryAnalytics.TrackHit($"VTEX_handle_exception_retrying_{method.ToString()}_request");
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
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(@"application/json"));
            client.DefaultRequestHeaders.TryAddWithoutValidation(@"User-Agent", $@"guiBranco-VTEX-SDK-dotnet {InternalUserAgent} +https://github.com/guibranco/VTEX-SDK-dotnet");
            if (!requiresAuthentication)
            {
                return;
            }

            client.DefaultRequestHeaders.Add(@"X-VTEX-API-AppKey", _appKey);
            client.DefaultRequestHeaders.Add(@"X-VTEX-API-AppToken", _appToken);
        }

        /// <summary>
        /// Requests the internal asynchronous.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="token">The token.</param>
        /// <param name="data">The data.</param>
        /// <param name="client">The client.</param>
        /// <param name="uriBuilder">The URI builder.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">method - null</exception>
        private static async Task<HttpResponseMessage> RequestInternalAsync(
            HttpRequestMethod method,
            CancellationToken token,
            string data,
            HttpClient client,
            UriBuilder uriBuilder)
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
                    response = await client.DeleteAsync(uriBuilder.Uri, token).ConfigureAwait(false);
                    break;
                case HttpRequestMethod.GET:
                    response = await client.GetAsync(uriBuilder.Uri, token).ConfigureAwait(false);
                    break;
                case HttpRequestMethod.POST:
                    response = await client.PostAsync(uriBuilder.Uri, content, token).ConfigureAwait(false);
                    break;
                case HttpRequestMethod.PUT:
                    response = await client.PutAsync(uriBuilder.Uri, content, token).ConfigureAwait(false);
                    break;
                case HttpRequestMethod.PATCH:
                    var request = new HttpRequestMessage(new HttpMethod(@"PATCH"), uriBuilder.Uri)
                    {
                        Content = content
                    };
                    response = await client.SendAsync(request, token).ConfigureAwait(false);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(method), method, null);
            }

            return response;
        }

        #endregion

        #region Public methods

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
        /// Services the invoker asynchronous.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <param name="endpoint">The endpoint.</param>
        /// <param name="token">The token.</param>
        /// <param name="queryString">The query string.</param>
        /// <param name="data">The data.</param>
        /// <param name="restEndpoint">The rest endpoint.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">restEndpoint - null</exception>
        public async Task<string> ServiceInvokerAsync(
            HttpRequestMethod method,
            [Localizable(false)] string endpoint,
            CancellationToken token,
            Dictionary<string, string> queryString = null,
            string data = null,
            RequestEndpoint restEndpoint = RequestEndpoint.DEFAULT)
        {
            string host;
            Cookie cookie = null;
            var requiresAuthentication = true;
            var protocol = @"https";
            var port = 443;
            switch (restEndpoint)
            {
                case RequestEndpoint.DEFAULT:
                    host = $@"{_accountName}.vtexcommercestable.com.br";
                    endpoint = $@"api/{endpoint}";
                    break;
                case RequestEndpoint.PAYMENTS:
                    host = $@"{_accountName}.vtexpayments.com.br";
                    endpoint = $@"api/{endpoint}";
                    break;
                case RequestEndpoint.LOGISTICS:
                    host = @"logistics.vtexcommercestable.com.br";
                    endpoint = $@"api/{endpoint}";
                    if (queryString == null)
                    {
                        queryString = new Dictionary<string, string>();
                    }

                    queryString.Add(@"an", _accountName);
                    break;
                case RequestEndpoint.API:
                case RequestEndpoint.MASTER_DATA:
                    host = @"api.vtex.com";
                    endpoint = $@"{_accountName}/{endpoint}";
                    break;
                case RequestEndpoint.BRIDGE:
                    host = $@"{_accountName}.myvtex.com";
                    endpoint = $@"api/{endpoint}";
                    if (!string.IsNullOrWhiteSpace(_authCookie))
                    {
                        cookie = new Cookie("VtexIdclientAutCookie", _authCookie);
                    }

                    break;
                case RequestEndpoint.HEALTH:
                    protocol = @"http";
                    port = 80;
                    host = @"monitoring.vtex.com";
                    endpoint = @"api/healthcheck/modules";
                    requiresAuthentication = false;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(restEndpoint), restEndpoint, null);
            }
            var query = string.Empty;
            if (queryString != null &&
                queryString.Count > 0)
            {
                query = new QueryStringBuilder().AddRange(queryString).ToString();
            }

            var builder = new UriBuilder(protocol, host, port, endpoint)
            {
                Query = query.Replace(@"?", string.Empty)
            };
            return await ServiceInvokerInternal(method, endpoint, token, data, builder, cookie, requiresAuthentication)
                       .ConfigureAwait(false);
        }

        #endregion
    }
}
