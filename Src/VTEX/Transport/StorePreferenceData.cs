namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The store preference data class.
    /// This class can not be inherited.
    /// </summary>
    public sealed class StorePreferenceData
    {
        /// <summary>
        /// Gets or sets the country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        /// <value>
        /// The currency code.
        /// </value>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency format information.
        /// </summary>
        /// <value>
        /// The currency format information.
        /// </value>
        [JsonProperty("currencyFormatInfo")]
        public CurrencyFormatInfo CurrencyFormatInfo { get; set; }

        /// <summary>
        /// Gets or sets the currency locale.
        /// </summary>
        /// <value>
        /// The currency locale.
        /// </value>
        [JsonProperty("currencyLocale")]
        public int CurrencyLocale { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        /// <value>
        /// The currency symbol.
        /// </value>
        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }
}
