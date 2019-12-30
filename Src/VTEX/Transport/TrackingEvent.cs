namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Class TrackingEvent. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class TrackingEvent
    {
        #region Private fields

        /// <summary>
        /// The date
        /// </summary>
        private DateTime _date;
        /// <summary>
        /// The date set
        /// </summary>
        private bool _dateSet;

        #endregion

        #region Public properties

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date internal.
        /// </summary>
        /// <value>
        /// The date internal.
        /// </value>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonProperty("date")]
        public string DateInternal
        {
            get => _dateSet
                       ? _date.ToString(@"s")
                       : null;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _date = DateTime.Parse(value);
                _dateSet = true;
            }
        }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [JsonIgnore]
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                _dateSet = true;
            }
        }

        #endregion
    }
}
