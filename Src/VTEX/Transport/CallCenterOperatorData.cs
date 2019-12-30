// file:	DTOSC\CallCenterOperatorData.cs
//
// summary:	Implements the call center operator data class

namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    ///     A call center operator data.
    /// </summary>
    ///
    /// <remarks>
    ///     Versão: 1.51.2928.607
    ///     Autor: Guilherme Branco Stracini
    ///     Data: 31/03/2014.
    /// </remarks>

    public sealed class CallCenterOperatorData
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        ///     The identifier.
        /// </value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        ///
        /// <value>
        ///     The email.
        /// </value>

        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the name of the user.
        /// </summary>
        ///
        /// <value>
        ///     The name of the user.
        /// </value>

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }
}
