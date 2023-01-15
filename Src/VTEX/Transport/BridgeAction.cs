namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class BridgeAction. This class cannot be inherited.
    /// </summary>

    [Serializer(SerializerFormat.Json)]
    public sealed class BridgeAction
    {
        /// <summary>
        /// Gets or sets the action identifier.
        /// </summary>
        /// <value>The action identifier.</value>
        [JsonProperty("actionid")]
        public string ActionId { get; set; }

        /// <summary>
        /// Gets or sets the URL callback.
        /// </summary>
        /// <value>The URL callback.</value>
        [JsonProperty("urlcallback")]
        public string UrlCallback { get; set; }

    }
}
