namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class OrdersList. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class OrdersList
    {
        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>The list.</value>
        [JsonProperty("list")]
        public List[] List { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// </summary>
        /// <value>The facets.</value>
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        /// <summary>
        /// Gets or sets the paging.
        /// </summary>
        /// <value>The paging.</value>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        /// <value>The stats.</value>
        [JsonProperty("stats")]
        public StatsList Stats { get; set; }

        /// <summary>
        /// Gets or sets the report records limit.
        /// </summary>
        /// <value>The report records limit.</value>
        [JsonProperty("reportRecordsLimit")]
        public int ReportRecordsLimit { get; set; }
    }
}
