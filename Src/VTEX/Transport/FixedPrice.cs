namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The fixed price class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class FixedPrice
    {
        /// <summary>
        /// Gets or sets the trade policy identifier.
        /// </summary>
        /// <value>
        /// The trade policy identifier.
        /// </value>
        [JsonProperty("tradePolicyId")]
        public string TradePolicyId { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("value")]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the listprice.
        /// </summary>
        /// <value>
        /// The listprice.
        /// </value>
        [JsonProperty("listPrice")]
        public decimal? Listprice { get; set; }

        /// <summary>
        /// Gets or sets the minimum quantity.
        /// </summary>
        /// <value>
        /// The minimum quantity.
        /// </value>
        [JsonProperty("minQuantity")]
        public int MinQuantity { get; set; }

        /// <summary>
        /// Gets or sets the date range.
        /// </summary>
        /// <value>
        /// The date range.
        /// </value>
        [JsonProperty("dateRange")]
        public DateRange DateRange { get; set; }
    }
}
