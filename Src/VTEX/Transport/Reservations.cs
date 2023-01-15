// ***********************************************************************
namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Reservations. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public sealed class Reservations
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>The items.</value>
        [JsonProperty("items")]
        public Reservation[] Items { get; set; }

        /// <summary>
        /// Gets or sets the paging.
        /// </summary>
        /// <value>The paging.</value>
        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }
}
