namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The item changed class
    /// </summary>
    /// <seealso cref="ItemOfInvoice" />
    public sealed class ItemChanged : ItemOfInvoice
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <remarks>
        /// This property is used in Order.ChangesAttachment.ChangesData[].Items[Added|Removed]
        /// This property is not used in invoice operations!
        /// </remarks>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unit multiplier.
        /// </summary>
        /// <value>
        /// The unit multiplier.
        /// </value>
        [JsonProperty("unitMultiplier")]
        public decimal UnitMultiplier { get; set; }
    }
}
