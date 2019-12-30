namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// The changes attachment class.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class ChangesAttachment
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the changes data.
        /// </summary>
        /// <value>
        /// The changes data.
        /// </value>
        [JsonProperty("changesData")]
        public ChangeData[] ChangesData { get; set; }
    }
}
