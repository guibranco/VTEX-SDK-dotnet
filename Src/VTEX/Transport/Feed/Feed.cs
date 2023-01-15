namespace IntegracaoService.VTEX.Transport.Feed
{
    using CrispyWaffle.Serialization;
    using System;

    /// <summary>
    /// Class Feed.
    /// </summary>
    [Serializer(SerializerFormat.Json)]
    public class Feed
    {
        /// <summary>
        /// Gets or sets the event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        public string EventId { get; set; }

        /// <summary>
        /// Gets or sets the handle.
        /// </summary>
        /// <value>The handle.</value>
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>The domain.</value>
        public int Domain { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public int State { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>The order identifier.</value>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the last change.
        /// </summary>
        /// <value>The last change.</value>
        public DateTime LastChange { get; set; }

        /// <summary>
        /// Gets or sets the current change.
        /// </summary>
        /// <value>The current change.</value>
        public DateTime CurrentChange { get; set; }
    }
}
