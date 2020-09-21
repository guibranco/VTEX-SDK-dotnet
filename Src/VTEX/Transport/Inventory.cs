namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Inventory. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Inventory
    {
        /// <summary>
        /// Gets or sets the sku identifier.
        /// </summary>
        /// <value>The sku identifier.</value>
        [JsonProperty("skuid")]
        public int SkuId { get; set; }

        /// <summary>
        /// Gets or sets the balances.
        /// </summary>
        /// <value>The balances.</value>
        [JsonProperty("balance")]
        public Balance[] Balances { get; set; }
    }
}
