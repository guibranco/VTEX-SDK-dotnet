namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    ///     A seller.
    /// </summary>
    public sealed class Seller
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        ///     The identifier.
        /// </value>

        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        ///
        /// <value>
        ///     The name.
        /// </value>

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the logo.
        /// </summary>
        ///
        /// <value>
        ///     The logo.
        /// </value>

        [JsonProperty("logo")]
        public string Logo { get; set; }
    }
}