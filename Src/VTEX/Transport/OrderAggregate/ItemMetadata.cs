namespace IntegracaoService.VTEX.Transport.OrderAggregate
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class ItemMetadata.
    /// </summary>
    public class ItemMetadata
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("Items")]
        public ItemMetadataItem[] Items { get; set; }
    }
}