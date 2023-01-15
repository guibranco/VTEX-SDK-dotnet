namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The specification field value class.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class SpecificationFieldValue
    {
        /// <summary>
        /// Gets or sets the field value identifier.
        /// </summary>
        /// <value>
        /// The field value identifier.
        /// </value>
        [JsonProperty("FieldValueId")]
        public int FieldValueId { get; set; }

        /// <summary>
        /// Gets or sets the field identifier.
        /// </summary>
        /// <value>
        /// The field identifier.
        /// </value>
        [JsonProperty("FieldId")]
        public int FieldId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        [JsonProperty("Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [JsonProperty("Value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [JsonProperty("Position")]
        public int Position { get; set; }
    }
}
