namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class ItemOfPackage. This class cannot be inherited.
    /// </summary>
    public sealed class ItemOfPackage
    {
        /// <summary>
        /// Gets or sets the index of the item.
        /// </summary>
        /// <value>The index of the item.</value>
        [JsonProperty("itemIndex")]
        public int ItemIndex { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        [JsonProperty("price")]
        public int Price { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the unit multiplier.
        /// </summary>
        /// <value>The unit multiplier.</value>
        [JsonProperty("unitMultiplier")]
        public decimal UnitMultiplier { get; set; }
    }
}