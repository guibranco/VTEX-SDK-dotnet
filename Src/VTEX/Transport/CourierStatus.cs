namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class CourierStatus. This class cannot be inherited.
    /// </summary>
    public sealed class CourierStatus
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the finished.
        /// </summary>
        /// <value>The finished.</value>
        [JsonProperty("finished")]
        public bool Finished { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        [JsonProperty("data")]
        public CourierData[] Data { get; set; }
    }
}