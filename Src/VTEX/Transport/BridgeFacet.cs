namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Class BridgeFacet. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class BridgeFacet
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// </summary>
        /// <value>The facets.</value>
        [JsonProperty("facets")]
        public Dictionary<string, string> Facets { get; set; }
    }
}
