namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using CrispyWaffle.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// Class RateAndBenefitsIdentifiers. This class cannot be inherited.
    /// </summary>
    public sealed class RateAndBenefitsIdentifiers
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the featured.
        /// </summary>
        /// <value>The featured.</value>
        [JsonProperty("featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the matched parameters.
        /// </summary>
        /// <value>
        /// The matched parameters.
        /// </value>
        [JsonProperty("matchedParameters")]
        public DynamicSerialization MatchedParameters { get; set; }

        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        /// <value>
        /// The additional information.
        /// </value>
        [JsonProperty("additionalInfo")]
        public NotNullObserver AdditionalInfo { get; set; }
    }
}
