namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// 	A payment data.
    /// </summary>
    public sealed class PaymentData
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
        /// 	Gets or sets the gift cards.
        /// </summary>
        ///
        /// <value>
        /// 	The gift cards.
        /// </value>

        [JsonProperty("giftCards")]
        public NotNullObserver[] GiftCards { get; set; }

        /// <summary>
        /// 	Gets or sets the transactions.
        /// </summary>
        ///
        /// <value>
        /// 	The transactions.
        /// </value>

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }
    }
}