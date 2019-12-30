namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class Facet. This class cannot be inherited.
    /// </summary>
    public sealed class Facet
    {

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public FacetItem[] Items { get; set; }

        /// <summary>
        /// Gets or sets the range URL template.
        /// </summary>
        /// <value>The range URL template.</value>
        [JsonProperty("rangeUrlTemplate")]
        public string RangeUrlTemplate { get; set; }
    }
}