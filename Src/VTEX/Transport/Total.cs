namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Total
    /// </summary>
    public sealed class Total
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
        ///     Gets or sets the name.
        /// </summary>
        ///
        /// <value>
        ///     The name.
        /// </value>

        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        ///
        /// <value>
        ///     The value.
        /// </value>

        [JsonProperty("value")]
        public int Value { get; set; }


        /// <summary>
        /// Gets or sets the alternative totals.
        /// </summary>
        /// <value>
        /// The alternative totals.
        /// </value>
        [JsonProperty("alternativeTotals")]
        public NotNullObserver AlternativeTotals { get; set; }
    }
}