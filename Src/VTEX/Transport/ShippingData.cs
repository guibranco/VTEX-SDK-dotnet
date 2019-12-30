namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	A shipping data.
    /// </summary>
    public sealed class ShippingData
    {
        /// <summary>
        /// 	Gets or sets the identifier.
        /// </summary>
        ///
        /// <value>
        /// 	The identifier.
        /// </value>

        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 	Gets or sets the address.
        /// </summary>
        ///
        /// <value>
        /// 	The address.
        /// </value>

        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// 	Gets or sets information describing the logistics.
        /// </summary>
        ///
        /// <value>
        /// 	Information describing the logistics.
        /// </value>

        [JsonProperty("logisticsInfo")]
        public LogisticsInfo[] LogisticsInfo { get; set; }

        /// <summary>
        ///     Gets or sets the information describing the tracking hits
        /// </summary>
        /// 
        /// <value>
        ///     Information describing the tracking hits
        /// </value>
        [JsonProperty("trackingHints")]
        public TrackingHints[] TrackingHints { get; set; }

        /// <summary>
        /// Gets or sets the selected addresses.
        /// </summary>
        /// <value>
        /// The selected addresses.
        /// </value>
        [JsonProperty("selectedAddresses")]
        public Address[] SelectedAddresses { get; set; }
    }
}