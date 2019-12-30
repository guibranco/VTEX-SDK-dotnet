namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// A package attachment.
    /// </summary>
    public sealed class PackageAttachment
    {
        /// <summary>
        /// Gets or sets the packages.
        /// </summary>
        /// <value>The packages.</value>

        [JsonProperty("packages")]
        public Package[] Packages { get; set; }
    }
}