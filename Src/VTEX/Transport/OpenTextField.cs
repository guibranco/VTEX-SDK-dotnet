namespace VTEX.Transport
{
    using Newtonsoft.Json;

    /// <summary>
    /// Class OpenTextField. This class cannot be inherited.
    /// </summary>
    public sealed class OpenTextField
    {
        /// <summary>
        /// The value
        /// </summary>
        private string _value;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public string Value
        {
            get => _value;
            set => _value = value;
        }

        /// <summary>
        /// Gets the dynamic.
        /// </summary>
        /// <value>The dynamic.</value>
        [JsonIgnore]
        public dynamic Dynamic => JsonConvert.DeserializeObject(_value);
    }
}