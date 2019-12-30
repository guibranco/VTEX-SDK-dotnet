namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// 	List of stats.
    /// </summary>
    public sealed class StatsList
    {
        /// <summary>
        /// 	Gets or sets the stats.
        /// </summary>
        ///
        /// <value>
        /// 	The stats.
        /// </value>

        [JsonProperty("stats")]
        public StatsItem Stats { get; set; }
    }
}