namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Class ResponseReceipt. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class ResponseReceipt
    {
        /// <summary>
        /// The date
        /// </summary>
        private DateTime _date;
        /// <summary>
        /// The date set
        /// </summary>
        private bool _dateSet;

        /// <summary>
        /// Gets or sets the date internal.
        /// </summary>
        /// <value>The date internal.</value>
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
        /// <value>The date.</value>
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

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the receipt.
        /// </summary>
        /// <value>The receipt.</value>
        [JsonProperty("receipt")]
        public string Receipt { get; set; }

    }
}
